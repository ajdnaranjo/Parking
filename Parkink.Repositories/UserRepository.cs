using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking.Repositories
{
    public class UserRepository
    {
        public List<DocType> GetDocTypes()
        {
            using (var context = new PLTOEntities())
            {
                return context.DocTypes.ToList();
            }
        }

        public PaymentMethod GetMonthlyPayment()
        {
            using (var context = new PLTOEntities())
            {
                return context.PaymentMethods.FirstOrDefault(x => x.Description == "Mensualidad");
            }
        }

        public Client GetUserById(string document)
        {
            using (var context = new PLTOEntities())
            {
                return context.Clients.FirstOrDefault(x => x.Document == document);
            }
        }

        public MonthlyPayment ValidMonthlyPayment(string plate)
        {
            using (var context = new PLTOEntities())
            {
                return context.MonthlyPayments.Where(x => x.Plate == plate).OrderByDescending(t => t.ExpirationDate).FirstOrDefault();             
            }
        }

        public Client GetUserByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {
                var user = (from u in context.Clients
                           join mp in context.MonthlyPayments on u.Document equals mp.Document
                           where mp.Plate == plate
                           select u).FirstOrDefault();

                return user;
            }
        }

        public MonthlyPayment GetMonthlyPaymentByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {
                return context.MonthlyPayments.FirstOrDefault(x => x.Plate == plate && DateTime.Now <= x.ExpirationDate);
            }
        }
    }
}
