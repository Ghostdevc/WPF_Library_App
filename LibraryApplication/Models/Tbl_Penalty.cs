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
    
    public partial class Tbl_Penalty
    {
        public int Id_Penalty { get; set; }
        public Nullable<int> FK_UserID { get; set; }
        public Nullable<int> FK_PenalPolicyID { get; set; }
        public Nullable<System.DateTime> Penalty_Expires_On { get; set; }
        public Nullable<int> FK_Punished_Reservation_id { get; set; }
    
        public virtual Tbl_PenalPolicy Tbl_PenalPolicy { get; set; }
        public virtual Tbl_Reservation Tbl_Reservation { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
    }
}