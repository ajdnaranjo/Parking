using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parking.Utilities;

namespace Parking.Repositories.Test
{
    [TestClass]
    public  class ReportRepositoryTest
    {

        [TestMethod]
        public void TestPedingToexit()
        {
            var repo = new Receipts();
            var result = repo.PendingToExitReceipt();
        }
    }
}
