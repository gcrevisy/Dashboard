using Dashboard.Business.Service;
using Dashboard.Core.Model;
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
            IList<Branche> liste = service.ListerBranches();

            Assert.IsNotNull(liste);
        }

        [Test]
        public void CompterBrancheTest()
        {
            GitHubService service = new GitHubService();
            IList<Branche> liste = service.ListerBranches();

            Assert.AreEqual(3, liste.Count);
        }

        [Test]
        public void TrouverBrancheTest()
        {
            GitHubService service = new GitHubService();
            IList<Branche> liste = service.ListerBranches();

            Assert.IsNotNull(liste.Where(item => item.Nom.Equals("feature/Toto")).FirstOrDefault());
        }
    }
}