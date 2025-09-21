using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Beer : Drink, ISalable ,ISend // aki implementamos la interfaz, pero me da error por que la interfaz tiene un metodo que no esta implementado
    { // podemos tener varias clasee clasificadas siginifica que aparte de vendibles es enviable
        private const string  Category = "Cerveza"; // campo constante
        private decimal _alcohol; // soin campos
        public string Name { get; set; } // Propiedades

        public string Price { get; set; }
        


        public decimal Alcohol
        {
            get { return _alcohol; } // podemos hacer una evalucion antes
            // de asignar a un atributo.
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        } // Propiedad con validacion

         public string SAlcohol
        {
            get { return $" Alcohol    {_alcohol}%"; }
        }

        //Sobrecarga de metodos, podemos tener varios metodos con el mismo nombre pero con diferente firma o diferente parametro 
        
        public virtual string GetInfo() // Estos si se puede sobreescribir en las clases hijas  por que tiene virtual
        // tambiene es importante qu no debe tener parametros 
        {
            return "Nombre:" + Name +  ", Precio" + Price + "Alchol" + Alcohol 
            ;
        }

        public string getInfo(string message)
        {
            return   message  + " " + GetInfo();
        }
        // metodo contructor 

        public Beer(string nombre, decimal price, decimal alcohol,  int quantity)
            : base(quantity) // llamamos al constructor de la clase base , por que revuerda que esto es del padre 
        {
            this.Name = nombre;
            this.Price = price.ToString();
            Alcohol = alcohol; // llamamos a la propiedad
        }
      
        public override string GetCategory()
        {
            return Category;
        }
        public decimal GetPrice() {  // implementamos el metodo de la interfaz , des esta manera ya no da error y ademas sabemos que vamos a buscar un precio pero no que es lo que va hacer
            return decimal.Parse(Price);
        }
        public void Send() // implementamos el metodo de la interfaz
        {
            Console.WriteLine($" Se envia por correo" +  GetInfo());
        }


    }
}