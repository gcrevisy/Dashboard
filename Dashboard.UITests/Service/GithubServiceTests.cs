using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dashboard.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.UI.Service.Tests
{
    [TestClass()]
    public class GithubServiceTests
    {
        [TestMethod()]
        public void GetBranchesTest()
        {
            GithubService service = new GithubService();
            Assert.IsNotNull(service.GetBranches());
        }
    }
}