using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Clock
    {
        private DateTime  _date;
        public DateTime date  =>  _date; // propiedad de solo lectura que devuelve la fecha y hora actual
        
        public Clock()
        {
            _date = DateTime.Now; // inicializamos la fecha y hora actual
        }

    }
}
