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
    
    public partial class Tbl_Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Reservation()
        {
            this.Tbl_Penalty = new HashSet<Tbl_Penalty>();
        }
    
        public int Id_Reservation { get; set; }
        public Nullable<int> FK_BookID { get; set; }
        public Nullable<int> FK_Booked_to_UserID { get; set; }
        public Nullable<System.DateTime> Booking_Date { get; set; }
        public Nullable<System.DateTime> ExpectedToReturn_Date { get; set; }
        public Nullable<int> FK_Reservation_Status_ID { get; set; }
        public Nullable<System.DateTime> Return_date { get; set; }
    
        public virtual Tbl_Book Tbl_Book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Penalty> Tbl_Penalty { get; set; }
        public virtual Tbl_Reservation_Status Tbl_Reservation_Status { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
    }
}
