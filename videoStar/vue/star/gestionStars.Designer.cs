namespace videoStar.vue.star
{
    partial class gestionStars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionStars));
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.star2 = new videoStar.vue.star.star();
            this.star1 = new videoStar.vue.star.star();
            this.star8 = new videoStar.vue.star.star();
            this.star7 = new videoStar.vue.star.star();
            this.star6 = new videoStar.vue.star.star();
            this.star5 = new videoStar.vue.star.star();
            this.star4 = new videoStar.vue.star.star();
            this.star3 = new videoStar.vue.star.star();
            this.ajoutStar1 = new videoStar.vue.star.ajoutStar();
            this.SuspendLayout();
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Teal;
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(156, 750);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(125, 37);
            this.btnPrecedent.TabIndex = 15;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.button2btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Teal;
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(631, 750);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(118, 36);
            this.btnSuivant.TabIndex = 16;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Teal;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(867, 19);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 50);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(-7, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(231, 39);
            this.lblTitre.TabIndex = 18;
            this.lblTitre.Text = "GESTION STAR";
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.Teal;
            this.lblRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(311, 46);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(167, 21);
            this.lblRecherche.TabIndex = 19;
            this.lblRecherche.Text = "Recherche par Nom";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(523, 42);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(137, 27);
            this.txtRecherche.TabIndex = 20;
            this.txtRecherche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.BackColor = System.Drawing.Color.Teal;
            this.lblPages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(391, 758);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(167, 21);
            this.lblPages.TabIndex = 22;
            this.lblPages.Text = "Recherche par Nom";
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.star2.Location = new System.Drawing.Point(278, 104);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(190, 278);
            this.star2.TabIndex = 31;
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.star1.Location = new System.Drawing.Point(47, 104);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(190, 278);
            this.star1.TabIndex = 30;
            // 
            // star8
            // 
            this.star8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star8.Location = new System.Drawing.Point(760, 425);
            this.star8.Name = "star8";
            this.star8.Size = new System.Drawing.Size(190, 278);
            this.star8.TabIndex = 29;
            // 
            // star7
            // 
            this.star7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star7.Location = new System.Drawing.Point(510, 425);
            this.star7.Name = "star7";
            this.star7.Size = new System.Drawing.Size(190, 278);
            this.star7.TabIndex = 28;
            // 
            // star6
            // 
            this.star6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star6.Location = new System.Drawing.Point(278, 425);
            this.star6.Name = "star6";
            this.star6.Size = new System.Drawing.Size(190, 278);
            this.star6.TabIndex = 27;
            // 
            // star5
            // 
            this.star5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star5.Location = new System.Drawing.Point(47, 425);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(190, 278);
            this.star5.TabIndex = 26;
            // 
            // star4
            // 
            this.star4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star4.Location = new System.Drawing.Point(760, 116);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(190, 278);
            this.star4.TabIndex = 25;
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star3.Location = new System.Drawing.Point(510, 116);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(190, 278);
            this.star3.TabIndex = 24;
            // 
            // ajoutStar1
            // 
            this.ajoutStar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ajoutStar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutStar1.BackgroundImage")));
            this.ajoutStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ajoutStar1.Location = new System.Drawing.Point(76, 116);
            this.ajoutStar1.Name = "ajoutStar1";
            this.ajoutStar1.Size = new System.Drawing.Size(1070, 599);
            this.ajoutStar1.TabIndex = 21;
            this.ajoutStar1.Load += new System.EventHandler(this.ajoutStar1_Load);
            // 
            // gestionStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::videoStar.Properties.Resources.tunnel_3233082_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.star8);
            this.Controls.Add(this.star7);
            this.Controls.Add(this.star6);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.ajoutStar1);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Name = "gestionStars";
            this.Size = new System.Drawing.Size(1049, 805);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
     
       
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private ajoutStar ajoutStar1;
        private System.Windows.Forms.Label lblPages;
        private star star3;
        private star star4;
        private star star8;
        private star star7;
        private star star6;
        private star star5;
        private star star1;
        private star star2;
    }
}
