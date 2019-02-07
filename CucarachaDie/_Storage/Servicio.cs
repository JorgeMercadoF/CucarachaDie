using System;
using System.Collections.Generic;
using System.Text;
                                    /* EN DESARROLLO */
namespace CucarachaDie.Servicios
{
    public class Servicio
    {
        string nombreServicio;
        float precio;

        public Servicio(string nombre, float precio)
        {
            this.nombreServicio = nombre;
            this.precio = precio;
        }

        public string DameNombreServicio()
        {
            return nombreServicio;
        }

        public float DamePrecioServicio()
        {
            return precio;
        }
    }
}
