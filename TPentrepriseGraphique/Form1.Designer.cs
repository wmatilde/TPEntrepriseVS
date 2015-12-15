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
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 116);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(15, 168);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 116);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnaddsal
            // 
            this.btnaddsal.Location = new System.Drawing.Point(193, 290);
            this.btnaddsal.Name = "btnaddsal";
            this.btnaddsal.Size = new System.Drawing.Size(76, 53);
            this.btnaddsal.TabIndex = 2;
            this.btnaddsal.Text = "Ajouter";
            this.btnaddsal.UseVisualStyleBackColor = true;
            this.btnaddsal.Click += new System.EventHandler(this.btnaddsal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lise des Départements :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des salariés :";
            // 
            // btnsupprsal
            // 
            this.btnsupprsal.Location = new System.Drawing.Point(95, 290);
            this.btnsupprsal.Name = "btnsupprsal";
            this.btnsupprsal.Size = new System.Drawing.Size(92, 53);
            this.btnsupprsal.TabIndex = 5;
            this.btnsupprsal.Text = "Supprimer";
            this.btnsupprsal.UseVisualStyleBackColor = true;
            this.btnsupprsal.Click += new System.EventHandler(this.btnsupprsal_Click);
            // 
            // btndep
            // 
            this.btndep.Location = new System.Drawing.Point(275, 57);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(172, 42);
            this.btndep.TabIndex = 6;
            this.btndep.Text = "Ajouter un département";
            this.btndep.UseVisualStyleBackColor = true;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(318, 29);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(128, 22);
            this.txtdep.TabIndex = 7;
            // 
            // supprdep
            // 
            this.supprdep.Location = new System.Drawing.Point(275, 105);
            this.supprdep.Name = "supprdep";
            this.supprdep.Size = new System.Drawing.Size(171, 40);
            this.supprdep.TabIndex = 14;
            this.supprdep.Text = "Supprimer département";
            this.supprdep.UseVisualStyleBackColor = true;
            this.supprdep.Click += new System.EventHandler(this.supprdep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 53);
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
            this.gBsal.Location = new System.Drawing.Point(275, 209);
            this.gBsal.Name = "gBsal";
            this.gBsal.Size = new System.Drawing.Size(177, 124);
            this.gBsal.TabIndex = 18;
            this.gBsal.TabStop = false;
            this.gBsal.Text = "Ajout d\'un salarié";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Salaire :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Num :";
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(105, 78);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(63, 22);
            this.txtsal.TabIndex = 16;
            // 
            // txtnums
            // 
            this.txtnums.Location = new System.Drawing.Point(57, 24);
            this.txtnums.Name = "txtnums";
            this.txtnums.Size = new System.Drawing.Size(111, 22);
            this.txtnums.TabIndex = 15;
            // 
            // txtnoms
            // 
            this.txtnoms.Location = new System.Drawing.Point(57, 50);
            this.txtnoms.Name = "txtnoms";
            this.txtnoms.Size = new System.Drawing.Size(111, 22);
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
            this.gBtemp.Location = new System.Drawing.Point(272, 206);
            this.gBtemp.Name = "gBtemp";
            this.gBtemp.Size = new System.Drawing.Size(180, 144);
            this.gBtemp.TabIndex = 20;
            this.gBtemp.TabStop = false;
            this.gBtemp.Text = "Ajout d\'un temporaire";
            this.gBtemp.Visible = false;
            // 
            // txtnbh
            // 
            this.txtnbh.Location = new System.Drawing.Point(92, 104);
            this.txtnbh.Name = "txtnbh";
            this.txtnbh.Size = new System.Drawing.Size(76, 22);
            this.txtnbh.TabIndex = 26;
            // 
            // txttaux
            // 
            this.txttaux.Location = new System.Drawing.Point(57, 78);
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(111, 22);
            this.txttaux.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "NbHeures :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Taux :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Num :";
            // 
            // txtnump
            // 
            this.txtnump.Location = new System.Drawing.Point(57, 24);
            this.txtnump.Name = "txtnump";
            this.txtnump.Size = new System.Drawing.Size(111, 22);
            this.txtnump.TabIndex = 20;
            // 
            // txtnomp
            // 
            this.txtnomp.Location = new System.Drawing.Point(57, 50);
            this.txtnomp.Name = "txtnomp";
            this.txtnomp.Size = new System.Drawing.Size(111, 22);
            this.txtnomp.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(275, 182);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Salarié";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(350, 182);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 21);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Temporaire";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Employé à ajouter :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Département à ajouter :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 351);
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
            this.Name = "Form1";
            this.Text = "TP Entreprise";
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

