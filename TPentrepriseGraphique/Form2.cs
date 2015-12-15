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
    public partial class Form2 : Form
    {
        
        public Form2(int n, String nom, Double sal)
        {            
            InitializeComponent() ;
            label2.Text = n.ToString()+"\n"+nom+"\n"+sal+"\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
