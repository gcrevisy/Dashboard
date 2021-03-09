using Dashboard.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.UI.Service
{
    public class GithubService
    {
        public GithubService()
        {
        }

        public IList<Branche> GetBranches()
        {
            IList<Branche> result = new List<Branche>();
            result.Add(new Branche { Nom = "TOTO" });
            return result;
        }
    }
}