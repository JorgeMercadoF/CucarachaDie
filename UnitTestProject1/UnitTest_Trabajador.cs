using Microsoft.VisualStudio.TestTools.UnitTesting;
using CucarachaDie.Empleados;
using System;

namespace UnitTest_Trabajador
{
    [TestClass]
    public class UnitTest_Trabajador
    {
        [TestMethod]
        public void TestConstructor_NombreVacio()
        {
            //Preparacion, Ejecucion y Resultado
            Trabajador T1 = new Trabajador("", "Peon", 1200.50);
        }

        [TestMethod]
        public void TestConstructor_RangoErroneo()
        {
            //Preparacion, Ejecucion y Resultado
            Trabajador T1 = new Trabajador("Pedro", "Martin", 1200.50);
        }

        [TestMethod]
        public void TestConstructor_RangoVacio()
        {
            //Preparacion, Ejecucion y Resultado
            Trabajador T1 = new Trabajador("Pedro", "", 1200.50);
        }

        [TestMethod]
        public void TestConstructor_SueldoNegativo()
        {
            //Preparacion, Ejecucion y Resultado
            Trabajador T1 = new Trabajador("Pedro", "Peon", -1200.50);
        }

        [TestMethod]
        public void TestConstructor_SueldoCero()
        {
            //Preparacion, Ejecucion y Resultado
            Trabajador T1 = new Trabajador("Pedro", "Peon", 0);
        }

        [TestMethod]
        public void TestConstructor_OK()
        {
            //Preparacion y Ejecucion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            double sueldo = T1.GetSueldo();

            //Resultado
            Console.Write("Se ha contratado a " + T1.GetNombre() + " como " + T1.GetRango() + " con un sueldo por servicio de " + sueldo + "€");
        }

        [TestMethod]
        public void TestSetNombre_Vacio()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion y Resultado
            T1.SetNombre("");
        }

        [TestMethod]
        public void TestSetNombre_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion
            T1.SetNombre("Pedro");
            string name = T1.GetNombre();

            //Resultado
            Assert.AreEqual("Jose", name, true, "Pedro no ha cambiado su nombre por Jose");
        }

        [TestMethod]
        public void TestSetNombre_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion
            T1.SetNombre("Jose");
            string name = T1.GetNombre();

            //Resultado
            Console.Write("Ahora Pedro se llama " + name);
        }

        [TestMethod]
        public void TestSetRango_Erroneo()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion y Resultado
            T1.SetRango("Especialista");
        }

        [TestMethod]
        public void TestSetRango_Vacio()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion y Resultado
            T1.SetRango("");
        }

        [TestMethod]
        public void TestSetRango_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion
            T1.SetRango("JefeEquipo");
            string rango = T1.GetRango();

            //Resultado
            Assert.AreEqual("Gerente", rango, true, "El rango esperado por Pedro era [Gerente]");
        }

        [TestMethod]
        public void TestSetRango_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion
            T1.SetRango("JefeEquipo");
            string rango = T1.GetRango();

            //Resultado
            Console.Write("El nuevo rango de Pedro es "+ rango);
        }

        [TestMethod]
        public void TestSetSueldoServ_SueldoNegativo()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion y Resultado
            T1.SetSueldo(-1200.50);
        }

        [TestMethod]
        public void TestSetSueldoServ_SueldoCero()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion y Resultado
            T1.SetSueldo(0);
        }

        [TestMethod]
        public void TestSetSueldoServ_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion
            T1.SetSueldo(1440.50);
            double sueldoServ = T1.GetSueldo();

            //Resultado
            Assert.AreEqual(1200.50, sueldoServ, 0.001, "Se esperaba un aumento del 20%");
        }

        [TestMethod]
        public void TestSetSueldoServ_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion
            T1.SetSueldo(1440.60);
            double sueldoServ = T1.GetSueldo();

            //Resultado
            Console.Write("El nuevo sueldo de Pedro es " + sueldoServ + "€ por servicio");
        }

        [TestMethod]
        public void TestGetNombre_FAIL()
        {

            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion         
            string nombre = T1.GetNombre();

            //Resultado 
            Assert.AreEqual("Juan", nombre, false, "Pedro se sigue llamando Pedro");
        }

        [TestMethod]
        public void TestGetNombre_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion         
            string nombre = T1.GetNombre();

            //Resultado 
            Console.Write("El nombre del trabajador es " + nombre);
        }

        [TestMethod]
        public void TestGetRango_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion         
            string rango = T1.GetRango();

            //Resultado 
            Assert.AreEqual("JefeEquipo", rango, false, "Pedro es Peon, no JefeEquipo");
        }

        [TestMethod]
        public void TestGetRango_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion         
            string rango = T1.GetRango();

            //Resultado 
            Console.Write("El rango " + T1.GetNombre() + " es " + T1.GetRango());
        }

        [TestMethod]
        public void TestGetSueldo_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion         
            double sueldo = T1.GetSueldo();

            //Resultado 
            Assert.AreEqual(1440.60, sueldo, 0.001, "Pedro sigue cobrando 1200.50€, no 1440.60€");
        }

        [TestMethod]
        public void TestGetSueldo_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);

            //Ejecucion        
            T1.SetSueldo(1440.60);
            double sueldo = T1.GetSueldo();

            //Resultado 
            Console.Write("El nuevo sueldo de " + T1.GetNombre() + " es " + sueldo + "€ por servicio");
        }
    }
}