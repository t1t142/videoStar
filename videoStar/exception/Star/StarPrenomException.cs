using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.exception.Star
{
   public class StarPrenomException :Exception
    {
        public StarPrenomException()
      : base("le prénom ne peut pas etre vide")
        {


        }
    }
}
