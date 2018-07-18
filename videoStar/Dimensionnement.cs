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

          
            ctl.Location = new System.Drawing.Point(inix, iniy);

           
            if (tailleParent)
            {
                ctl.Size = ctl.Parent.Size;
            }
           else
            {
                ctl.Size = new Size(width,height) ;
            }
          
            ctl.Show();
            ctl.BringToFront();
        }

    }
}
