using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    public abstract class Employe
    {
        protected int num;
        protected string nom;

        public Employe(int leNum, String leNom)
        {
            this.nom =leNom;
            this.num = leNum;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public abstract double calculRemuneration();
    }
}
