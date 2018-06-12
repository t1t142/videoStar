using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar
{
    class CodePostal
    {
        int id;
        String libelle;
        int idPays;

        

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int IdPays { get => idPays; set => idPays = value; }


        public CodePostal(int id, string libelle, int idPays)
        {
            this.id = id;
            this.libelle = libelle;
            this.idPays = idPays;
        }








    }
}
