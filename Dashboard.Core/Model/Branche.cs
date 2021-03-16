using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Core.Model
{
    public class Branche
    {
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        public Utilisateur Createur { get; set; }
        public Utilisateur DernierModificateur { get; set; }
    }
}