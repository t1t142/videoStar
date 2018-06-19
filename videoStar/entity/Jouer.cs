using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.entity
{
   public class Jouer
    {
        private Document doc;
        private Star star;
        private Role role;
        private String personnage;

        public Star Star { get => star; set => star = value; }
        public Role Role { get => role; set => role = value; }
        public string Personnage { get => personnage; set => personnage = value; }
        internal Document Doc { get => doc; set => doc = value; }

        public Jouer()
        {
        }
    }







}
