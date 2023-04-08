using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrderSystem
{
    public partial class Order_Seat : Form
    {
        public Order_Seat()
        {
            InitializeComponent();
        }

        int ticketTotalCount;
        public Order_Seat(List<int> list1,List<int> list2,List<int>list3, int count)
        {
            InitializeComponent();
            ticketTotalCount = count;
            lab_LeftSeatChooseCount.Text = $"尚可選座位數：{ticketTotalCount}";
            foreach (var item in Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)item).Name = ((CheckBox)item).Name.Remove(0, 8);
                    ((CheckBox)item).Click += CheckBox_Click;

                    foreach (var item1 in list1)
                    {
                        if (((CheckBox)item).Name == item1.ToString())
                            ((CheckBox)item).Enabled = false;
                    }
                    foreach (var item2 in list2)
                    {
                        if (((CheckBox)item).Name == item2.ToString())
                            ((CheckBox)item).Visible = false;
                    }
                    foreach (var item3 in list3)
                    {
                        if (((CheckBox)item).Name == item3.ToString())
                            ((CheckBox)item).BackColor = Color.Blue;
                    }
                }
            }
            
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            { 
                ticketTotalCount--; 
                if(ticketTotalCount<0)
                {
                    ((CheckBox)sender).Checked = false;
                    ticketTotalCount = 0;
                }
            }
            else
                ticketTotalCount++;
            lab_LeftSeatChooseCount.Text = $"尚可選座位數：{ticketTotalCount}";
        }

        internal List<CheckedSeatPosition> list_checked = new List<CheckedSeatPosition>();
      

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //選到被勾選的座位
            foreach (Control control in this.Controls)
            {
                if(control.GetType()==typeof(CheckBox))
                {
                    CheckedSeatPosition checkedSeatPosition = new CheckedSeatPosition();

                    if (((CheckBox)control).Checked == true)
                    {
                        if ((int.Parse(control.Name)) % 20 != 0)
                        {
                            checkedSeatPosition.SeatID = int.Parse(control.Name);
                            checkedSeatPosition.SeatRow = (int.Parse(control.Name)) / 20 + 1;
                            checkedSeatPosition.SeatColumn = (int.Parse(control.Name)) % 20;
                        }
                        else
                        {
                            checkedSeatPosition.SeatID = int.Parse(control.Name);
                            checkedSeatPosition.SeatRow = (int.Parse(control.Name)) / 20;
                            checkedSeatPosition.SeatColumn = (int.Parse(control.Name)) % 20;
                        }
                        list_checked.Add(checkedSeatPosition); 
                    }
                       
                }
            }

            //確認座位數與選擇張數是否符合
            if (ticketTotalCount !=0 )
            {
                MessageBox.Show("座位數不符合選擇張數");
                list_checked.Clear();
                return;
            }

            //顯示選擇座位
            string seats="您的選擇座位為：";
            foreach (var item in list_checked)
            {
                seats+=$"\n第{item.SeatRow}排 " +
                    $"第{item.SeatColumn}個";
            }
            DialogResult result= MessageBox.Show(seats,"確認座位",MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
