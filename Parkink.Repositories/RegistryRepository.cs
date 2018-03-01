﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Models;

namespace Parking.Repositories
{
    public class RegistryRepository
    {
        public Registry CheckEntryExit(Registry registry)
        {
            using (var context = new PLTOEntities())
            {
                var reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.ExitDate == null);

                if (reg == null)
                {
                    reg = new Registry
                    {
                        Plate = registry.Plate,
                        EntryDate = registry.EntryDate,
                    };
                    context.Registries.Add(reg);

                    context.SaveChanges();
                    registry.RegistryID = reg.RegistryID;
                }
                else
                {
                    reg.ExitDate = DateTime.Now;
                    var dif = DateTime.Now.Subtract(reg.EntryDate);
                    reg.Days = dif.Days;
                    reg.Hours = dif.Hours;
                    reg.Minutes = dif.Minutes;
                    var hours = dif.Hours * 60;
                    reg.TotalPayment = 0;

                    if (dif.Days > 0)
                    {
                        var daysValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 3);
                        reg.TotalPayment = reg.Days * daysValues.Value;
                    }

                    if (dif.Hours > 0)
                    {
                        if (dif.Hours > 3 /*TODO: Change as DB parameter */)
                        {
                            var daysValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 3);
                            reg.TotalPayment = reg.TotalPayment + daysValues.Value;
                        }
                        else
                        {
                            var hoursValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 2);
                            reg.TotalPayment = reg.TotalPayment + (reg.Hours * hoursValues.Value);
                        }
                    }

                    var minutesValues = context.PaymentMethods.FirstOrDefault(v => v.PaymentMethodID == 1);
                    if (dif.Minutes > 0 && dif.Minutes < 30) reg.TotalPayment = reg.TotalPayment + minutesValues.Value;
                    else if (dif.Minutes >= 30 && dif.Minutes < 60) reg.TotalPayment = reg.TotalPayment + (minutesValues.Value * 2);                      
                }
                return reg;
            }      
        }

        public Registry CheckExit(Registry registry)
        {
            using (var context = new PLTOEntities())
            {
                var reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.ExitDate == null);

                reg.ExitDate = registry.ExitDate;
                reg.TotalPayment = registry.TotalPayment;
                reg.Payment = registry.Payment;
                reg.Refund = registry.Refund;
                reg.Days = registry.Days;
                reg.Hours = registry.Hours;
                reg.Minutes = registry.Minutes;

                context.SaveChanges();

                return reg;
            }
        }

        public MonthlyPaymentDto SaveMonthlyPayment(MonthlyPaymentDto monthlyPaymentDTO)
        {
            using (var context = new PLTOEntities())
            {
                var user = context.Users.FirstOrDefault(r => r.DocTypeID == monthlyPaymentDTO.DocTypeId && r.Document == monthlyPaymentDTO.Document);

                if (user == null)
                {
                    var rec = new User()
                    {
                        Document = monthlyPaymentDTO.Document,
                        DocTypeID = monthlyPaymentDTO.DocTypeId,
                        Name = monthlyPaymentDTO.Name,
                        CelPhone = monthlyPaymentDTO.Celphone
                    };
                    context.Users.Add(rec);
                }
                else {
                    user.Name = monthlyPaymentDTO.Name;
                    user.CelPhone = monthlyPaymentDTO.Celphone;
                }

                var mPayment = new MonthlyPayment()
                {
                    Document = monthlyPaymentDTO.Document,
                    DocTypeID = monthlyPaymentDTO.DocTypeId,
                    Plate = monthlyPaymentDTO.Plate,
                    PaidValue = monthlyPaymentDTO.PaidValue,
                    TotalPayment = monthlyPaymentDTO.TotalPayment,
                    Refund = monthlyPaymentDTO.Refund,
                    PaymentDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddMonths(1)
                };

                context.MonthlyPayments.Add(mPayment);

                context.SaveChanges();

                monthlyPaymentDTO.MonthlyPaymentId = mPayment.MonthlyPaymentID;

            }
            return monthlyPaymentDTO;
        }
    }
}
