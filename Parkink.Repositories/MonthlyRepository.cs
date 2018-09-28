using Parking.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;


namespace Parking.Repositories
{
    public class MonthlyRepository
    {
        public List<PaymentMethod> GetLongTermPayments()
        {
            using (var context = new PLTOEntities())
            {                
                return context.PaymentMethods.Where(z => z.LongTermPayment == true).ToList();
            }
        }

        public PaymentMethod GetPaymentByID(int paymentMethodID)
        {
            using (var context = new PLTOEntities())
            {                
                return context.PaymentMethods.FirstOrDefault(z => z.PaymentMethodID == paymentMethodID);
            }
        }
    }
}
