using Parking.Models;
using System;
using System.Linq;

namespace Parking.Repositories
{
    public class ReportRepository
    {


        public CloseWorkShiftDto CloseWorkShift(int userID)
        {
            using (var context = new PLTOEntities())
            {               
                var secureRepo = new SecurityRepository();             
                var appUser = secureRepo.GetAppUserByID(userID);

                var initalDate = DateTime.Now.AddHours(-9);

                var dataRegistry = (from r in context.Registries
                                    where r.ModifiedBy == userID && r.ExitDate != null && 
                                    r.ExitDate <= DateTime.Now && r.ExitDate >= initalDate
                                    select r).ToList();

                var dataMonthly = (from m in context.MonthlyPayments
                                   where m.CreatedBy == userID &&
                                   m.PaymentDate <= DateTime.Now && m.PaymentDate >= initalDate
                                   select m).ToList();

                var work = new CloseWorkShiftDto()
                {
                    UserID = appUser.UserID,
                    AppUserID = appUser.AppUserID,
                    Name = appUser.Name,
                    MonthlyPaymentCount = dataMonthly.Count(),
                    MonthlyPaymentValue = dataMonthly.Sum(x => x.TotalPayment),
                    DailyRegistryCount = dataRegistry.Count(),
                    DailyRegistryValue = (decimal)dataRegistry.Sum(x => x.TotalPayment)
                };

                return work;

            }
        }
    }
}
