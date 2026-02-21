using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface Iinfo
    {
        public String GetInfo();  // debe estar obligada a tener este metodo
                                  // , pero cada clase que implemente
                                  // esta interfaz lo va a implementar de diferente manera
    }
}
