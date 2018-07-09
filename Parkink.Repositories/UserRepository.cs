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
                           where u.Plate == plate
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

        public List<Client> GetUserByPlateOrDocument(string search)
        {
            using (var context = new PLTOEntities())
            {
                var users = (from u in context.Clients
                            where u.Plate.Contains(search) || u.Document.Contains(search) || u.Name.Contains(search)
                            select u).ToList();

                return users;
            }
        }

        public Client EditClient(Client client)
        {
            using (var context = new PLTOEntities())
            {
                var user = context.Clients.FirstOrDefault(x => x.Plate == client.Plate);

                if (user == null)
                {
                    user = new Client
                    {
                        Plate = client.Plate,
                        Document = client.Document,
                        DocTypeID = client.DocTypeID,
                        Name = client.Name,
                        CelPhone = client.CelPhone
                    };
                    context.Clients.Add(client);
                }
                else
                {                    
                    user.Document = client.Document;
                    user.DocTypeID = client.DocTypeID;
                    user.Name = client.Name;
                    user.CelPhone = client.CelPhone;
                }

                context.SaveChanges();

                return context.Clients.FirstOrDefault(x => x.Plate == client.Plate);
            }
        }
    }
}
