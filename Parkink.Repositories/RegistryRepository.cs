using Parking.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace Parking.Repositories
{
    public class RegistryRepository
    {
        public bool flag = false;

        public Registry CheckEntryExit(Registry registry, int userID)
        {
            using (
                var context = new PLTOEntities())
            {

                var repo = new ConfigurationRepository();

                var reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.ExitDate == null && r.DeletedDate == null);

                if (reg == null)
                {
                 
                    reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.DayPayment == true && r.IsInSite == true
                                    && DbFunctions.DiffMinutes(r.EntryDate, DateTime.Now).Value >= 720 && r.DeletedDate == null);
                }

                if (reg == null)
                {
                    reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.DayPayment == true
                            && DbFunctions.DiffMinutes(r.EntryDate, DateTime.Now).Value < 720 //&& r.ExitDate.Value.Day == DateTime.Now.Day 
                            && r.DeletedDate == null);

                    if (reg == null && registry.DayPayment == false)
                    {
                        reg = new Registry
                        {
                            RegistryID = repo.GetReceiptNumber(),
                            Plate = registry.Plate,
                            EntryDate = registry.EntryDate,
                            CreatedBy = userID,
                            IsWorkShiftClosed = registry.IsWorkShiftClosed,
                            Locker = registry.Locker,
                            DayPayment = registry.DayPayment,
                            ModifiedDate = DateTime.Now,
                            IsInSite = true
                        };
                        context.Registries.Add(reg);

                        context.SaveChanges();
                        registry.RegistryID = reg.RegistryID;

                    }
                    else
                    {
                        if (reg == null)
                        {
                            reg = new Registry
                            {
                                Plate = registry.Plate,
                                Locker = registry.Locker,
                                DayPayment = registry.DayPayment
                            };
                        }

                        if (reg.DayPayment == true && reg.ExitDate == null)                    
                        {
                           
                            reg.TotalPayment = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 3).Value;
                            reg.ExitDate = DateTime.Now;
                            var dif = reg.ExitDate.Value.Subtract(reg.EntryDate);
                            reg.Days = dif.Days;
                            reg.Hours = dif.Hours;
                            reg.Minutes = dif.Minutes;
                            reg.Locker = registry.Locker;
                        }
                        else
                            reg.TotalPayment = 0;
                    }


                }
                else
                {
                    if (reg.DayPayment == true)
                    {

                        reg.EntryDate = reg.EntryDate.AddHours(12);
                        var result = InsertRegistry(reg, userID);
                        UpdateIsInSite(reg, false);
                        reg = context.Registries.FirstOrDefault(r => r.RegistryID == result.RegistryID);
                        registry.DayPayment = false;
                    }


                    reg.ExitDate = DateTime.Now;
                    var dif = DateTime.Now.Subtract(reg.EntryDate);
                    reg.Days = dif.Days;
                    reg.Hours = dif.Hours;
                    reg.Minutes = dif.Minutes;
                    var hours = (dif.Days * 24) / 12;
                    reg.TotalPayment = 0;

                    var daysValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 3);
                    var hoursValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 2);
                    var minutesValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 1);

                    reg.TotalPayment = hours * daysValues.Value;


                    if (dif.Hours >= int.Parse(Globals.ConfigGlobal.DayHours))
                    {
                        if (dif.Hours >= 12)
                        {
                            var dayHours = (dif.Hours - 12);

                            if (dayHours >= int.Parse(Globals.ConfigGlobal.DayHours))
                                reg.TotalPayment = reg.TotalPayment + (daysValues.Value * 2);
                            else
                            {
                                reg.TotalPayment = reg.TotalPayment + daysValues.Value;

                                reg.TotalPayment = reg.TotalPayment + (dayHours * hoursValues.Value);

                                if (dif.Minutes > 0 && dif.Minutes < 30) reg.TotalPayment = reg.TotalPayment + minutesValues.Value;
                                else if (dif.Minutes >= 30 && dif.Minutes < 60) reg.TotalPayment = reg.TotalPayment + (minutesValues.Value * 2);

                            }
                        }
                        else
                            reg.TotalPayment = reg.TotalPayment + daysValues.Value;
                    }
                    else
                    {

                        var day = dif.Hours * hoursValues.Value;

                        if (dif.Minutes > 0 && dif.Minutes < 30) day = day + minutesValues.Value;
                        else if (dif.Minutes >= 30 && dif.Minutes < 60) day = day + (minutesValues.Value * 2);

                        if (day > daysValues.Value) day = daysValues.Value;

                        reg.TotalPayment = reg.TotalPayment + day;
                    }
                    //reg.DayPayment = registry.DayPayment;
                    if ((reg.DayPayment == true || registry.DayPayment == true) && reg.TotalPayment < daysValues.Value && reg.Hours < 12)
                    {
                        reg.TotalPayment = daysValues.Value;
                        reg.DayPayment = true;
                    }
                 

                }
                return reg;
            }

        }
     

        public Registry CheckExit(Registry registry, int userID, bool flag = false)
        {
            using (var context = new PLTOEntities())
            {
                var repo = new ConfigurationRepository();

                var reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.ExitDate == null && r.DeletedDate == null);

                if (reg == null)
                {
                    reg = new Registry
                    {
                        RegistryID = repo.GetReceiptNumber(),
                        Plate = registry.Plate,
                        EntryDate = DateTime.Now,
                        CreatedBy = userID,
                        IsWorkShiftClosed = false,
                        Locker = registry.Locker,
                        DayPayment = registry.DayPayment,
                        ModifiedDate = DateTime.Now,
                        IsInSite = true,
                        TotalPayment = registry.TotalPayment,
                        Payment = registry.Payment,
                        Refund = registry.Refund,
                        ExitDate = DateTime.Now,
                        ModifiedBy = userID,
                        Days = 0,
                        Hours = 0,
                        Minutes = 0
                };

                    context.Registries.Add(reg);
                }               
                else 
                {
                    if (reg.IsInSite == true) reg.IsInSite = false;

                    reg.Plate = registry.Plate;
                    reg.ExitDate = registry.ExitDate;
                    reg.Days = registry.Days;
                    reg.Hours = registry.Hours;
                    reg.Minutes = registry.Minutes;
                    reg.TotalPayment = registry.TotalPayment;
                    reg.Payment = registry.Payment;
                    reg.Refund = registry.Refund;
                    reg.ModifiedBy = userID;
                    reg.Locker = registry.Locker;
                    reg.DayPayment = registry.DayPayment;
                    reg.ModifiedDate = DateTime.Now;
                   
                }

                context.SaveChanges();

                return reg;
            }
        }

        public MonthlyPaymentDto SaveMonthlyPayment(MonthlyPaymentDto monthlyPaymentDTO, int userID)
        {
            using (var context = new PLTOEntities())
            {
                var repo = new ConfigurationRepository();

                var user = context.Clients.FirstOrDefault(r => r.Plate == monthlyPaymentDTO.Plate);

                if (user == null)
                {
                    var rec = new Client()
                    {
                        Plate = monthlyPaymentDTO.Plate,
                        Document = monthlyPaymentDTO.Document,
                        DocTypeID = monthlyPaymentDTO.DocTypeId,
                        Name = monthlyPaymentDTO.Name,
                        CelPhone = monthlyPaymentDTO.Celphone,
                        IsActive = true
                    };
                    context.Clients.Add(rec);
                }
                else
                {
                    user.Document = monthlyPaymentDTO.Document;
                    user.Name = monthlyPaymentDTO.Name;
                    user.CelPhone = monthlyPaymentDTO.Celphone;
                    user.IsActive = true;
                }

                var mPayment = new MonthlyPayment()
                {
                    MonthlyPaymentID = repo.GetReceiptNumber(),
                    Plate = monthlyPaymentDTO.Plate,
                    TotalPayment = monthlyPaymentDTO.TotalPayment,
                    PaidValue = monthlyPaymentDTO.PaidValue,
                    Refund = monthlyPaymentDTO.Refund,
                    StartDate = monthlyPaymentDTO.StartDate,
                    ExpirationDate = monthlyPaymentDTO.ExpirationDate,
                    CreatedBy = userID,
                    IsWorkShiftClosed = monthlyPaymentDTO.IsWorkShiftClosed,
                    PaymentMethodID = monthlyPaymentDTO.PaymentMethodID,
                    PaymentDate = DateTime.Now
                };

                monthlyPaymentDTO.PaymentDescriptiion = context.PaymentMethods.FirstOrDefault(x => x.PaymentMethodID == mPayment.PaymentMethodID).Description;

                context.MonthlyPayments.Add(mPayment);
                context.SaveChanges();

                monthlyPaymentDTO.MonthlyPaymentID = mPayment.MonthlyPaymentID;


            }
            return monthlyPaymentDTO;
        }

        public Registry GetEntryRegistryByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {
                return context.Registries.OrderByDescending(x => x.EntryDate).FirstOrDefault(x => x.Plate == plate && x.DeletedDate == null);
            }
        }

        public RegistryDto GetExitRegistryByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {
                var sql = (from r in context.Registries
                           where r.Plate == plate && r.ExitDate != null  && r.DeletedDate == null
                           orderby r.ExitDate descending
                           select new RegistryDto()
                           {
                               RegistryID = r.RegistryID,
                               Plate = r.Plate,
                               EntryDate = r.EntryDate,
                               ExitDate = r.ExitDate,
                               Days = r.Days,
                               Hours = r.Hours,
                               Minutes = r.Minutes,
                               TotalPayment = r.TotalPayment,
                               Payment = r.Payment,
                               Refund = r.Refund,
                               DayPayment = (bool)r.DayPayment
                           }
                           ).FirstOrDefault();


                return sql;
            }
        }

        public MonthlyPaymentDto GetMonthlyPaymentByID(string monthlyPaymentID)
        {
            using (var context = new PLTOEntities())
            {
                var data = (from m in context.MonthlyPayments
                            join c in context.Clients on m.Plate equals c.Plate
                            where m.MonthlyPaymentID == monthlyPaymentID
                            orderby m.ExpirationDate descending
                            select new MonthlyPaymentDto
                            {
                                MonthlyPaymentID = m.MonthlyPaymentID,
                                Document = c.Document,
                                //MonthlyPaymentID = m.MonthlyPaymentID,
                                Plate = m.Plate,
                                PaidValue = m.PaidValue,
                                TotalPayment = m.TotalPayment,
                                Refund = m.Refund,
                                StartDate = m.StartDate,
                                ExpirationDate = m.ExpirationDate,
                                CreatedBy = (int)m.CreatedBy
                            }).FirstOrDefault();

                return data;
            }

        }

        public List<MonthlyPaymentDto> GetActiveMonthlyPayments(string search = null)
        {
            using (var context = new PLTOEntities())
            {
                var list = new List<MonthlyPaymentDto>();
                var data  =  context.usp_SelectLastMonthlyPayment(search).ToList();

                foreach (var row in data)
                {
                    list.Add(new MonthlyPaymentDto()
                    {
                        MonthlyPaymentID = row.MonthlyPaymentID,
                        Document = row.Document,
                        Name = row.Name,
                        Plate = row.Plate,
                        PaidValue = row.PaidValue,
                        TotalPayment = row.TotalPayment,
                        StartDate = row.StartDate,
                        ExpirationDate = row.ExpirationDate,
                        CellPhone = row.CelPhone,
                        PaymentDescriptiion = row.Description,
                        Status = (bool)row.IsActive
                    });
                }

                return list;
               

            }
        }

        public Registry GetRegistryByReciptNum(string receipt)
        {
            using (var context = new PLTOEntities())
            {
                return context.Registries.FirstOrDefault(x => x.RegistryID == receipt);
            }
        }

        public MonthlyPayment GetMonthlyPaymentByReciptNum(string receipt)
        {
            using (var context = new PLTOEntities())
            {
                return context.MonthlyPayments.FirstOrDefault(x => x.MonthlyPaymentID == receipt);
            }
        }

        public Registry GetLastRegistryReceiptByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {

                return context.Registries.Where(z => z.Plate == plate && z.DeletedDate == null).OrderByDescending(z => z.RegistryID).FirstOrDefault();

            }
        }

        public MonthlyPayment GetLasMonthlyPaymentReceiptByPlate(string plate)
        {
            using (var context = new PLTOEntities())
            {

                return context.MonthlyPayments.Where(z => z.Plate == plate && z.DeletedDate == null).OrderByDescending(x => x.MonthlyPaymentID).FirstOrDefault();

            }
        }

        public List<RegistryDto> GetLastRegistryMovements()
        {
            using (var context = new PLTOEntities())
            {
                var data = (from r in context.Registries
                            orderby r.ModifiedDate descending
                            select new RegistryDto()
                            {
                                RegistryID = r.RegistryID,
                                Plate = r.Plate,
                                EntryDate = r.EntryDate,
                                ExitDate = r.ExitDate,
                                Locker = (int)r.Locker,
                                TotalPayment = r.TotalPayment,
                                Payment = r.Payment,
                                Refund = r.Refund,
                                IsInsite  = r.IsInSite == true ? "En sitio" : "Salió"
                            }
                            ).Take(20).ToList();

                return data;
            }
        }

        public Registry GetDayPayment(string plate)
        {
            using (var context = new PLTOEntities())
            {

                var reg = context.Registries.FirstOrDefault(r => r.Plate == plate && r.ExitDate == null);

                if (reg == null)
                {
                    reg = context.Registries.OrderByDescending(r=> r.ModifiedDate).FirstOrDefault(r => r.Plate == plate && r.DayPayment == true
                            && DbFunctions.DiffMinutes(r.EntryDate, DateTime.Now).Value <= 720 && r.DeletedDate == null
                           // && r.ExitDate.Value.Day == DateTime.Now.Day
                            );
                }

                return reg;
            }
        }

        public Registry UpdateEntryExitDaypayment(string registryID, int userID)
        {                                                   
            using (var context = new PLTOEntities())
            {

                var reg = context.Registries.FirstOrDefault(r => r.RegistryID == registryID);

                if (reg.IsInSite == true)
                {
                    reg.IsInSite = false;
                    reg.ExitDate = DateTime.Now;
                    var time = DateTime.Now.Subtract(reg.EntryDate);
                    reg.Hours = time.Hours;
                    reg.Days = time.Days;
                    reg.Minutes = time.Minutes;
                }
                else
                {
                    reg.IsInSite = true;
                }
                reg.ModifiedDate = DateTime.Now;
                reg.ModifiedBy = userID;

                context.SaveChanges();

                return reg;
            }

        }

        private Registry InsertRegistry(Registry registry, int userID)
        {
            using (var context = new PLTOEntities())
            {
                var repo = new ConfigurationRepository();

                var reg = new Registry
                {
                    RegistryID = repo.GetReceiptNumber(),
                    Plate = registry.Plate,
                    EntryDate = registry.EntryDate,
                    CreatedBy = userID,
                    IsWorkShiftClosed = false,
                    Locker = registry.Locker,
                    DayPayment = false,
                    ModifiedDate = DateTime.Now,
                    IsInSite = true
                };
                context.Registries.Add(reg);

                context.SaveChanges();
                return reg;
            }
        }


        private Registry UpdateIsInSite(Registry registry, bool  isInSite)
        {
            using (var context = new PLTOEntities())
            {
                var reg = context.Registries.FirstOrDefault(r => r.RegistryID == registry.RegistryID);

                reg.IsInSite = isInSite;

                context.SaveChanges();

                return reg;
            }
        }


        public Registry DeletePaymentByPlate(string plate, int userID)
        {
            using (var context = new PLTOEntities())
            {
                var reg = context.Registries.FirstOrDefault(r => r.Plate == plate && r.ExitDate == null);

                if (reg != null)
                {
                    var date = DateTime.Now;

                    reg.DeletedBy = userID;
                    reg.DeletedDate = date;
                    reg.ExitDate = date;
                    reg.TotalPayment = 0;
                    reg.ModifiedBy = userID;
                    reg.ModifiedDate = date;

                    context.SaveChanges();

                }
                return reg;
            }
        }

    }
}
