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
    
    public partial class usp_SelectLastMonthlyPayment_Result
    {
        public string MonthlyPaymentID { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Plate { get; set; }
        public decimal PaidValue { get; set; }
        public decimal TotalPayment { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string CelPhone { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
