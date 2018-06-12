using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar
{
    public class eventClickDetail : EventArgs
    
    {
        public eventClickDetail(string id)
        {
            this.Id = id;
        }
        private string id;

        public string Id { get => id; set => id = value; }
    }
}
