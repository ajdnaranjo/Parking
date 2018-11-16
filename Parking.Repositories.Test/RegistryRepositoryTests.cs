using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parking.Repositories.Test
{
    [TestClass]
    public class RegistryRepositoryTests
    {
        [TestMethod]
        public void TestCheckEntryExit()
        {

            var reg = new Registry()
            {
                Plate = "LQE45B",
                EntryDate = DateTime.Now,
                IsWorkShiftClosed = false,
                Locker = 0,
                DayPayment = true
            };

            var repo = new RegistryRepository();
            var result = repo.CheckEntryExit(reg, 1);
        }
    }
}
