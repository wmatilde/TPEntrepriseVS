using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPentrepriseGraphique
{
    public partial class Form1 : Form
    {        
        SortedList<String, Departement> dep; 
        public Form1()
        {
            InitializeComponent();
            dep = new SortedList<String, Departement>(); // On instancie une liste de département qui seront affichés dans l'ordre
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {      

        }
        // AFFICHAGE des SALARIE en fonction du département choisi
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherSal();
        }
        // CREATION d'un DEPARTEMENT puis on l'affiche sur le listeBox grâce à la méthode afficherliste()
        private void btndep_Click(object sender, EventArgs e)
        {
            Departement d = new Departement(txtdep.Text);
            dep.Add(d.Nom, d);
            afficherliste();
            txtdep.Text = "";            
        }
        // Méthode permettant d'afficher les départements sur le listBox
        private void afficherliste()
        {
            listBox1.DataSource = dep.Values.ToArray();
            listBox1.DisplayMember = "Nom";
        }
        // SUPPRESSION du DEPARTEMENT
        private void supprdep_Click(object sender, EventArgs e)
        {
            dep.RemoveAt(listBox1.SelectedIndex);  // ou bien : " dep.Remove(((Departement)listBox1.SelectedValue).Nom); "
            afficherliste();
        }
        // Lorsque l'on clique sur le bouton AJOUTER
        private void btnaddsal_Click(object sender, EventArgs e)
        {
            // AJOUT SALARIE
            Salarie s = new Salarie( Convert.ToInt16 ( txtnums.Text ), txtnoms.Text,Convert.ToDouble ( txtsal.Text ) );
            ((Departement)listBox1.SelectedValue).addSalarie(s);           
            afficherSal();
            txtnums.Text = "";
            txtnoms.Text = "";
            txtsal.Text = "";
            // AJOUT TEMPORAIRE
            Employe emp = new Temporaire( Convert.ToInt16 ( txtnump.Text ), txtnomp.Text, Convert.ToDouble( txttaux.Text ), Convert.ToInt16( txtnbh.Text ) );
            txtnump.Text = "";
            txtnomp.Text = "";
            txttaux.Text = "";
            txtnbh.Text = "";
        }
        // Affichage du salarié en fonction du Département choisi
        private void afficherSal()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = ((Departement)listBox1.SelectedItem).afficheListe();
            listBox2.DisplayMember ="Nom";
        }
        // SUPPRESSION du SALARIE selectioné du département concerné
        private void btnsupprsal_Click(object sender, EventArgs e)
        {
            Salarie s = (Salarie)listBox2.SelectedValue;
            Departement d = (Departement)listBox1.SelectedValue;
            d.supprimSalarie(s);
            afficherSal();
        }
        // OUVERTURE de la deuxième FORM
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((Salarie)listBox2.SelectedValue).Num, ((Salarie)listBox2.SelectedValue).Nom, ((Salarie)listBox2.SelectedValue).calculRemuneration());            
            f.Show();
        }
        // SELECTION DU RADIOBOUTON SALARIE
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gBsal.Visible = true;
                gBtemp.Visible = false;
            }
            else
            {
                gBsal.Visible = false;
            }
        }
        // // SELECTION DU RADIOBOUTON TEMPORAIRE
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                gBtemp.Visible = true;
                gBsal.Visible = false;
            }
            else
            {
                gBtemp.Visible = false;
            }
        }
    }
}
