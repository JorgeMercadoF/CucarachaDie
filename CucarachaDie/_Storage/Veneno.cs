using System;
using System.Collections.Generic;
using System.Text;
                                    /* EN DESARROLLO */
namespace CucarachaDie.Recursos
{
    //public class Veneno: IRecurso 
    public class Veneno
    {
        string nombre;
        float unidadMedida;
        float costePorGramo;

        public Veneno(string nombre, float medida, float coste)
        {
            this.nombre = nombre;
            this.unidadMedida = medida;
            this.costePorGramo = coste;
        }

        public string DameNombre()
        {
            return nombre;
        }

        public float DameMedida()
        {
            return unidadMedida;
        }

        public float DameCoste()
        {
            return costePorGramo;
        }
    }
}
