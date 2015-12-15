using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    [Serializable]
    class Temporaire:Employe
    {
        // ATTRIBUTS
        private double tauxHoraires;
        private int nbHeures;
        // CONSTRUCTEURS
        public Temporaire(int leNum, String leNom, double tH, int nB) : base(leNum, leNom)
        {
            this.tauxHoraires = tH;
            this.nbHeures = nB;
        }
        // Méthode pour calculer le salaire du temporaire
        public override double calculRemuneration()
        {
            return (double)(tauxHoraires*nbHeures);
        }
    }
}
