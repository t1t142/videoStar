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
            this.gestionville1 = new videoStar.gestionville();
            this.detailVille1 = new videoStar.detailVille();
            this.SuspendLayout();
            // 
            // gestionville1
            // 
            this.gestionville1.Location = new System.Drawing.Point(12, 12);
            this.gestionville1.Name = "gestionville1";
            this.gestionville1.Size = new System.Drawing.Size(1203, 742);
            this.gestionville1.TabIndex = 0;
            // 
            // detailVille1
            // 
            this.detailVille1.Location = new System.Drawing.Point(121, 34);
            this.detailVille1.Name = "detailVille1";
            this.detailVille1.Size = new System.Drawing.Size(503, 387);
            this.detailVille1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 783);
            this.Controls.Add(this.detailVille1);
            this.Controls.Add(this.gestionville1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private gestionville gestionville1;
        private conteneurItem conteneurItem1;
        private detailVille detailVille1;
    }
}