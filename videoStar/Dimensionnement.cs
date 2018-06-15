using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar
{
    public class Dimensionnement
    {

public static void Dimensionner(Control ctl,int inix,int iniy,Boolean tailleParent,int width,int height)
        {

          
           // MessageBox.Show(ctl.Name);

            ctl.Location = new System.Drawing.Point(inix, iniy);

           // MessageBox.Show(ctl.Location.ToString());

            if (tailleParent)
            {
                ctl.Size = ctl.Parent.Size;
            }
           else
            {
                ctl.Size = new Size(width,height) ;
            }
            //MessageBox.Show(ctl.Size.ToString());
            ctl.Show();
            ctl.BringToFront();

        }









    }
}
