using videoStar.vue.star;

namespace videoStar.vue.star
{
    partial class GestStars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestStars));
            this.lblPages = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ajoutStar1 = new videoStar.vue.star.ajoutStar();
            this.detailStar1 = new videoStar.vue.star.DetailStar();
            this.starVue8 = new videoStar.vue.star.StarVue();
            this.starVue7 = new videoStar.vue.star.StarVue();
            this.starVue6 = new videoStar.vue.star.StarVue();
            this.starVue5 = new videoStar.vue.star.StarVue();
            this.starVue4 = new videoStar.vue.star.StarVue();
            this.starVue3 = new videoStar.vue.star.StarVue();
            this.starVue2 = new videoStar.vue.star.StarVue();
            this.starVue1 = new videoStar.vue.star.StarVue();
            this.SuspendLayout();
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.BackColor = System.Drawing.Color.Teal;
            this.lblPages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(409, 680);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(104, 21);
            this.lblPages.TabIndex = 41;
            this.lblPages.Text = "Pages 12/12";
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Teal;
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(602, 672);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(118, 36);
            this.btnSuivant.TabIndex = 40;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Teal;
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(188, 671);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(125, 37);
            this.btnPrecedent.TabIndex = 39;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(485, 12);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(137, 27);
            this.txtRecherche.TabIndex = 38;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.Teal;
            this.lblRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(289, 12);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(167, 21);
            this.lblRecherche.TabIndex = 37;
            this.lblRecherche.Text = "Recherche par Nom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Teal;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(931, 69);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 39);
            this.btnAjouter.TabIndex = 36;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(-7, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(247, 39);
            this.lblTitre.TabIndex = 46;
            this.lblTitre.Text = "GESTION STARS";
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Teal;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(931, 128);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(121, 39);
            this.btnselect.TabIndex = 49;
            this.btnselect.Text = "Editer";
            this.btnselect.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(931, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 50;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(931, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 51;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ajoutStar1
            // 
            this.ajoutStar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ajoutStar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutStar1.BackgroundImage")));
            this.ajoutStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ajoutStar1.Location = new System.Drawing.Point(1006, 476);
            this.ajoutStar1.Name = "ajoutStar1";
            this.ajoutStar1.Size = new System.Drawing.Size(55, 86);
            this.ajoutStar1.TabIndex = 48;
            // 
            // detailStar1
            // 
            this.detailStar1.Location = new System.Drawing.Point(1006, 357);
            this.detailStar1.Name = "detailStar1";
            this.detailStar1.Size = new System.Drawing.Size(73, 90);
            this.detailStar1.TabIndex = 47;
            // 
            // starVue8
            // 
            this.starVue8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue8.Location = new System.Drawing.Point(720, 371);
            this.starVue8.Name = "starVue8";
            this.starVue8.Size = new System.Drawing.Size(190, 278);
            this.starVue8.Star = null;
            this.starVue8.TabIndex = 45;
            this.starVue8.Click += new System.EventHandler(this.starVue_Click);
            // 
            // starVue7
            // 
            this.starVue7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue7.Location = new System.Drawing.Point(485, 371);
            this.starVue7.Name = "starVue7";
            this.starVue7.Size = new System.Drawing.Size(190, 278);
            this.starVue7.Star = null;
            this.starVue7.TabIndex = 44;
            this.starVue7.Click += new System.EventHandler(this.starVue_Click);
            // 
            // starVue6
            // 
            this.starVue6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue6.Location = new System.Drawing.Point(255, 371);
            this.starVue6.Name = "starVue6";
            this.starVue6.Size = new System.Drawing.Size(190, 278);
            this.starVue6.Star = null;
            this.starVue6.TabIndex = 43;
            this.starVue6.Click += new System.EventHandler(this.starVue_Click);
            // 
            // starVue5
            // 
            this.starVue5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue5.Location = new System.Drawing.Point(33, 371);
            this.starVue5.Name = "starVue5";
            this.starVue5.Size = new System.Drawing.Size(190, 278);
            this.starVue5.Star = null;
            this.starVue5.TabIndex = 42;
            this.starVue5.Click += new System.EventHandler(this.starVue_Click);
            // 
            // starVue4
            // 
            this.starVue4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue4.Location = new System.Drawing.Point(710, 69);
            this.starVue4.Name = "starVue4";
            this.starVue4.Size = new System.Drawing.Size(190, 278);
            this.starVue4.Star = null;
            this.starVue4.TabIndex = 35;
            this.starVue4.Click += new System.EventHandler(this.starVue_Click);
            this.starVue4.DoubleClick += new System.EventHandler(this.DoubleClick);
            // 
            // starVue3
            // 
            this.starVue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue3.Location = new System.Drawing.Point(485, 69);
            this.starVue3.Name = "starVue3";
            this.starVue3.Size = new System.Drawing.Size(190, 278);
            this.starVue3.Star = null;
            this.starVue3.TabIndex = 34;
            this.starVue3.Click += new System.EventHandler(this.starVue_Click);
            // 
            // starVue2
            // 
            this.starVue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starVue2.Location = new System.Drawing.Point(255, 69);
            this.starVue2.Name = "starVue2";
            this.starVue2.Size = new System.Drawing.Size(190, 278);
            this.starVue2.Star = null;
            this.starVue2.TabIndex = 33;
            this.starVue2.Click += new System.EventHandler(this.starVue_Click);
            // 
            // starVue1
            // 
            this.starVue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.starVue1.Cursor = System.Windows.Forms.Cursors.Default;
            this.starVue1.Location = new System.Drawing.Point(33, 69);
            this.starVue1.Name = "starVue1";
            this.starVue1.Size = new System.Drawing.Size(190, 278);
            this.starVue1.Star = null;
            this.starVue1.TabIndex = 32;
            this.starVue1.Click += new System.EventHandler(this.starVue_Click);
            this.starVue1.DoubleClick += new System.EventHandler(this.DoubleClick);
            // 
            // GestStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::videoStar.Properties.Resources.tunnel_3233082_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.ajoutStar1);
            this.Controls.Add(this.detailStar1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.starVue8);
            this.Controls.Add(this.starVue7);
            this.Controls.Add(this.starVue6);
            this.Controls.Add(this.starVue5);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.starVue4);
            this.Controls.Add(this.starVue3);
            this.Controls.Add(this.starVue2);
            this.Controls.Add(this.starVue1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "GestStars";
            this.Size = new System.Drawing.Size(1082, 724);
            this.Load += new System.EventHandler(this.GestStars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StarVue starVue8;
        private StarVue starVue7;
        private StarVue starVue6;
        private StarVue starVue5;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Button btnAjouter;
        private StarVue starVue4;
        private StarVue starVue3;
        private StarVue starVue2;
        private StarVue starVue1;
        private System.Windows.Forms.Label lblTitre;
        private DetailStar detailStar1;
        private ajoutStar ajoutStar1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
