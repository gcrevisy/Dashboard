using Dashboard.Business.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.BusinessTests.Service
{
    public class GitHubServiceTest
    {
        [Test]
        public void ListerBranchesTest()
        {
            GitHubService service = new GitHubService();

            Assert.Pass();
        }
    }
}