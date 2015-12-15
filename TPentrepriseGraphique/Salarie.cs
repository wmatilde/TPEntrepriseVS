using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    public class Salarie:Employe
    {
        private double salaire;
        public Salarie(int leNum, String leNom, double s) : base(leNum, leNom)
        {            
            this.salaire = s;
        }
        public override double calculRemuneration()
        {
            return(salaire * 0.8);
        }
    }
}
