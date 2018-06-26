namespace videoStar.vue.document
{
    partial class DocListe
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocListe));
            this.button1 = new System.Windows.Forms.Button();
            this.ajoutDoc1 = new videoStar.vue.document.AjoutDoc();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.docVue1 = new videoStar.vue.document.DocVue();
            this.docVue2 = new videoStar.vue.document.DocVue();
            this.docVue3 = new videoStar.vue.document.DocVue();
            this.docVue4 = new videoStar.vue.document.DocVue();
            this.docVue5 = new videoStar.vue.document.DocVue();
            this.docVue6 = new videoStar.vue.document.DocVue();
            this.docVue7 = new videoStar.vue.document.DocVue();
            this.docVue8 = new videoStar.vue.document.DocVue();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(934, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ajoutDoc1
            // 
            this.ajoutDoc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutDoc1.BackgroundImage")));
            this.ajoutDoc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajoutDoc1.Film = null;
            this.ajoutDoc1.Location = new System.Drawing.Point(934, 334);
            this.ajoutDoc1.Name = "ajoutDoc1";
            this.ajoutDoc1.Size = new System.Drawing.Size(119, 130);
            this.ajoutDoc1.St = null;
            this.ajoutDoc1.TabIndex = 23;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(934, 256);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 39);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(934, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 39);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Teal;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(934, 136);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(121, 39);
            this.btnselect.TabIndex = 52;
            this.btnselect.Text = "Editer";
            this.btnselect.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(-7, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(244, 39);
            this.lblTitre.TabIndex = 57;
            this.lblTitre.Text = "GESTION FILMS";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(627, 12);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(137, 27);
            this.txtRecherche.TabIndex = 56;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(431, 12);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(167, 21);
            this.lblRecherche.TabIndex = 55;
            this.lblRecherche.Text = "Recherche par Nom";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.BackColor = System.Drawing.Color.Teal;
            this.lblPages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.White;
            this.lblPages.Location = new System.Drawing.Point(513, 661);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(104, 21);
            this.lblPages.TabIndex = 60;
            this.lblPages.Text = "Pages 12/12";
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Teal;
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.White;
            this.btnSuivant.Location = new System.Drawing.Point(706, 653);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(118, 36);
            this.btnSuivant.TabIndex = 59;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Teal;
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.ForeColor = System.Drawing.Color.White;
            this.btnPrecedent.Location = new System.Drawing.Point(292, 652);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(125, 37);
            this.btnPrecedent.TabIndex = 58;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            // 
            // docVue1
            // 
            this.docVue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue1.Location = new System.Drawing.Point(42, 70);
            this.docVue1.Name = "docVue1";
            this.docVue1.Size = new System.Drawing.Size(190, 278);
            this.docVue1.TabIndex = 61;
            // 
            // docVue2
            // 
            this.docVue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue2.Location = new System.Drawing.Point(266, 70);
            this.docVue2.Name = "docVue2";
            this.docVue2.Size = new System.Drawing.Size(190, 278);
            this.docVue2.TabIndex = 62;
            // 
            // docVue3
            // 
            this.docVue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue3.Location = new System.Drawing.Point(483, 70);
            this.docVue3.Name = "docVue3";
            this.docVue3.Size = new System.Drawing.Size(190, 278);
            this.docVue3.TabIndex = 63;
            // 
            // docVue4
            // 
            this.docVue4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue4.Location = new System.Drawing.Point(723, 70);
            this.docVue4.Name = "docVue4";
            this.docVue4.Size = new System.Drawing.Size(190, 278);
            this.docVue4.TabIndex = 64;
            // 
            // docVue5
            // 
            this.docVue5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue5.Location = new System.Drawing.Point(42, 364);
            this.docVue5.Name = "docVue5";
            this.docVue5.Size = new System.Drawing.Size(190, 278);
            this.docVue5.TabIndex = 65;
            // 
            // docVue6
            // 
            this.docVue6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue6.Location = new System.Drawing.Point(266, 364);
            this.docVue6.Name = "docVue6";
            this.docVue6.Size = new System.Drawing.Size(190, 278);
            this.docVue6.TabIndex = 66;
            // 
            // docVue7
            // 
            this.docVue7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue7.Location = new System.Drawing.Point(483, 364);
            this.docVue7.Name = "docVue7";
            this.docVue7.Size = new System.Drawing.Size(190, 278);
            this.docVue7.TabIndex = 67;
            // 
            // docVue8
            // 
            this.docVue8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.docVue8.Location = new System.Drawing.Point(723, 364);
            this.docVue8.Name = "docVue8";
            this.docVue8.Size = new System.Drawing.Size(190, 278);
            this.docVue8.TabIndex = 68;
            // 
            // DocListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::videoStar.Properties.Resources.sci_fi_3233076_1920;
            this.Controls.Add(this.docVue8);
            this.Controls.Add(this.docVue7);
            this.Controls.Add(this.docVue6);
            this.Controls.Add(this.docVue5);
            this.Controls.Add(this.docVue4);
            this.Controls.Add(this.docVue3);
            this.Controls.Add(this.docVue2);
            this.Controls.Add(this.docVue1);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.ajoutDoc1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DocListe";
            this.Size = new System.Drawing.Size(1093, 692);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AjoutDoc ajoutDoc1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private DocVue docVue1;
        private DocVue docVue2;
        private DocVue docVue3;
        private DocVue docVue4;
        private DocVue docVue5;
        private DocVue docVue6;
        private DocVue docVue7;
        private DocVue docVue8;
    }
}
