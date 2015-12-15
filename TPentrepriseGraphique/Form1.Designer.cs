namespace TPentrepriseGraphique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnaddsal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsupprsal = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.supprdep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gBsal = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtnums = new System.Windows.Forms.TextBox();
            this.txtnoms = new System.Windows.Forms.TextBox();
            this.gBtemp = new System.Windows.Forms.GroupBox();
            this.txtnbh = new System.Windows.Forms.TextBox();
            this.txttaux = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnump = new System.Windows.Forms.TextBox();
            this.txtnomp = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gBsal.SuspendLayout();
            this.gBtemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 24);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(11, 150);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 95);
            this.listBox2.TabIndex = 1;
            // 
            // btnaddsal
            // 
            this.btnaddsal.Location = new System.Drawing.Point(145, 249);
            this.btnaddsal.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddsal.Name = "btnaddsal";
            this.btnaddsal.Size = new System.Drawing.Size(57, 25);
            this.btnaddsal.TabIndex = 2;
            this.btnaddsal.Text = "Ajouter";
            this.btnaddsal.UseVisualStyleBackColor = true;
            this.btnaddsal.Click += new System.EventHandler(this.btnaddsal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des Départements :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des employés :";
            // 
            // btnsupprsal
            // 
            this.btnsupprsal.Location = new System.Drawing.Point(70, 249);
            this.btnsupprsal.Margin = new System.Windows.Forms.Padding(2);
            this.btnsupprsal.Name = "btnsupprsal";
            this.btnsupprsal.Size = new System.Drawing.Size(69, 25);
            this.btnsupprsal.TabIndex = 5;
            this.btnsupprsal.Text = "Supprimer";
            this.btnsupprsal.UseVisualStyleBackColor = true;
            this.btnsupprsal.Click += new System.EventHandler(this.btnsupprsal_Click);
            // 
            // btndep
            // 
            this.btndep.Location = new System.Drawing.Point(207, 61);
            this.btndep.Margin = new System.Windows.Forms.Padding(2);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(129, 30);
            this.btndep.TabIndex = 6;
            this.btndep.Text = "Ajouter un département";
            this.btndep.UseVisualStyleBackColor = true;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(237, 37);
            this.txtdep.Margin = new System.Windows.Forms.Padding(2);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(97, 20);
            this.txtdep.TabIndex = 7;
            // 
            // supprdep
            // 
            this.supprdep.Location = new System.Drawing.Point(206, 95);
            this.supprdep.Margin = new System.Windows.Forms.Padding(2);
            this.supprdep.Name = "supprdep";
            this.supprdep.Size = new System.Drawing.Size(128, 22);
            this.supprdep.TabIndex = 14;
            this.supprdep.Text = "Supprimer département";
            this.supprdep.UseVisualStyleBackColor = true;
            this.supprdep.Click += new System.EventHandler(this.supprdep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Infos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBsal
            // 
            this.gBsal.Controls.Add(this.label7);
            this.gBsal.Controls.Add(this.label8);
            this.gBsal.Controls.Add(this.label9);
            this.gBsal.Controls.Add(this.txtsal);
            this.gBsal.Controls.Add(this.txtnums);
            this.gBsal.Controls.Add(this.txtnoms);
            this.gBsal.Location = new System.Drawing.Point(206, 170);
            this.gBsal.Margin = new System.Windows.Forms.Padding(2);
            this.gBsal.Name = "gBsal";
            this.gBsal.Padding = new System.Windows.Forms.Padding(2);
            this.gBsal.Size = new System.Drawing.Size(133, 101);
            this.gBsal.TabIndex = 18;
            this.gBsal.TabStop = false;
            this.gBsal.Text = "Ajout d\'un salarié";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Salaire :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Num :";
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(79, 63);
            this.txtsal.Margin = new System.Windows.Forms.Padding(2);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(48, 20);
            this.txtsal.TabIndex = 16;
            // 
            // txtnums
            // 
            this.txtnums.Location = new System.Drawing.Point(43, 20);
            this.txtnums.Margin = new System.Windows.Forms.Padding(2);
            this.txtnums.Name = "txtnums";
            this.txtnums.Size = new System.Drawing.Size(84, 20);
            this.txtnums.TabIndex = 15;
            // 
            // txtnoms
            // 
            this.txtnoms.Location = new System.Drawing.Point(43, 41);
            this.txtnoms.Margin = new System.Windows.Forms.Padding(2);
            this.txtnoms.Name = "txtnoms";
            this.txtnoms.Size = new System.Drawing.Size(84, 20);
            this.txtnoms.TabIndex = 14;
            // 
            // gBtemp
            // 
            this.gBtemp.Controls.Add(this.txtnbh);
            this.gBtemp.Controls.Add(this.txttaux);
            this.gBtemp.Controls.Add(this.label10);
            this.gBtemp.Controls.Add(this.label5);
            this.gBtemp.Controls.Add(this.label3);
            this.gBtemp.Controls.Add(this.label4);
            this.gBtemp.Controls.Add(this.txtnump);
            this.gBtemp.Controls.Add(this.txtnomp);
            this.gBtemp.Location = new System.Drawing.Point(204, 170);
            this.gBtemp.Margin = new System.Windows.Forms.Padding(2);
            this.gBtemp.Name = "gBtemp";
            this.gBtemp.Padding = new System.Windows.Forms.Padding(2);
            this.gBtemp.Size = new System.Drawing.Size(135, 114);
            this.gBtemp.TabIndex = 20;
            this.gBtemp.TabStop = false;
            this.gBtemp.Text = "Ajout d\'un temporaire";
            this.gBtemp.Visible = false;
            // 
            // txtnbh
            // 
            this.txtnbh.Location = new System.Drawing.Point(69, 84);
            this.txtnbh.Margin = new System.Windows.Forms.Padding(2);
            this.txtnbh.Name = "txtnbh";
            this.txtnbh.Size = new System.Drawing.Size(58, 20);
            this.txtnbh.TabIndex = 26;
            // 
            // txttaux
            // 
            this.txttaux.Location = new System.Drawing.Point(43, 63);
            this.txttaux.Margin = new System.Windows.Forms.Padding(2);
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(84, 20);
            this.txttaux.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "NbHeures :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Taux :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Num :";
            // 
            // txtnump
            // 
            this.txtnump.Location = new System.Drawing.Point(43, 20);
            this.txtnump.Margin = new System.Windows.Forms.Padding(2);
            this.txtnump.Name = "txtnump";
            this.txtnump.Size = new System.Drawing.Size(84, 20);
            this.txtnump.TabIndex = 20;
            // 
            // txtnomp
            // 
            this.txtnomp.Location = new System.Drawing.Point(43, 41);
            this.txtnomp.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomp.Name = "txtnomp";
            this.txtnomp.Size = new System.Drawing.Size(84, 20);
            this.txtnomp.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(206, 148);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Salarié";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(262, 148);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Temporaire";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Employé à ajouter :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Département à ajouter :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 285);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.gBtemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supprdep);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.btndep);
            this.Controls.Add(this.btnsupprsal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddsal);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gBsal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TP Entreprise by William";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gBsal.ResumeLayout(false);
            this.gBsal.PerformLayout();
            this.gBtemp.ResumeLayout(false);
            this.gBtemp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnaddsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsupprsal;
        private System.Windows.Forms.Button btndep;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.Button supprdep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gBsal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtnums;
        private System.Windows.Forms.TextBox txtnoms;
        private System.Windows.Forms.GroupBox gBtemp;
        private System.Windows.Forms.TextBox txtnbh;
        private System.Windows.Forms.TextBox txttaux;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnump;
        private System.Windows.Forms.TextBox txtnomp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

