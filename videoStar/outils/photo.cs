using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.exeption.photoExeption;

namespace videoStar.outils
{
    public class Photo
    {
        private static List<String> expensions= new List<string>();
    

        public static Boolean VerifierPhoto(string[] files)
        {

            Boolean file=false;

            try
            {

               file= VerifPhoto(files);

            }

            catch(PhotoNbreFichierException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (PhotoFormatExeption e)
            {
                MessageBox.Show(e.Message);
            }

            return file;

        }






        private static Boolean VerifPhoto(string[] files)
        {
            Boolean file = false;

            if (files.Length > 1)
            {
                // MessageBox.Show("vous ne pouvez pas déposer plusieurs fichier");
                throw new PhotoNbreFichierException();
            }

                String[] elements = files[0].Split(new char[] { '\\', '.' });

                if (elements[elements.Length - 1].Equals("jpg", StringComparison.OrdinalIgnoreCase))
                {
                file = true;
                }
                else
                {
                    throw new PhotoFormatExeption(elements[elements.Length - 1]);
                }

                


            return file;
        }
    }
}
