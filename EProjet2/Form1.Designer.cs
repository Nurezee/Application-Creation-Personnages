namespace EProjet2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSelectionPerso = new System.Windows.Forms.TextBox();
            this.lstPerso = new System.Windows.Forms.ListBox();
            this.nudVie = new System.Windows.Forms.NumericUpDown();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpRechercher = new System.Windows.Forms.GroupBox();
            this.txtRechercherLogin = new System.Windows.Forms.TextBox();
            this.txtRechercherVie = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTerminerRecherche = new System.Windows.Forms.Button();
            this.btnParLogin = new System.Windows.Forms.Button();
            this.btnParVie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).BeginInit();
            this.grpRechercher.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVie.Location = new System.Drawing.Point(12, 69);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(28, 13);
            this.lblVie.TabIndex = 1;
            this.lblVie.Text = "Vie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personnages :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(69, 27);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(190, 20);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // txtSelectionPerso
            // 
            this.txtSelectionPerso.Enabled = false;
            this.txtSelectionPerso.Location = new System.Drawing.Point(12, 107);
            this.txtSelectionPerso.Name = "txtSelectionPerso";
            this.txtSelectionPerso.Size = new System.Drawing.Size(247, 20);
            this.txtSelectionPerso.TabIndex = 5;
            // 
            // lstPerso
            // 
            this.lstPerso.BackColor = System.Drawing.SystemColors.Window;
            this.lstPerso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPerso.ForeColor = System.Drawing.Color.Black;
            this.lstPerso.FormattingEnabled = true;
            this.lstPerso.Location = new System.Drawing.Point(12, 190);
            this.lstPerso.Name = "lstPerso";
            this.lstPerso.Size = new System.Drawing.Size(247, 134);
            this.lstPerso.TabIndex = 6;
            this.lstPerso.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPerso_DrawItem);
            this.lstPerso.SelectedIndexChanged += new System.EventHandler(this.lstPerso_SelectedIndexChanged);
            // 
            // nudVie
            // 
            this.nudVie.Enabled = false;
            this.nudVie.Location = new System.Drawing.Point(69, 67);
            this.nudVie.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudVie.Name = "nudVie";
            this.nudVie.Size = new System.Drawing.Size(85, 20);
            this.nudVie.TabIndex = 7;
            this.nudVie.ValueChanged += new System.EventHandler(this.nudVie_ValueChanged);
            this.nudVie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudVie_KeyPress);
            // 
            // btnCreer
            // 
            this.btnCreer.Enabled = false;
            this.btnCreer.Location = new System.Drawing.Point(184, 64);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 9;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            this.btnCreer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCreer_KeyPress);
            // 
            // btnModif
            // 
            this.btnModif.Enabled = false;
            this.btnModif.Location = new System.Drawing.Point(184, 155);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 10;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnTerminer
            // 
            this.btnTerminer.Enabled = false;
            this.btnTerminer.Location = new System.Drawing.Point(184, 155);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(75, 23);
            this.btnTerminer.TabIndex = 11;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.UseVisualStyleBackColor = true;
            this.btnTerminer.Visible = false;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(184, 418);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Réinitialiser";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(103, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpRechercher
            // 
            this.grpRechercher.Controls.Add(this.btnParVie);
            this.grpRechercher.Controls.Add(this.btnParLogin);
            this.grpRechercher.Controls.Add(this.txtRechercherVie);
            this.grpRechercher.Controls.Add(this.txtRechercherLogin);
            this.grpRechercher.Location = new System.Drawing.Point(12, 330);
            this.grpRechercher.Name = "grpRechercher";
            this.grpRechercher.Size = new System.Drawing.Size(247, 82);
            this.grpRechercher.TabIndex = 14;
            this.grpRechercher.TabStop = false;
            this.grpRechercher.Text = "Rechercher";
            // 
            // txtRechercherLogin
            // 
            this.txtRechercherLogin.Enabled = false;
            this.txtRechercherLogin.Location = new System.Drawing.Point(92, 21);
            this.txtRechercherLogin.Name = "txtRechercherLogin";
            this.txtRechercherLogin.Size = new System.Drawing.Size(121, 20);
            this.txtRechercherLogin.TabIndex = 2;
            this.txtRechercherLogin.TextChanged += new System.EventHandler(this.txtRechercherLogin_TextChanged);
            // 
            // txtRechercherVie
            // 
            this.txtRechercherVie.Enabled = false;
            this.txtRechercherVie.Location = new System.Drawing.Point(92, 56);
            this.txtRechercherVie.Name = "txtRechercherVie";
            this.txtRechercherVie.Size = new System.Drawing.Size(59, 20);
            this.txtRechercherVie.TabIndex = 3;
            this.txtRechercherVie.TextChanged += new System.EventHandler(this.txtRechercherVie_TextChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Enabled = false;
            this.btnRechercher.Location = new System.Drawing.Point(22, 418);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 15;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnTerminerRecherche
            // 
            this.btnTerminerRecherche.Enabled = false;
            this.btnTerminerRecherche.Location = new System.Drawing.Point(103, 418);
            this.btnTerminerRecherche.Name = "btnTerminerRecherche";
            this.btnTerminerRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnTerminerRecherche.TabIndex = 16;
            this.btnTerminerRecherche.Text = "Terminer";
            this.btnTerminerRecherche.UseVisualStyleBackColor = true;
            this.btnTerminerRecherche.Visible = false;
            this.btnTerminerRecherche.Click += new System.EventHandler(this.btnTerminerRecherche_Click);
            // 
            // btnParLogin
            // 
            this.btnParLogin.Enabled = false;
            this.btnParLogin.Location = new System.Drawing.Point(10, 19);
            this.btnParLogin.Name = "btnParLogin";
            this.btnParLogin.Size = new System.Drawing.Size(76, 23);
            this.btnParLogin.TabIndex = 4;
            this.btnParLogin.Text = "Par Login";
            this.btnParLogin.UseVisualStyleBackColor = true;
            this.btnParLogin.Click += new System.EventHandler(this.btnParLogin_Click);
            // 
            // btnParVie
            // 
            this.btnParVie.Enabled = false;
            this.btnParVie.Location = new System.Drawing.Point(10, 54);
            this.btnParVie.Name = "btnParVie";
            this.btnParVie.Size = new System.Drawing.Size(76, 23);
            this.btnParVie.TabIndex = 5;
            this.btnParVie.Text = "Par Vie";
            this.btnParVie.UseVisualStyleBackColor = true;
            this.btnParVie.Click += new System.EventHandler(this.btnParVie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.btnTerminerRecherche);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.grpRechercher);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.nudVie);
            this.Controls.Add(this.lstPerso);
            this.Controls.Add(this.txtSelectionPerso);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).EndInit();
            this.grpRechercher.ResumeLayout(false);
            this.grpRechercher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSelectionPerso;
        private System.Windows.Forms.ListBox lstPerso;
        private System.Windows.Forms.NumericUpDown nudVie;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnTerminer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpRechercher;
        private System.Windows.Forms.TextBox txtRechercherVie;
        private System.Windows.Forms.TextBox txtRechercherLogin;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnTerminerRecherche;
        private System.Windows.Forms.Button btnParVie;
        private System.Windows.Forms.Button btnParLogin;
    }
}

