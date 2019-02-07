using System;
using System.Collections.Generic;
using System.Text;

namespace CucarachaDie.Empleados
{
    public class Trabajador : ITrabajador
    {
        //Atributos
        readonly string[] rangos = { "Peon", "JefeEquipo", "Gerente" };
        private string nombre;
        private string rango;
        private double sueldoServicio;

        //Constructor
        public Trabajador (string nombre, string rango, double sueldo)
        {
            if (nombre.Equals(""))
            {
                throw new Exception("Se debe informar el Nombre del Trabajador");
            }
            else
            {
                if(!Array.Exists(rangos, element => element == rango))
                {
                    throw new Exception("Los Rangos asignables al Trabajador son [Peon, JefeEquipo, Gerente]");
                }
                else
                {
                    if (sueldo.Equals(0) || sueldo < 0)
                    {
                        throw new Exception("El Sueldo del Trabajador ha de ser superior a cero");
                    }
                    else
                    {
                        this.nombre = nombre;
                        this.rango = rango;
                        this.sueldoServicio = sueldo;
                    }
                }
            }
        }

        //Setters
        public void SetNombre(string nombre)
        {
            if (nombre == "")
            {
                throw new Exception("Se debe informar el Nombre");
            }
            else
            {
                this.nombre = nombre;
            }
            
        }
        public void SetRango(string rango)
        {
            if (!Array.Exists(rangos, element => element == rango))
            {
                throw new Exception("Los Rangos regsitrados son [Peon, JefeEquipo, Gerente]");
            }
            else
            {
                this.rango = rango;
            }
        }
        public void SetSueldo(double sueldo)
        {
            if (sueldo.Equals(0) || sueldo < 0)
            {
                throw new Exception("El Sueldo ha de ser superior a cero");
            }
            else
            {
                this.sueldoServicio = sueldo;
            }
        }

        //Métodos de la Interfaz
        public string GetNombre()
        {
            return nombre;
        }

        public string GetRango()
        {
            return rango;
        }

        public double GetSueldo()
        {
            return sueldoServicio;
        }
    }
}
