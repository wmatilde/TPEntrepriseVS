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
            dep = new SortedList<String, Departement>();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {      

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherSal();
        }
        private void btndep_Click(object sender, EventArgs e)
        {
            Departement d = new Departement(txtdep.Text);
            dep.Add(d.Nom, d);
            afficherliste();
            txtdep.Text = "";            
        }
        private void afficherliste()
        {
            listBox1.DataSource = dep.Values.ToArray();
            listBox1.DisplayMember = "Nom";
        }
        private void supprdep_Click(object sender, EventArgs e)
        {
            dep.RemoveAt(listBox1.SelectedIndex);
            // ou bien : " dep.Remove(((Departement)listBox1.SelectedValue).Nom); "
            afficherliste();
        }
        private void btnaddsal_Click(object sender, EventArgs e)
        {
            Salarie s = new Salarie(Convert.ToInt16(txtnums.Text), txtnoms.Text,Convert.ToDouble(txtsal.Text));
            ((Departement)listBox1.SelectedValue).addSalarie(s);
            afficherSal();
            txtnums.Text = "";
            txtnoms.Text = "";
            txtsal.Text = "";
        }
        private void afficherSal()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = ((Departement)listBox1.SelectedItem).afficheListe();
            listBox2.DisplayMember ="Nom";
        }
        private void btnsupprsal_Click(object sender, EventArgs e)
        {
            Salarie s = (Salarie)listBox2.SelectedValue;
            Departement d = (Departement)listBox1.SelectedValue;
            d.supprimSalarie(s);
            afficherSal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((Salarie)listBox2.SelectedValue).Num, ((Salarie)listBox2.SelectedValue).Nom, ((Salarie)listBox2.SelectedValue).calculRemuneration());            
            f.Show();
        }
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
