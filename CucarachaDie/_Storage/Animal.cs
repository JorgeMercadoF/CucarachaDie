using System;
using System.Collections.Generic;
using System.Text;
                                    /* EN DESARROLLO */
namespace CucarachaDie.Recursos
{
    public class Animal
    {
        string nombre;
        List<Veneno> veneno;

        public Animal(string nombre, List<Veneno> poison)
        {
            this.nombre = nombre;
            this.veneno = poison;
        }

        public string DameNombreAnimal()
        {
            return nombre;
        }

        public List<Veneno> DameVenenoAnimal()
        {
            return veneno;
        }
    }
}
