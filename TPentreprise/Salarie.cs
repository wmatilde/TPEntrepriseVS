using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentreprise
{
    class Salarie
    {
        private int num;
        private String nom;
        private float salaire;

        public Salarie (int id, String n, float s)
        {
            this.nom = n;
            this.num = id;
            this.salaire = s;
        }

        public String getSalarie()
        {
            String res = "";
            res=this.nom;
            return (res);
        }

        public double calculRemuneration()
        {
            double res = salaire* 0.8;
            return (res);
        }
    }
}
