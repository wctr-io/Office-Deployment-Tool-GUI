using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODTGUI.ApplicationModels
{
    public abstract class IdNamePair<Tid, Tname>
    {
        public Tid Id { get; set; }
        public Tname Name { get; set; }
    }
}
