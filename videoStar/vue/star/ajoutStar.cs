using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace videoStar.vue.star
{
    public partial class ajoutStar : UserControl
    {
        public ajoutStar()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox1.ImageLocation = @"D:\image\drag-drop-upload-1.gif";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                MessageBox.Show(file);
               
                String[] elements = file.Split(new char[] {'\\', '.' });
                foreach (string element in elements)
                {
                    MessageBox.Show(element);
                }

                pictureBox1.ImageLocation = file;
                textBox3.Text = file;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
