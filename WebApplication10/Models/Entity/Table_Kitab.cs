//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication10.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Kitab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Kitab()
        {
            this.Table_Haraket = new HashSet<Table_Haraket>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public Nullable<byte> KATEGORI { get; set; }
        public Nullable<int> YAZAR { get; set; }
        public string BASIM_YIL { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public string YAYIN_EVI { get; set; }
        public string SAYFA_SAYI { get; set; }
        public Nullable<int> KITAB_SAYI { get; set; }
        public string KITAB_Resim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Haraket> Table_Haraket { get; set; }
        public virtual Table_Kategori Table_Kategori { get; set; }
        public virtual Tablo_YAZAR Tablo_YAZAR { get; set; }
    }
}
