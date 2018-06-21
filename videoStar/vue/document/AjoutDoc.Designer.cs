namespace videoStar.vue.document
{
    partial class AjoutDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutDoc));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.btnAjoutStar = new System.Windows.Forms.Button();
            this.btnAjoutLieux = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.ajoutJouer1 = new videoStar.vue.document.AjoutJouer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(198, 322);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(141, 29);
            this.cbxType.TabIndex = 20;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            this.cbxType.TextChanged += new System.EventHandler(this.cbxType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type de Film";
            // 
            // txtAnnee
            // 
            this.txtAnnee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnee.Location = new System.Drawing.Point(198, 249);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(141, 27);
            this.txtAnnee.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Année de sortie";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(147, 186);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(192, 27);
            this.txtTitre.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Titre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(733, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 365);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhoto
            // 
            this.txtPhoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoto.Location = new System.Drawing.Point(586, 145);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(141, 27);
            this.txtPhoto.TabIndex = 24;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Teal;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(238, 387);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(101, 33);
            this.btnValider.TabIndex = 27;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnretour
            // 
            this.btnretour.BackColor = System.Drawing.Color.Teal;
            this.btnretour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnretour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretour.Location = new System.Drawing.Point(886, 598);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(101, 33);
            this.btnretour.TabIndex = 26;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = false;
            this.btnretour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAjoutStar
            // 
            this.btnAjoutStar.BackColor = System.Drawing.Color.Teal;
            this.btnAjoutStar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjoutStar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutStar.Location = new System.Drawing.Point(86, 492);
            this.btnAjoutStar.Name = "btnAjoutStar";
            this.btnAjoutStar.Size = new System.Drawing.Size(253, 33);
            this.btnAjoutStar.TabIndex = 30;
            this.btnAjoutStar.Text = "Ajouter Star";
            this.btnAjoutStar.UseVisualStyleBackColor = false;
            this.btnAjoutStar.Visible = false;
            this.btnAjoutStar.Click += new System.EventHandler(this.btnAjtStar_Click);
            // 
            // btnAjoutLieux
            // 
            this.btnAjoutLieux.BackColor = System.Drawing.Color.Teal;
            this.btnAjoutLieux.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjoutLieux.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutLieux.Location = new System.Drawing.Point(86, 550);
            this.btnAjoutLieux.Name = "btnAjoutLieux";
            this.btnAjoutLieux.Size = new System.Drawing.Size(253, 33);
            this.btnAjoutLieux.TabIndex = 31;
            this.btnAjoutLieux.Text = "Ajouter Lieux de Tournage";
            this.btnAjoutLieux.UseVisualStyleBackColor = false;
            this.btnAjoutLieux.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(198, 117);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(141, 27);
            this.txtCode.TabIndex = 34;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(131, 120);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(54, 21);
            this.lblCode.TabIndex = 33;
            this.lblCode.Text = "Code";
            // 
            // ajoutJouer1
            // 
            this.ajoutJouer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutJouer1.BackgroundImage")));
            this.ajoutJouer1.Location = new System.Drawing.Point(506, 519);
            this.ajoutJouer1.Name = "ajoutJouer1";
            this.ajoutJouer1.Size = new System.Drawing.Size(102, 105);
            this.ajoutJouer1.SlctDoc = null;
            this.ajoutJouer1.SlctStar = null;
            this.ajoutJouer1.TabIndex = 32;
            // 
            // AjoutDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::videoStar.Properties.Resources.star_wars_2897280_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.ajoutJouer1);
            this.Controls.Add(this.btnAjoutLieux);
            this.Controls.Add(this.btnAjoutStar);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AjoutDoc";
            this.Size = new System.Drawing.Size(1036, 689);
            this.VisibleChanged += new System.EventHandler(this.AjoutDoc_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Button btnAjoutStar;
        private System.Windows.Forms.Button btnAjoutLieux;
        private AjoutJouer ajoutJouer1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
    }
}
