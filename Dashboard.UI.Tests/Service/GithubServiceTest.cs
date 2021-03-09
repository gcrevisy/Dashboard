using Dashboard.UI.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.UI.Tests.Service
{
    public class GithubServiceTest
    {
        [Test]
        public void GetBranchesTest()
        {
            GithubService service = new GithubService();
            Assert.IsNotNull(service.GetBranches());
        }
    }
}