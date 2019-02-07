using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CucarachaDie.Recursos;
using System;

namespace UnitTest_FactoriaRecursos
{
    [TestClass]
    public class UnitTest_Vehiculos
    {
        [TestMethod]
        public void TestCrearKangoo_0()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            vehiculos = factoria.CrearKangoo(0);
        }

        [TestMethod]
        public void TestCrearKangoo_Negativo()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            vehiculos = factoria.CrearKangoo(-5);
        }

        [TestMethod]
        public void TestCrearKangoo_OK()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion
            vehiculos = factoria.CrearKangoo(4);

            //Resultado
            double precio = 0;
            foreach (var elemento in vehiculos)
            {
                Console.Write("Se ha creado una " + elemento.GetNombreRecurso() + " por " + elemento.GetPrecioRecurso() + "€" + Environment.NewLine);
                precio += elemento.GetPrecioRecurso();
            }
            Console.Write("Se han creado un total de " + vehiculos.Count + " Furgonetas por un total de " + precio.ToString() + "€" + Environment.NewLine);
        }

        [TestMethod]
        public void TestCrearVehiculo_NoModelo()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            vehiculos = factoria.CrearVehiculo("", 10);
        }

        [TestMethod]
        public void TestCrearVehiculo_ModeloErroneo()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            vehiculos = factoria.CrearVehiculo("Vito", 10);
        }

        [TestMethod]
        public void TestCrearVehiculo_Cantidad0()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            vehiculos = factoria.CrearVehiculo("Sprinter", 0);
        }
        [TestMethod]
        public void TestCrearVehiculo_CantidadNegativa()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            vehiculos = factoria.CrearVehiculo("Sprinter", -10);
        }
        [TestMethod]
        public void TestCrearVehiculo_OK()
        {
            //Preparacion
            List<Vehiculos> vehiculos;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion
            vehiculos = factoria.CrearVehiculo("Sprinter", 10);

            //Resultado
            double precio = 0;
            foreach (var elemento in vehiculos)
            {
                Console.Write("Se ha creado un " + elemento.GetNombreRecurso() + " por " + elemento.GetPrecioRecurso() + "€" + Environment.NewLine);
                precio += elemento.GetPrecioRecurso();
            }
            Console.Write("Se han creado un total de " + vehiculos.Count + " Sprinter por " + precio.ToString() + "€" + Environment.NewLine);
        }
    }
}
