using videoStar.vue.star;

namespace videoStar
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAnx = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.BtnStars = new System.Windows.Forms.Button();
            this.btnExemplaires = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.btnAdherent = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnTournage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.pnlPrinc = new System.Windows.Forms.Panel();
            this.listExpl1 = new videoStar.vue.exemplaire.ListExpl();
            this.docListe1 = new videoStar.vue.document.DocListe();
            this.annexeVue1 = new videoStar.annexeVue();
            this.gestStars1 = new videoStar.vue.star.GestStars();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPrinc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAnx);
            this.pnlMenu.Controls.Add(this.btnFilms);
            this.pnlMenu.Controls.Add(this.BtnStars);
            this.pnlMenu.Controls.Add(this.btnExemplaires);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnStats);
            this.pnlMenu.Controls.Add(this.btnParametres);
            this.pnlMenu.Controls.Add(this.btnAdherent);
            this.pnlMenu.Controls.Add(this.btnLocations);
            this.pnlMenu.Controls.Add(this.btnTournage);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(170, 792);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAnx
            // 
            this.btnAnx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnx.Location = new System.Drawing.Point(0, 529);
            this.btnAnx.Name = "btnAnx";
            this.btnAnx.Size = new System.Drawing.Size(170, 53);
            this.btnAnx.TabIndex = 21;
            this.btnAnx.Text = " Annexes";
            this.btnAnx.UseVisualStyleBackColor = false;
            this.btnAnx.Click += new System.EventHandler(this.btnAnx_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilms.Location = new System.Drawing.Point(0, 221);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(170, 50);
            this.btnFilms.TabIndex = 20;
            this.btnFilms.Text = "Films";
            this.btnFilms.UseVisualStyleBackColor = false;
            this.btnFilms.Click += new System.EventHandler(this.btnFilms_Click);
            // 
            // BtnStars
            // 
            this.BtnStars.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnStars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStars.Location = new System.Drawing.Point(0, 156);
            this.BtnStars.Name = "BtnStars";
            this.BtnStars.Size = new System.Drawing.Size(170, 50);
            this.BtnStars.TabIndex = 19;
            this.BtnStars.Text = "Stars";
            this.BtnStars.UseVisualStyleBackColor = false;
            this.BtnStars.Click += new System.EventHandler(this.BtnStars_Click);
            // 
            // btnExemplaires
            // 
            this.btnExemplaires.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExemplaires.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExemplaires.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemplaires.Location = new System.Drawing.Point(0, 470);
            this.btnExemplaires.Name = "btnExemplaires";
            this.btnExemplaires.Size = new System.Drawing.Size(170, 53);
            this.btnExemplaires.TabIndex = 18;
            this.btnExemplaires.Text = "Exemplaires";
            this.btnExemplaires.UseVisualStyleBackColor = false;
            this.btnExemplaires.Click += new System.EventHandler(this.btnExemplaires_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 706);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 53);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(0, 647);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(170, 53);
            this.btnStats.TabIndex = 16;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = false;
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParametres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametres.Location = new System.Drawing.Point(0, 588);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(170, 53);
            this.btnParametres.TabIndex = 15;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.UseVisualStyleBackColor = false;
            // 
            // btnAdherent
            // 
            this.btnAdherent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdherent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdherent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdherent.Location = new System.Drawing.Point(0, 346);
            this.btnAdherent.Name = "btnAdherent";
            this.btnAdherent.Size = new System.Drawing.Size(170, 53);
            this.btnAdherent.TabIndex = 14;
            this.btnAdherent.Text = "Adhérents";
            this.btnAdherent.UseVisualStyleBackColor = false;
            // 
            // btnLocations
            // 
            this.btnLocations.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(0, 411);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(170, 53);
            this.btnLocations.TabIndex = 13;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = false;
            // 
            // btnTournage
            // 
            this.btnTournage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTournage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTournage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournage.Location = new System.Drawing.Point(0, 281);
            this.btnTournage.Name = "btnTournage";
            this.btnTournage.Size = new System.Drawing.Size(170, 53);
            this.btnTournage.TabIndex = 12;
            this.btnTournage.Text = "Lieux Tournage";
            this.btnTournage.UseVisualStyleBackColor = false;
            this.btnTournage.Click += new System.EventHandler(this.btnTournage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Controls.Add(this.lblRecherche);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 76);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(908, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Teal;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(-13, -2);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(374, 78);
            this.lblTitre.TabIndex = 48;
            this.lblTitre.Text = "VIDEOSTAR";
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblRecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(728, 27);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(151, 21);
            this.lblRecherche.TabIndex = 47;
            this.lblRecherche.Text = "utilisateur identifié";
            // 
            // pnlPrinc
            // 
            this.pnlPrinc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlPrinc.BackgroundImage = global::videoStar.Properties.Resources.darth_vader_1207142_1920;
            this.pnlPrinc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrinc.Controls.Add(this.listExpl1);
            this.pnlPrinc.Controls.Add(this.docListe1);
            this.pnlPrinc.Controls.Add(this.annexeVue1);
            this.pnlPrinc.Controls.Add(this.gestStars1);
            this.pnlPrinc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrinc.Location = new System.Drawing.Point(170, 76);
            this.pnlPrinc.Name = "pnlPrinc";
            this.pnlPrinc.Size = new System.Drawing.Size(1081, 716);
            this.pnlPrinc.TabIndex = 3;
            this.pnlPrinc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrinc_Paint);
            // 
            // listExpl1
            // 
            this.listExpl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listExpl1.BackgroundImage")));
            this.listExpl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listExpl1.Location = new System.Drawing.Point(291, 52);
            this.listExpl1.Name = "listExpl1";
            this.listExpl1.Size = new System.Drawing.Size(44, 109);
            this.listExpl1.TabIndex = 3;
            this.listExpl1.Load += new System.EventHandler(this.listExpl1_Load);
            // 
            // docListe1
            // 
            this.docListe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("docListe1.BackgroundImage")));
            this.docListe1.Location = new System.Drawing.Point(209, 52);
            this.docListe1.Name = "docListe1";
            this.docListe1.Size = new System.Drawing.Size(47, 98);
            this.docListe1.TabIndex = 2;
            // 
            // annexeVue1
            // 
            this.annexeVue1.Location = new System.Drawing.Point(122, 52);
            this.annexeVue1.Name = "annexeVue1";
            this.annexeVue1.Size = new System.Drawing.Size(54, 88);
            this.annexeVue1.TabIndex = 1;
            // 
            // gestStars1
            // 
            this.gestStars1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gestStars1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gestStars1.BackgroundImage")));
            this.gestStars1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gestStars1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gestStars1.Location = new System.Drawing.Point(51, 59);
            this.gestStars1.Name = "gestStars1";
            this.gestStars1.Size = new System.Drawing.Size(46, 81);
            this.gestStars1.SlctStar = null;
            this.gestStars1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1251, 792);
            this.Controls.Add(this.pnlPrinc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPrinc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.Button BtnStars;
        private System.Windows.Forms.Button btnExemplaires;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.Button btnAdherent;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnTournage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrinc;
        private GestStars gestStars1;
        private System.Windows.Forms.Button btnAnx;
        private annexeVue annexeVue1;
        private vue.document.DocListe docListe1;
        private vue.exemplaire.ListExpl listExpl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblRecherche;
    }
}