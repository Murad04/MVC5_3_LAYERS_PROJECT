//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5_3_LAYERS_PROJECT.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Haraket
    {
        public int ID { get; set; }
        public Nullable<int> KITAB { get; set; }
        public Nullable<int> UYE { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<System.DateTime> ALISTARIHI { get; set; }
        public Nullable<System.DateTime> VERISTARIHI { get; set; }
        public Nullable<bool> ISLEMDURUM { get; set; }
        public Nullable<System.DateTime> UYEGETIRTARIH { get; set; }
    
        public virtual Table_Kitab Table_Kitab { get; set; }
        public virtual Table_Personel Table_Personel { get; set; }
        public virtual Table_Uyeler Table_Uyeler { get; set; }
    }
}