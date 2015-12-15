using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    [Serializable]
    public class Salarie:Employe
    {
        // ATTRIBUTS
        private double salaire;
        // CONSTRUCTEUR
        public Salarie(int leNum, String leNom, double s) : base(leNum, leNom)
        {            
            this.salaire = s;
        }
        // Méthode pour calculer le salaire du salarie
        public override double calculRemuneration()
        {
            return(salaire * 0.8);
        }
    }
}
