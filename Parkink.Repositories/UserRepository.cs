using System;
using System.Collections.Generic;
using System.Linq;
using Parking.Models;
using System.Data.Entity;

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
                //return context.MonthlyPayments.Where(x => x.Plate == plate).OrderByDescending(t => t.ExpirationDate).FirstOrDefault();             
                var result = (from m in context.MonthlyPayments
                              join c in context.Clients on m.Plate equals c.Plate
                              where m.Plate == plate && c.IsActive == true
                              orderby m.ExpirationDate descending
                              select m
                           ).FirstOrDefault();
                return result;
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

        public MonthlyPaymentDto GetMonthlyPaymentByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {
                return (from mp in context.MonthlyPayments
                        join pm in context.PaymentMethods on mp.PaymentMethodID equals pm.PaymentMethodID
                        where mp.Plate == plate && DbFunctions.TruncateTime(DateTime.Now) <= DbFunctions.TruncateTime(mp.ExpirationDate) 
                        select new MonthlyPaymentDto
                        {
                            MonthlyPaymentID = mp.MonthlyPaymentID,
                            ExpirationDate = mp.ExpirationDate,
                            PaymentDescriptiion = pm.Description,
                            Plate = mp.Plate
                        }).FirstOrDefault();
               
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
                        CelPhone = client.CelPhone,
                        IsActive = client.IsActive
                    };
                    context.Clients.Add(client);
                }
                else
                {                    
                    user.Document = client.Document;
                    user.DocTypeID = client.DocTypeID;
                    user.Name = client.Name;
                    user.CelPhone = client.CelPhone;
                    user.IsActive = client.IsActive;
                }

                context.SaveChanges();

                return context.Clients.FirstOrDefault(x => x.Plate == client.Plate);
            }
        }


        public Client InactiveClient(Client client)
        {
            using (var context = new PLTOEntities())
            {
                var user = context.Clients.FirstOrDefault(x => x.Plate == client.Plate);

                if (user == null)
                {
                    throw new Exception("El usuario no existe.");
                }
                else
                {                 
                    user.IsActive = client.IsActive;
                }

                context.SaveChanges();

                return context.Clients.FirstOrDefault(x => x.Plate == client.Plate);
            }
        }


        public AppUser GetAdmin(int appUserID)
        {
            using (var context = new PLTOEntities())
            {
                var user = context.AppUsers.FirstOrDefault(x => x.UserID == appUserID && x.RolID  == 1);

               return user;
            }
        }

    }
}
