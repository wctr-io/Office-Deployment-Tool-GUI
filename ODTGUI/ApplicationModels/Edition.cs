using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODTGUI.ApplicationModels
{
    public class Edition: IdNamePair<int, string>
    {
        public string EditionDisplayName { get { return $"{Id}-bit"; } }
    }
}
