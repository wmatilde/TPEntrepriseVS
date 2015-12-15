using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    [Serializable]
    public abstract class Employe
    {
        // ATTRIBUTS
        protected int num;
        protected string nom;
        // CONSTRUCTEUR
        public Employe(int leNum, String leNom)
        {
            this.nom =leNom;
            this.num = leNum;
        }
        // PROPERTY du NOM de l'employé
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        // PROPERTY du NUM de l'employé
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public abstract double calculRemuneration();
    }
}
