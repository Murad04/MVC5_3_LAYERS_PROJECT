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
    
    public partial class Table_Ceza
    {
        public int ID { get; set; }
        public Nullable<int> UYE { get; set; }
        public Nullable<System.DateTime> BASLANGIC { get; set; }
        public Nullable<System.DateTime> BITIS { get; set; }
        public Nullable<decimal> PARA { get; set; }
    
        public virtual Table_Uyeler Table_Uyeler { get; set; }
    }
}