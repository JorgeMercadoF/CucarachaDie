using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CucarachaDie.Recursos;
using System;

namespace UnitTest_FactoriaRecursos
{
    [TestClass]
    public class UnitTest_Materiales
    {
        [TestMethod]
        public void TestCrearMascarillas_0()
        {
            //Preparacion
            List<Materiales> mascarillas;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            mascarillas = factoria.CrearMascarillas(0);
        }

        [TestMethod]
        public void TestCrearMascarillas_Negativo()
        {
            //Preparacion
            List<Materiales> mascarillas;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            mascarillas = factoria.CrearMascarillas(-5);
        }

        [TestMethod]
        public void TestCrearMascarillas_OK()
        {
            //Preparacion
            List<Materiales> mascarillas;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion
            mascarillas = factoria.CrearMascarillas(4);

            //Resultado
            double precio = 0;
            foreach(var elemento in mascarillas)
            {
                Console.Write("Se ha creado una " + elemento.GetNombreRecurso() + " por " + elemento.GetPrecioRecurso() + "€" + Environment.NewLine);
                precio += elemento.GetPrecioRecurso();
            }
            Console.Write("Se han creado un total de " + mascarillas.Count + " Mascarillas por un total de " + precio.ToString() + "€" +Environment.NewLine);
        }

        [TestMethod]
        public void TestCrearMaterial_NoMaterial()
        {
            //Preparacion
            List<Materiales> materiales;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            materiales = factoria.CrearMaterial("", 10);
        }

        [TestMethod]
        public void TestCrearMaterial_MaterialErroneo()
        {
            //Preparacion
            List<Materiales> materiales;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            materiales = factoria.CrearMaterial("Casco", 10);
        }

        [TestMethod]
        public void TestCrearMaterial_Cantidad0()
        {
            //Preparacion
            List<Materiales> materiales;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            materiales = factoria.CrearMaterial("Guantes", 0);
        }
        [TestMethod]
        public void TestCrearMaterial_CantidadNegativa()
        {
            //Preparacion
            List<Materiales> materiales;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion y Resultado
            materiales = factoria.CrearMaterial("Guantes", -10);
        }
        [TestMethod]
        public void TestCrearMaterial_OK()
        {
            //Preparacion
            List<Materiales> materiales;
            FactoriaRecursos factoria = new FactoriaRecursos();

            //Ejecucion
            materiales = factoria.CrearMaterial("Guantes", 10);

            //Resultado
            double precio = 0;
            foreach (var elemento in materiales)
            {
                Console.Write("Se ha creado un " + elemento.GetNombreRecurso() + " por " + elemento.GetPrecioRecurso() + "€" + Environment.NewLine);
                precio += elemento.GetPrecioRecurso();
            }
            Console.Write("Se han creado un total de " + materiales.Count + " Guantes por " + precio.ToString() + "€" + Environment.NewLine);
        }
    }
}
