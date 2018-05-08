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

                var dataDailyRegistry = (from r in context.Registries
                                    where r.ModifiedBy == userID && r.ExitDate != null &&
                                    r.IsWorkShiftClosed == false
                                    select r).ToList();

                var dataMonthly = (from m in context.MonthlyPayments
                                   where m.CreatedBy == userID && m.IsWorkShiftClosed == false
                                   select m).ToList();

                foreach (var item in dataDailyRegistry)
                {
                    item.IsWorkShiftClosed = true;
                    item.WorkShiftCloseDate = DateTime.Now;
                }
                foreach (var item in dataMonthly)
                {
                    item.IsWorkShiftClosed = true;
                    item.WorkShiftCloseDate = DateTime.Now;
                }

                context.SaveChanges();

                var work = new CloseWorkShiftDto()
                {
                    UserID = appUser.UserID,
                    AppUserID = appUser.AppUserID,
                    Name = appUser.Name,
                    MonthlyPaymentCount = dataMonthly.Count(),
                    MonthlyPaymentValue = dataMonthly.Sum(x => x.PaidValue),
                    DailyRegistryCount = dataDailyRegistry.Count(),
                    DailyRegistryValue = (decimal)dataDailyRegistry.Sum(x => x.TotalPayment)
                };

                return work;

            }
        }
    }
}
