using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.exeption.photoExeption
{
   public class PhotoFormatExeption : Exception
    {
        public PhotoFormatExeption(string exp)
: base("l'expension ."+exp+" n'est pas gérer. Seul le format .JEPG est accepté")
        {


        }

    }
}
