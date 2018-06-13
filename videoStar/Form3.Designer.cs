namespace videoStar
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.star1 = new videoStar.vue.star.star();
            this.star2 = new videoStar.vue.star.star();
            this.star3 = new videoStar.vue.star.star();
            this.star4 = new videoStar.vue.star.star();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 663);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::videoStar.Properties.Resources.tunnel_3233082_1920;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.star4);
            this.panel2.Controls.Add(this.star3);
            this.panel2.Controls.Add(this.star2);
            this.panel2.Controls.Add(this.star1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 663);
            this.panel2.TabIndex = 1;
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.star1.Location = new System.Drawing.Point(66, 71);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(190, 278);
            this.star1.TabIndex = 0;
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.star2.Location = new System.Drawing.Point(303, 71);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(190, 278);
            this.star2.TabIndex = 1;
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.star3.Location = new System.Drawing.Point(522, 71);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(190, 278);
            this.star3.TabIndex = 2;
            // 
            // star4
            // 
            this.star4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.star4.Location = new System.Drawing.Point(75, 373);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(190, 278);
            this.star4.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private vue.star.star star3;
        private vue.star.star star2;
        private vue.star.star star1;
        private vue.star.star star4;
    }
}