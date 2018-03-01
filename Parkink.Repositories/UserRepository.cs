using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return context.PaymentMethods.FirstOrDefault(x => x.PaymentMethodID == 4);
            }
        }

        public User GetUserById(string document)
        {
            using (var context = new PLTOEntities())
            {
                return context.Users.FirstOrDefault(x => x.Document == document);
            }
        }


        public bool ValidMonthlyPayment(string plate)
        {
            using (var context = new PLTOEntities())
            {
                var result = context.MonthlyPayments.Where(x => x.Plate == plate && (DateTime.Now  >= x.PaymentDate && DateTime.Now <= x.ExpirationDate )).ToList();

                if (result == null) return true;
                else return false;
            }
        }
    }
}
