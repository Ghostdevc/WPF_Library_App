//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_PenalPolicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_PenalPolicy()
        {
            this.Tbl_Penalty = new HashSet<Tbl_Penalty>();
        }
    
        public int Id_PenalPolicy { get; set; }
        public Nullable<int> Penalty_Days { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Penalty> Tbl_Penalty { get; set; }
    }
}