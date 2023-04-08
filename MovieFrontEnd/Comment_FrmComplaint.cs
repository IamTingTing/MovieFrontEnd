using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MovieFrontEnd;

namespace prjMovieCmt
{
    public partial class Comment_FrmComplaint : Form
    {
        public Comment_FrmComplaint()
        {
            InitializeComponent();
        }
        public Comment_FrmComplaint(int ID)
        {
            InitializeComponent();
            MemberID = ID;
        }

        public int MemberID { get; set; }

        MovieEntities dbcontext = new MovieEntities();

        private void FrmComplaint_Load(object sender, EventArgs e)
        {
            var q = from type in this.dbcontext.CnQTypes
                    select type.CnQType1;
            cmbCategories.Items.Clear();
            foreach (var item in q) { cmbCategories.Items.Add(item); }
            if (MemberID != 0)
            {
                var f = from mem in this.dbcontext.Members
                        where mem.MemberID == MemberID
                        select mem.Name;
                txtMemberName.Text = f.First();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = 0;
            txtText.Text = "";
            checkIsComplaint.Checked = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cmbCategories.Text.Length > 0 && txtText.TextLength > 0)
            {
                    //TODO: 應該包進scope 
                    var q = from type in dbcontext.CnQTypes
                            where type.CnQType1 == cmbCategories.SelectedItem.ToString()
                            select type.CnQType_ID;
                    CnQ cnq = new CnQ();
                    cnq.Member_ID = this.MemberID;
                    cnq.CnQType_ID = q.ToList().First();
                    cnq.Text = txtText.Text;
                    cnq.IsComplaint = checkIsComplaint.Checked;
                    dbcontext.CnQs.Add(cnq);
                    dbcontext.SaveChanges();

                    var cs = from cq in dbcontext.CnQs as IEnumerable<CnQ>
                             select cq.CnQ_ID;
                    int newID = cs.Last();
                    
                    CnQStatusList statusList = new CnQStatusList();
                    statusList.Status_ID = 1;
                    statusList.CnQ_ID = newID;
                    statusList.TimeStamp = DateTime.Now;
                    dbcontext.CnQStatusLists.Add(statusList);
                    dbcontext.SaveChanges();
                    
                    MessageBox.Show("新增成功");
                btnClear.PerformClick();

            }
            else MessageBox.Show("欄位不得為空");

        }
        #region MyCnQs
        private void tabsComplaint_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabMyCnQs)
            {
                
                RefreshList();
            }
        }
        
        int _CnQID = 0;
        private void RefreshList()
        {
            lstMyCnQs.Items.Clear();
            btnReOpen.Enabled = false;
            btnSatisfied.Enabled = false;
            MovieEntities dbcontext1 = new MovieEntities();
            var q = from cs in dbcontext1.CnQStatusLists.AsEnumerable()
                    where cs.CnQ.Member_ID == MemberID
                    group cs by cs.CnQ_ID into g
                    select new { g.Key, g.Last().StatusList.StatusText };
            foreach (var cs in q) { lstMyCnQs.Items.Add($"{cs.Key} ({cs.StatusText})"); }
            
        }

        private void lstMyCnQs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMyCnQs.SelectedIndex < lstMyCnQs.Items.Count)
            {
                string[] s = lstMyCnQs.SelectedItem.ToString().Split(' ');
                int id = int.Parse(s[0]);
                ShowText(id);
                ShowReply(id);
                _CnQID = id;
                SetButton(id);
            }
        }

        private void SetButton(int id) 
        {
            btnReOpen.Enabled = false;
            btnSatisfied.Enabled = false;
            btnSatisfied.Text = "滿意";
            var q = from cs in dbcontext.CnQStatusLists.AsEnumerable()
                    where cs.CnQ.Member_ID == MemberID && cs.CnQ_ID == id
                    select new { cs.Status_ID};
            switch (q.Last().Status_ID)
            {
                case 1:
                    btnSatisfied.Enabled = true;
                    btnSatisfied.Text = "收回";
                    break;
                case 4:
                    btnReOpen.Enabled = true;
                    btnSatisfied.Enabled = true;
                    break;
                default: // status in (2,3,5) 不能變更狀態
                    break;
            }
           

        }
        
        private void ShowText(int id)
        {
            txtCnQ.Text = string.Empty;
            var q = from cnq in dbcontext.CnQs
                    where cnq.CnQ_ID == id
                    select cnq.Text;
            txtCnQ.Text = q.First();
        }

        private void ShowReply(int id)
        {
            txtReply.Text = string.Empty;
            var q = from cnq in dbcontext.CnQStatusLists.AsEnumerable()
                    where cnq.CnQ_ID == id
                    select cnq;
            if (q.Last().Reply_ID.HasValue)
            {
                var q2 = from re in dbcontext.Replies.AsEnumerable()
                        where re.Reply_ID == q.Last().Reply_ID
                        select re.Reply1;
                txtReply.Text = q2.Last();
            }
        }

        private void btnSatisfied_Click(object sender, EventArgs e)
        {
           
                CnQStatusList cnQStatusList = new CnQStatusList
                {
                    CnQ_ID = _CnQID,
                    TimeStamp = DateTime.Now,
                    Status_ID = 5

                };
                this.dbcontext.CnQStatusLists.Add(cnQStatusList);
                this.dbcontext.SaveChanges();
                RefreshList();
               
        }
        private void btnReOpen_Click(object sender, EventArgs e)
        {
           
                CnQStatusList cnQStatusList = new CnQStatusList
                {
                    CnQ_ID = _CnQID,
                    TimeStamp = DateTime.Now,
                    Status_ID = 3

                };
                this.dbcontext.CnQStatusLists.Add(cnQStatusList);
                this.dbcontext.SaveChanges();
                RefreshList();
              
        }



        #endregion


    }
}
