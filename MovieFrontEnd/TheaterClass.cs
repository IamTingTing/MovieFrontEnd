//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieFrontEnd
{
    using System;
    using System.Collections.Generic;
    
    public partial class TheaterClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheaterClass()
        {
            this.Theaters = new HashSet<Theater>();
        }
    
        public int TheaterClass_ID { get; set; }
        public string TheaterClass1 { get; set; }
        public decimal PriceRate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Theater> Theaters { get; set; }
    }
}
