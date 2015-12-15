using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    class Temporaire:Employe
    {
        private double tauxHoraires;
        private int nbHeures;

        public Temporaire(int leNum, String leNom, double tH, int nB) : base(leNum, leNom)
        {
            this.tauxHoraires = tH;
            this.nbHeures = nB;
        }
        public override double calculRemuneration()
        {
            return (double)(tauxHoraires*nbHeures);
        }
    }
}
