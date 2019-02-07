using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CucarachaDie.Empleados
{
    public class Equipo : ITrabajador
    {
        //Atributos
        readonly static int numTrabajadoresEquipo = 4;
        readonly int numPeonesEquipo = 3;
        readonly int numJefesEquipo = 1;
        readonly string[] rangos = { "Peon", "JefeEquipo", "Gerente" };
        private Trabajador[] equipo = new Trabajador[numTrabajadoresEquipo];
        private string nombreEquipo;
        private double sueldoEquipo;
        private string rangosEquipo;

        //Constructor
        public Equipo(Trabajador[] equipo, string nombre)
        {
            if (nombre == "")
            {
                throw new Exception("Se debe informar el Nombre del Equipo");
            }
            else
            {
                if (!equipo.Any())
                {
                    throw new Exception("No se puede formar un equipo si no tiene trabajadores");
                }
                else
                {
                    int contPeon = 0;
                    int contJefe = 0;
                    foreach (var worker in equipo)
                    {
                        if (worker.GetRango() == rangos[0])
                        {
                            contPeon++;
                        }
                        if (worker.GetRango() == rangos[1])
                        {
                            contJefe++;
                        }
                    }
                    if (equipo.Length != numTrabajadoresEquipo || ((contPeon != numPeonesEquipo) && (contJefe != numJefesEquipo)))
                    {
                        throw new Exception("Los equipos deben estar formados por 1 Jefe de equipo y 3 Peones");
                    }
                    else
                    {
                        this.equipo = equipo;
                        this.nombreEquipo = nombre;
                    }
                }
            }
        }

        //Setters
        public void SetNombreEquipo(string nombre)
        {
            if (nombre == "")
            {
                throw new Exception("Se debe informar el Nombre del Equipo");
            }
            else
            {
                this.nombreEquipo  = nombre;
            }
        }

        //Métodos de la Interfaz
        public string GetNombre()
        {
            return nombreEquipo;
        }

        public string GetRango()
        {
            foreach (var trabajador in equipo)
            {
                rangosEquipo += trabajador.GetRango () + " / ";
            }
            return rangosEquipo.Substring(0, 31);
        }

        public double GetSueldo()
        {
            foreach (var trabajador in equipo)
            {
                sueldoEquipo += trabajador.GetSueldo (); 
            }
            return sueldoEquipo;
        }
    }
}
