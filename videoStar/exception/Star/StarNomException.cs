using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.exception.Star
{
  public  class StarNomException :Exception
    {
        public StarNomException()
        : base("le nom ne peut pas etre vide")
        {


        }


    }
}
