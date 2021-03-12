using Dashboard.Service.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.ServiceTests.Service
{
    internal class BrancheServiceTest
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(new BrancheService().ListerBranches() == null);
        }
    }
}