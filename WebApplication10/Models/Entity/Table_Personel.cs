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
    
    public partial class Table_Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Personel()
        {
            this.Table_Haraket = new HashSet<Table_Haraket>();
        }
    
        public int ID { get; set; }
        public string PERSONEL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Haraket> Table_Haraket { get; set; }
    }
}