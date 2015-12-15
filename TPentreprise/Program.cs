using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPentreprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Departement d1 = new Departement("Service Marketing",01);
            Departement d2 = new Departement("Service Informatique", 02);
            Departement d3 = new Departement("Ressources Humaines", 03);

            Salarie s1 = new Salarie(00, "William Matilde",2000);
            d1.addSalarie(s1);
            Salarie s2 = new Salarie(01, "Ghaïtan Briffard", 2000);
            d2.addSalarie(s2);
            Salarie s3 = new Salarie(02, "Mehmet Aksoy", 2000);
            d3.addSalarie(s3);
            Salarie s4 = new Salarie(03, "Idriss Moualek", 10000);
            d2.addSalarie(s4);

            List<Salarie> res=d2.afficheListe();
            for(int i=0;res.Count>i;i++)
            {
                Console.WriteLine("Nom :" +res.ElementAt(i).getSalarie());
                Console.WriteLine("Salaire :" +res.ElementAt(i).calculRemuneration());
            }

            Console.ReadKey();
        }
    }
}
