using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videoStar.entity;

namespace videoStar
{
    public class eventClickDetail : EventArgs
    
    {
        private Star st;
        private string name;


        public Star St { get => st; set => st = value; }
        public string Name { get => name; set => name = value; }

        public eventClickDetail(string name,Star st)
        {
            this.St = st;
            this.Name = name;
        }
        
    }
}
