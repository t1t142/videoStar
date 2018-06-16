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
        public eventClickDetail(Star st)
        {
            this.St = st;
        }
        private Star st;

        public Star St { get => st; set => st = value; }
    }
}
