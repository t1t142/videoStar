using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar
{
    class Pays
    {
        int id;
        String libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Pays(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
    }
}
