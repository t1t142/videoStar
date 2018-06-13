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
using videoStar.entity;

namespace videoStar.vue.star
{
    public partial class ajoutStar : UserControl
    {
        public ajoutStar()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox1.ImageLocation = @"D:\image\drag-drop-upload-1.gif";
            label1.BackColor = System.Drawing.Color.Transparent;
            comboBox1.DroppedDown = true;

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            this.Hide();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length >= 2 && comboBox1.Text.Length <= 4)
            {
                string rech = comboBox1.Text;

                List<Pays> pays = Pays.GetPaysByName(comboBox1.Text,1,20);

                comboBox1.Items.Clear();
                foreach ( Pays unPays in pays)
                {
                   
                    comboBox1.Items.Add(unPays.Libelle);



                }
                comboBox1.DroppedDown = true;
                comboBox1.Select(comboBox1.Text.Length, 0);
                // comboBox1.Text = comboBox1.Text;
            }

        }

        
       
          
       

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Star st = new Star( textBox1.Text, textBox2.Text, dateTimePicker1.Value, comboBox1.Text);

            st.Photo = textBox3.Text;
            Star.InsertStar(st);

        }
    }
}
