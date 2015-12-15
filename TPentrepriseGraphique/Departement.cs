using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentrepriseGraphique
{
    [Serializable]
    public class Departement
    {
        // Attributs
        private String nom;
        private int id;
        private List<Employe> collectionEmploye;

        // PROPERTY du Nom du département
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        // Constructeur avec deux paramètres
        public Departement(string n, int num) 
        {
            this.nom = n;
            this.id = num;
            collectionEmploye = new List<Employe>();
        }
        // Constructeur avec un seul paramètre
        public Departement(string n)
        {
            this.nom = n;
            collectionEmploye = new List<Employe>();
        }
        // Méthode permetant d'ajouter un Employe dans la collection
        public void addEmploye(Employe emp)
        {
            collectionEmploye.Add(emp);
        }
        // Méthode permetant de supprimer un Employe de la collection
        public void supprimEmploye(Employe emp)
        {
            collectionEmploye.Remove(emp);
        }
        // Méthode permetant de supprimer un Employe de la collection        
        public void supprimEmploye(int index)
        {
            collectionEmploye.RemoveAt(index);
        }
        // Méthode qui retourne la collection des Employe
        public List<Employe> afficheListe()
        {
            return (collectionEmploye);
        }      

    }
}
