using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.entity
{
    class Star
    {
        int id;
        String nom;
        String prenom;
        DateTime  datenaisance;
        Pays paysOrigine;
        string photo;
        List<Document> aTournerDans;
        List<Document> aRealise;
        List<Document> aCompose;
    }
}
 