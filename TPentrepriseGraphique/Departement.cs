using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    public class Departement
    {
        private String nom;
        private int id;
        private List<Salarie> collectionSalarie;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Departement(string n, int num) 
        {
            this.nom = n;
            this.id = num;
            collectionSalarie = new List<Salarie>();
        }
        public Departement(string n)
        {
            this.nom = n;
            collectionSalarie = new List<Salarie>();
        }
        public void addSalarie(Salarie s)
        {
            collectionSalarie.Add(s);
        }
        public void supprimSalarie(Salarie s)
        {
            collectionSalarie.Remove(s);
        }
        public void supprimSalarie(int index)
        {
            collectionSalarie.RemoveAt(index);
        }
        public List<Salarie> afficheListe()
        {
            return (collectionSalarie);
        }      

    }
}
