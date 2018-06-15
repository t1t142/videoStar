namespace videoStar.vue.annexes
{
    partial class annexeVue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(annexeVue));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnFilms = new System.Windows.Forms.Button();
            this.BtnStars = new System.Windows.Forms.Button();
            this.btnAdherent = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnTournage = new System.Windows.Forms.Button();
            this.btnExemplaires = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleVue1 = new videoStar.vue.role.RoleVue();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlMenu.Controls.Add(this.btnFilms);
            this.pnlMenu.Controls.Add(this.BtnStars);
            this.pnlMenu.Controls.Add(this.btnExemplaires);
            this.pnlMenu.Controls.Add(this.btnAdherent);
            this.pnlMenu.Controls.Add(this.btnLocations);
            this.pnlMenu.Controls.Add(this.btnTournage);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1279, 59);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnFilms
            // 
            this.btnFilms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilms.Location = new System.Drawing.Point(290, 3);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(161, 50);
            this.btnFilms.TabIndex = 20;
            this.btnFilms.Text = "Support";
            this.btnFilms.UseVisualStyleBackColor = true;
            // 
            // BtnStars
            // 
            this.BtnStars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStars.Location = new System.Drawing.Point(123, 3);
            this.BtnStars.Name = "BtnStars";
            this.BtnStars.Size = new System.Drawing.Size(161, 50);
            this.BtnStars.TabIndex = 19;
            this.BtnStars.Text = "Roles";
            this.BtnStars.UseVisualStyleBackColor = true;
            // 
            // btnAdherent
            // 
            this.btnAdherent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdherent.Location = new System.Drawing.Point(624, 0);
            this.btnAdherent.Name = "btnAdherent";
            this.btnAdherent.Size = new System.Drawing.Size(161, 53);
            this.btnAdherent.TabIndex = 14;
            this.btnAdherent.Text = "Type Films";
            this.btnAdherent.UseVisualStyleBackColor = true;
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.Location = new System.Drawing.Point(791, 0);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(161, 53);
            this.btnLocations.TabIndex = 13;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            // 
            // btnTournage
            // 
            this.btnTournage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournage.Location = new System.Drawing.Point(457, 0);
            this.btnTournage.Name = "btnTournage";
            this.btnTournage.Size = new System.Drawing.Size(161, 53);
            this.btnTournage.TabIndex = 12;
            this.btnTournage.Text = "etat";
            this.btnTournage.UseVisualStyleBackColor = true;
            // 
            // btnExemplaires
            // 
            this.btnExemplaires.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemplaires.Location = new System.Drawing.Point(958, 0);
            this.btnExemplaires.Name = "btnExemplaires";
            this.btnExemplaires.Size = new System.Drawing.Size(161, 53);
            this.btnExemplaires.TabIndex = 18;
            this.btnExemplaires.Text = "Exemplaires";
            this.btnExemplaires.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roleVue1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 864);
            this.panel1.TabIndex = 3;
            // 
            // roleVue1
            // 
            this.roleVue1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roleVue1.BackgroundImage")));
            this.roleVue1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roleVue1.Location = new System.Drawing.Point(3, 0);
            this.roleVue1.Name = "roleVue1";
            this.roleVue1.Size = new System.Drawing.Size(1027, 695);
            this.roleVue1.TabIndex = 0;
            // 
            // annexeVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "annexeVue";
            this.Size = new System.Drawing.Size(1279, 923);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.Button BtnStars;
        private System.Windows.Forms.Button btnExemplaires;
        private System.Windows.Forms.Button btnAdherent;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnTournage;
        private System.Windows.Forms.Panel panel1;
        private role.RoleVue roleVue1;
    }
}
