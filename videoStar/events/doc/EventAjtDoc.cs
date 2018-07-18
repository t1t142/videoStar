using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videoStar.entity;

namespace videoStar.events
{
   public class EventAjtDoc: EventArgs
    {
        public EventAjtDoc(Document doc)
        {
            this.Doc = doc;
        }
        private Document doc;

        public Document Doc { get => doc; set => doc = value; }
    }
}



