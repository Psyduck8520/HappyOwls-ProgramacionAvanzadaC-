using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface Ishow<in T>
    {
        public void Show(T element);  //podemos tener aki contravarianza tenemos el tipo como un parametro de la función

    }
}
