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


        public MonthlyPayment GetMonthlyPaymentByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {
                var data = (from m in context.MonthlyPayments
                            join c in context.Clients on m.Plate equals c.Plate
                            where m.Plate == plate && c.IsActive == true
                            select m
                            ).FirstOrDefault();

                return data;
            }
        }

        public bool UpdateMonthlyPaymentsPlate(string oldPlate, string newPlate)
        {
            using (var context = new PLTOEntities())
            {
                var payments = context.MonthlyPayments.Where(x => x.Plate == oldPlate).ToList();

                if (payments == null)
                {
                    throw new Exception("No existen mensualidades para actualizar.");
                }
                else
                {
                    if (payments.Count > 0)
                    {
                        payments.ToList().ForEach(u => u.Plate = newPlate);
                    }
                }

                context.SaveChanges();

                return true;
            }
        }   
    }
}
