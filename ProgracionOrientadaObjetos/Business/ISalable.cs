using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// L base de la arquitectura de software son la INTERFACES por que permiten catagorizar las clases 
//hay un problema de la herencia por que no podemos heredar de varias clases pero si podemos implementar varias interfaces
//las interfaces no pueden tener campos, ni constructores, ni propiedades auto implementadas
//contrato en el cual  estamos obligado a realizar cosas que estan dentro de la interfaz
//cuando trabajamos de arquitectura de software dependemos de abstracciones que es lo que hace, mas no como lo hace si vamos a cambiar
// no vamos a meter tanto codigo, las interfaces no pueden tener modificadores de acceso
// por que por defecto son publicas// no pueden tener implementacion
// no pueden tener constructores
// no pueden tener campos
// no pueden tener propiedades auto implementadas
// pueden tener propiedades con solo get y set
// pueden tener metodos sin cuerpo
// pueden tener eventos
// pueden tener indexadores
// no pueden tener destructores
// no pueden tener tipos anidados
// no pueden tener operadores
// no pueden tener constantes
//  pueden heredar de otras interfaces
//  pueden ser heredadas por clases y estructuras
//  pueden ser implementadas por clases y estructuras
//  pueden ser implementadas por otras interfaces
//  pueden ser implementadas por clases abstractas
//  pueden ser implementadas por clases selladas
//  pueden ser implementadas por clases parciales
//  pueden ser implementadas por clases genéricas
//  pueden ser implementadas por clases estáticas
//  pueden ser implementadas por clases anidadas
//  pueden ser implementadas por clases derivadas
//  pueden ser implementadas por clases base
//  pueden ser implementadas por clases que implementan otras interfaces
//  pueden ser implementadas por clases que heredan de otras clases
//  pueden ser implementadas por clases que heredan de otras interfaces
//  pueden ser implementadas por clases que heredan de otras clases e interfaces
//  pueden ser implementadas por clases que heredan de otras clases e interfaces y que implementan otras interfaces
//  pueden ser implementadas por clases que heredan de otras clases e interfaces y que implementan otras interfaces y que tienen otros miembros

namespace ProgracionOrientadaObjetos.Business
{
    public interface ISalable
    {
        public decimal GetPrice(); // metodo sin cuerpo
    }

}