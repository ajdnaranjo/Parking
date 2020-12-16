using Parking.Models;
using System;
using System.Linq;
using System.Collections.Generic;

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

                var dataDailyRegistry = (from r in context.Registries
                                    where r.ModifiedBy == userID && r.ExitDate != null &&
                                    r.IsWorkShiftClosed == false  && r.DeletedDate == null
                                    select r).ToList();

                var dataMonthly = (from m in context.MonthlyPayments
                                   where m.CreatedBy == userID && m.IsWorkShiftClosed == false && m.DeletedDate == null
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
                    MonthlyPaymentValue = dataMonthly.Sum(x => x.TotalPayment),
                    DailyRegistryCount = dataDailyRegistry.Count(),
                    DailyRegistryValue = (decimal)dataDailyRegistry.Sum(x => x.TotalPayment)
                };

                return work;

            }
        }

        public List<usp_SelectCloseWorkSfhitDates_Result> GetCloseWorkShiftDates(int userId)
        {
            using (var context = new PLTOEntities())
            {

                 return  context.usp_SelectCloseWorkSfhitDates(userId).ToList();
            }
        }

        public CloseWorkShiftDto GetCloseWorkShiftByUserDate(int userId, DateTime date)
        {
            using (var context = new PLTOEntities())
            {
                var secureRepo = new SecurityRepository();
                var appUser = secureRepo.GetAppUserByID(userId);

                var dataDailyRegistry = (from r in context.Registries
                                         where r.ModifiedBy == userId && r.IsWorkShiftClosed == true &&
                                         r.WorkShiftCloseDate.Value.Year == date.Year &&
                                         r.WorkShiftCloseDate.Value.Month == date.Month &&
                                         r.WorkShiftCloseDate.Value.Day == date.Day &&
                                         r.WorkShiftCloseDate.Value.Hour == date.Hour &&
                                         r.WorkShiftCloseDate.Value.Minute == date.Minute
                                         && r.DeletedDate == null
                                         select r).ToList();

                var dataMonthly = (from m in context.MonthlyPayments
                                   where m.CreatedBy == userId && m.IsWorkShiftClosed == true &&
                                   m.WorkShiftCloseDate.Value.Year == date.Year &&
                                   m.WorkShiftCloseDate.Value.Month == date.Month &&
                                   m.WorkShiftCloseDate.Value.Day == date.Day &&
                                   m.WorkShiftCloseDate.Value.Hour == date.Hour &&
                                   m.WorkShiftCloseDate.Value.Minute == date.Minute &&
                                   m.DeletedDate == null
                                   select m).ToList();         

                var work = new CloseWorkShiftDto()
                {
                    UserID = appUser.UserID,
                    AppUserID = appUser.AppUserID,
                    Name = appUser.Name,
                    MonthlyPaymentCount = dataMonthly.Count(),
                    MonthlyPaymentValue = dataMonthly.Sum(x => x.TotalPayment),
                    DailyRegistryCount = dataDailyRegistry.Count(),
                    DailyRegistryValue = (decimal)dataDailyRegistry.Sum(x => x.TotalPayment),
                    CloseWorkShitDate = date
                };

                return work;

            }
        }

        public List<Registry> GetPendingToExit()
        {

            using (var context = new PLTOEntities())
            {

                return context.Registries.Where(x => (x.IsInSite == true || x.ExitDate == null) && x.DeletedDate == null ).ToList();
            }
        }
    }
}
