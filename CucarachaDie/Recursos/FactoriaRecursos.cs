using System;
using System.Collections.Generic;
using System.Text;

namespace CucarachaDie.Recursos
{
    public class FactoriaRecursos
    {
        // Atributos
        private List<Materiales> materiales = new List<Materiales>();
        private List<Vehiculos> vehiculos = new List<Vehiculos>();

        //Constructor
        public FactoriaRecursos(){}

        //Factoria
        public List<Materiales> CrearMascarillas(int cantidad)
        {
            if(cantidad.Equals(0)|| cantidad < 0)
            {
                throw new Exception("La cantidad a fabricar ha de ser superior a 0");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    materiales.Add(new Materiales("Mascarilla", 10.00));
                }
                return materiales;
            }
        }
        public List<Materiales> CrearGafas(int cantidad)
        {
            if (cantidad.Equals(0) || cantidad < 0)
            {
                throw new Exception("La cantidad a fabricar ha de ser superior a 0");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    materiales.Add(new Materiales("Gafas", 20.00));
                }
                return materiales;
            }
        }
        public List<Materiales> CrearGuantes(int cantidad)
        {
            if (cantidad.Equals(0) || cantidad < 0)
            {
                throw new Exception("La cantidad a fabricar ha de ser superior a 0");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    materiales.Add(new Materiales("Guantes", 20.00));
                }
                return materiales;
            }
        }
        public List<Vehiculos> CrearKangoo(int cantidad)
        {
            if (cantidad.Equals(0) || cantidad < 0)
            {
                throw new Exception("La cantidad a fabricar ha de ser superior a 0");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    vehiculos.Add(new Vehiculos("Renault", "Kangoo", 5, 10345.52));
                }
                return vehiculos;
            }
        }
        public List<Vehiculos> CrearSprinter(int cantidad)
        {
            if (cantidad.Equals(0) || cantidad < 0)
            {
                throw new Exception("La cantidad a fabricar ha de ser superior a 0");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    vehiculos.Add(new Vehiculos("Mercedes", "Sprinter", 5, 25450.18));
                }
                return vehiculos;
            }
        }
        public List<Materiales> CrearMaterial(string nombre, int cantidad)
        {
            if (nombre.Equals(""))
            {
                throw new Exception("Se debe informar el nombre del material a crear");
            }
            else
            {
                if(cantidad.Equals(0) || cantidad < 0)
                {
                    throw new Exception("La cantidad de materiales a crear debe ser superior a 0");
                }
                else
                {
                    switch (nombre)
                    {
                        case "Mascarilla":
                            for (int i = 0; i < cantidad; i++)
                            {
                                materiales.Add(new Materiales("Mascarilla", 10.00));
                            }
                            break;
                        case "Gafas":
                            for (int i = 0; i < cantidad; i++)
                            {
                                materiales.Add(new Materiales("Gafas", 20.00));
                            }
                            break;
                        case "Guantes":
                            for (int i = 0; i < cantidad; i++)
                            {
                                materiales.Add(new Materiales("Guantes", 20.00));
                            }
                            break;
                        default:
                            throw new Exception("Los materiales posibles son [Mascarilla] [Gafas] [Guantes]");
                    }
                    return materiales;
                }
            }
        }
        public List<Vehiculos> CrearVehiculo(string modelo, int cantidad)
        {
            if (modelo.Equals(""))
            {
                throw new Exception("Se debe informar la marca del vehiculo a crear");
            }
            else
            {
                if (cantidad.Equals(0) || cantidad < 0)
                {
                    throw new Exception("La cantidad de vehiculos a crear debe ser superior a 0");
                }
                else
                {
                    switch (modelo)
                    {
                        case "Kangoo":
                            for (int i = 0; i < cantidad; i++)
                            {
                                vehiculos.Add(new Vehiculos("Renault", "Kangoo", 5, 10345.52));
                            }
                            break;
                        case "Sprinter":
                            for (int i = 0; i < cantidad; i++)
                            {
                                vehiculos.Add(new Vehiculos("Mercedes", "Sprinter", 5, 25450.18));
                            }
                            break;
                        default:
                            throw new Exception("Los vehiculos posibles son [Kangoo] [Sprinter]");
                    }
                    return vehiculos;
                }
            }
        }
    }
}
