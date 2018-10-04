//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parking.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonthlyPayment
    {
        public string MonthlyPaymentID { get; set; }
        public string Plate { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal PaidValue { get; set; }
        public decimal Refund { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> IsWorkShiftClosed { get; set; }
        public Nullable<System.DateTime> WorkShiftCloseDate { get; set; }
        public Nullable<int> PaymentMethodID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
