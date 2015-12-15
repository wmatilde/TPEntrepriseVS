using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace TPentrepriseGraphique
{
    
    public partial class Form1 : Form
    {        
        SortedList<String, Departement> dep = new SortedList<String, Departement>(); // On instancie une liste de départements qui seront affichés dans l'ordre        
        public Form1()
        {
            InitializeComponent();            
            chargement(); // Au démarrage de l'application, on RECUPERE ce qu'on a sauvegarder avant
            afficherliste();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherEmp();
        }  
        // CREATION d'un DEPARTEMENT puis on l'affiche sur le listeBox grâce à la méthode afficherliste()
        private void btndep_Click(object sender, EventArgs e)
        {
            Departement d = new Departement(txtdep.Text);
            dep.Add(d.Nom, d);
            afficherliste();
            txtdep.Text = "";            
        }
        // Méthode permettant de mettre à jour les départements sur la listBox
        private void afficherliste()
        {
            listBox1.DataSource = dep.Values.ToArray();
            listBox1.DisplayMember = "Nom";
            // Si il n'y a plus de départements, on désactive le bouton supprimer
            if ((Departement)listBox1.SelectedValue==null)
            {
                supprdep.Enabled = false;
            }
            else // Sinon il reste activé
            {
                supprdep.Enabled = true;
            }            
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
            if (radioButton1.Checked == true) // Si je veux AJOUTER un SALARIE
            {
                Employe s = new Salarie(Convert.ToInt16(txtnums.Text), txtnoms.Text, Convert.ToDouble(txtsal.Text));
                ((Departement)listBox1.SelectedValue).addEmploye(s);
                afficherEmp();
                txtnums.Text = "";
                txtnoms.Text = "";
                txtsal.Text = "";
            }
            else if (radioButton2.Checked == true) // Si je veux AJOUTER un TEMPORAIRE
            {
                Employe emp = new Temporaire(Convert.ToInt16(txtnump.Text), txtnomp.Text, Convert.ToDouble(txttaux.Text), Convert.ToInt16(txtnbh.Text));
                ((Departement)listBox1.SelectedValue).addEmploye(emp);
                afficherEmp();
                txtnump.Text = "";
                txtnomp.Text = "";
                txttaux.Text = "";
                txtnbh.Text = "";
            }                    
        }
        // Affichage du salarié en fonction du Département choisi
        private void afficherEmp()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = ((Departement)listBox1.SelectedItem).afficheListe();
            listBox2.DisplayMember ="Nom";
        }
        // SUPPRESSION de l'EMPLOYE selectioné du département concerné
        private void btnsupprsal_Click(object sender, EventArgs e)
        {
            Employe semp = (Employe)listBox2.SelectedValue;
            Departement d = (Departement)listBox1.SelectedValue;
            d.supprimEmploye(semp);
            afficherEmp();
        }
        // OUVERTURE de la deuxième FORM
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((Employe)listBox2.SelectedValue).Num, ((Employe)listBox2.SelectedValue).Nom, ((Employe)listBox2.SelectedValue).calculRemuneration());            
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
        // Partie Sérializable :
        //
        // SAUVEGARDE de la SortedList dep dans le fichier data
        private void sauvegarde()
        {
            FileStream stream = new FileStream("data", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, dep);
            stream.Close();
        }
        // CHARGEMENT de la SortedList dep
        private void chargement()
        {
            if (File.Exists("data"))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                FileStream stream = new FileStream("data", FileMode.Open);
                dep = (SortedList< String,Departement>)deserializer.Deserialize(stream);
                stream.Close();
            }
        }
        // A la fermeture de l'application on SAUVEGARDE 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sauvegarde();
        }
    }
}
