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
            this.panel2 = new System.Windows.Forms.Panel();
            this.docListe1 = new videoStar.vue.document.DocListe();
            this.annexeVue1 = new videoStar.annexeVue();
            this.gestStars1 = new videoStar.vue.star.GestStars();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnAnx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnx.Location = new System.Drawing.Point(3, 529);
            this.btnAnx.Name = "btnAnx";
            this.btnAnx.Size = new System.Drawing.Size(161, 53);
            this.btnAnx.TabIndex = 21;
            this.btnAnx.Text = " Annexes";
            this.btnAnx.UseVisualStyleBackColor = true;
            this.btnAnx.Click += new System.EventHandler(this.btnAnx_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilms.Location = new System.Drawing.Point(3, 221);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(161, 50);
            this.btnFilms.TabIndex = 20;
            this.btnFilms.Text = "Films";
            this.btnFilms.UseVisualStyleBackColor = true;
            this.btnFilms.Click += new System.EventHandler(this.btnFilms_Click);
            // 
            // BtnStars
            // 
            this.BtnStars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStars.Location = new System.Drawing.Point(3, 156);
            this.BtnStars.Name = "BtnStars";
            this.BtnStars.Size = new System.Drawing.Size(161, 50);
            this.BtnStars.TabIndex = 19;
            this.BtnStars.Text = "Stars";
            this.BtnStars.UseVisualStyleBackColor = true;
            this.BtnStars.Click += new System.EventHandler(this.BtnStars_Click);
            // 
            // btnExemplaires
            // 
            this.btnExemplaires.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemplaires.Location = new System.Drawing.Point(3, 470);
            this.btnExemplaires.Name = "btnExemplaires";
            this.btnExemplaires.Size = new System.Drawing.Size(161, 53);
            this.btnExemplaires.TabIndex = 18;
            this.btnExemplaires.Text = "Exemplaires";
            this.btnExemplaires.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 709);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 53);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(3, 650);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(161, 53);
            this.btnStats.TabIndex = 16;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnParametres
            // 
            this.btnParametres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametres.Location = new System.Drawing.Point(3, 588);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(161, 53);
            this.btnParametres.TabIndex = 15;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.UseVisualStyleBackColor = true;
            // 
            // btnAdherent
            // 
            this.btnAdherent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdherent.Location = new System.Drawing.Point(3, 346);
            this.btnAdherent.Name = "btnAdherent";
            this.btnAdherent.Size = new System.Drawing.Size(161, 53);
            this.btnAdherent.TabIndex = 14;
            this.btnAdherent.Text = "Adhérents";
            this.btnAdherent.UseVisualStyleBackColor = true;
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(3, 411);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(161, 53);
            this.btnLocations.TabIndex = 13;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            // 
            // btnTournage
            // 
            this.btnTournage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournage.Location = new System.Drawing.Point(3, 281);
            this.btnTournage.Name = "btnTournage";
            this.btnTournage.Size = new System.Drawing.Size(161, 53);
            this.btnTournage.TabIndex = 12;
            this.btnTournage.Text = "Lieu Tournage";
            this.btnTournage.UseVisualStyleBackColor = true;
            this.btnTournage.Click += new System.EventHandler(this.btnTournage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 76);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.docListe1);
            this.panel2.Controls.Add(this.annexeVue1);
            this.panel2.Controls.Add(this.gestStars1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(170, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 716);
            this.panel2.TabIndex = 3;
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private GestStars gestStars1;
        private System.Windows.Forms.Button btnAnx;
        private annexeVue annexeVue1;
        private vue.document.DocListe docListe1;
    }
}