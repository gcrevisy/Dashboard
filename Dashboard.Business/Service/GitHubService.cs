using Dashboard.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Service
{
    public class GitHubService
    {
        public IList<Branche> ListerBranches()
        {
            IList<Branche> result = new List<Branche>();

            result.Add(
                new Branche()
                {
                    Nom = "feature/Toto",
                    DateCreation = DateTime.Now,
                    Createur = new Utilisateur() { Login = "gcrevisy" },
                    DernierModificateur = new Utilisateur() { Login = "gcrevisy" }
                });

            result.Add(
              new Branche()
              {
                  Nom = "feature/Titi",
                  DateCreation = DateTime.Now,
                  Createur = new Utilisateur() { Login = "gcrevisy" },
                  DernierModificateur = new Utilisateur() { Login = "gcrevisy" }
              });

            result.Add(
               new Branche()
               {
                   Nom = "feature/Tata",
                   DateCreation = DateTime.Now,
                   Createur = new Utilisateur() { Login = "gcrevisy" },
                   DernierModificateur = new Utilisateur() { Login = "gcrevisy" }
               });

            return result;
        }
    }
}