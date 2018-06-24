using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.exeption.photoExeption 
{
    public class PhotoNbreFichierException : Exception
    {
 
        public PhotoNbreFichierException()
        : base("le programme ne gère qu'un fichier par dépot")
        {


        }



    }
}
