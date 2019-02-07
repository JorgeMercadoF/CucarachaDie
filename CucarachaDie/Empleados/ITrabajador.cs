using System;
using System.Collections.Generic;
using System.Text;

namespace CucarachaDie.Empleados
{
    public interface ITrabajador
    {
        //Métodos a implementar en las clases de esta Interfaz
        string GetNombre();
        string GetRango();
        double GetSueldo();
    }
}
