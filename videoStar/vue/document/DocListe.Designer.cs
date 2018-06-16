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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ajoutDoc1
            // 
            this.ajoutDoc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutDoc1.BackgroundImage")));
            this.ajoutDoc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajoutDoc1.Location = new System.Drawing.Point(260, 342);
            this.ajoutDoc1.Name = "ajoutDoc1";
            this.ajoutDoc1.Size = new System.Drawing.Size(276, 159);
            this.ajoutDoc1.TabIndex = 23;
            // 
            // DocListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::videoStar.Properties.Resources.sci_fi_3233076_1920;
            this.Controls.Add(this.ajoutDoc1);
            this.Controls.Add(this.button1);
            this.Name = "DocListe";
            this.Size = new System.Drawing.Size(909, 682);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AjoutDoc ajoutDoc1;
    }
}
