﻿namespace videoStar.vue.document
{
    partial class AjoutJouer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutJouer));
            this.btnAjtStar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifStar = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPerso = new System.Windows.Forms.TextBox();
            this.lblPerso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.gestStars1 = new videoStar.vue.star.GestStars();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjtStar
            // 
            this.btnAjtStar.BackColor = System.Drawing.Color.Teal;
            this.btnAjtStar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjtStar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjtStar.Location = new System.Drawing.Point(202, 33);
            this.btnAjtStar.Name = "btnAjtStar";
            this.btnAjtStar.Size = new System.Drawing.Size(101, 33);
            this.btnAjtStar.TabIndex = 24;
            this.btnAjtStar.Text = "Ajouter";
            this.btnAjtStar.UseVisualStyleBackColor = false;
            this.btnAjtStar.Click += new System.EventHandler(this.btnAjtStar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Role";
            // 
            // txtStar
            // 
            this.txtStar.Enabled = false;
            this.txtStar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStar.Location = new System.Drawing.Point(184, 42);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(161, 27);
            this.txtStar.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(117, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Star";
            // 
            // btnModifStar
            // 
            this.btnModifStar.BackColor = System.Drawing.Color.Teal;
            this.btnModifStar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifStar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifStar.Location = new System.Drawing.Point(368, 36);
            this.btnModifStar.Name = "btnModifStar";
            this.btnModifStar.Size = new System.Drawing.Size(101, 33);
            this.btnModifStar.TabIndex = 30;
            this.btnModifStar.Text = "Modifier";
            this.btnModifStar.UseVisualStyleBackColor = false;
            this.btnModifStar.Click += new System.EventHandler(this.btnAjtStar_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Teal;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(676, 573);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(101, 33);
            this.btnValider.TabIndex = 32;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Teal;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(820, 573);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(101, 33);
            this.btnRetour.TabIndex = 33;
            this.btnRetour.Text = "Annuler";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 141);
            this.dataGridView1.TabIndex = 34;
            // 
            // txtPerso
            // 
            this.txtPerso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerso.Location = new System.Drawing.Point(184, 162);
            this.txtPerso.Name = "txtPerso";
            this.txtPerso.Size = new System.Drawing.Size(161, 27);
            this.txtPerso.TabIndex = 37;
            // 
            // lblPerso
            // 
            this.lblPerso.AutoSize = true;
            this.lblPerso.BackColor = System.Drawing.Color.Transparent;
            this.lblPerso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerso.ForeColor = System.Drawing.Color.White;
            this.lblPerso.Location = new System.Drawing.Point(56, 162);
            this.lblPerso.Name = "lblPerso";
            this.lblPerso.Size = new System.Drawing.Size(102, 21);
            this.lblPerso.TabIndex = 36;
            this.lblPerso.Text = "Personnage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "Star";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 29);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 41;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAnnul);
            this.groupBox1.Controls.Add(this.btnAjout);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtPerso);
            this.groupBox1.Controls.Add(this.lblPerso);
            this.groupBox1.Controls.Add(this.btnModifStar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAjtStar);
            this.groupBox1.Location = new System.Drawing.Point(308, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 287);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // btnAnnul
            // 
            this.btnAnnul.BackColor = System.Drawing.Color.Teal;
            this.btnAnnul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnul.Location = new System.Drawing.Point(386, 223);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(101, 33);
            this.btnAnnul.TabIndex = 42;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = false;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.Teal;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(279, 223);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(101, 33);
            this.btnAjout.TabIndex = 41;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // gestStars1
            // 
            this.gestStars1.BackColor = System.Drawing.Color.MintCream;
            this.gestStars1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gestStars1.BackgroundImage")));
            this.gestStars1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gestStars1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gestStars1.Location = new System.Drawing.Point(843, 357);
            this.gestStars1.Name = "gestStars1";
            this.gestStars1.Size = new System.Drawing.Size(58, 71);
            this.gestStars1.SlctStar = null;
            this.gestStars1.TabIndex = 39;
            // 
            // AjoutJouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::videoStar.Properties.Resources.darth_maul_1555343_1280;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gestStars1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.DoubleBuffered = true;
            this.Name = "AjoutJouer";
            this.Size = new System.Drawing.Size(1004, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjtStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModifStar;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPerso;
        private System.Windows.Forms.Label lblPerso;
        private System.Windows.Forms.Label label1;
        private star.GestStars gestStars1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnAjout;
    }
}
