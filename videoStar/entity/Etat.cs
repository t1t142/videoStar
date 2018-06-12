using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.entity
{
    class Etat
    {
        int id;
        String libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Etat(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
    }
}
