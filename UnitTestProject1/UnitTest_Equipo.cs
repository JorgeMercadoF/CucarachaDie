using CucarachaDie.Empleados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_Trabajador
{
    [TestClass]
    public class UnitTest_Equipo
    {
        [TestMethod]
        public void TestConstructor_NombreEquipoVacio()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);

            //Ejecucion y Resultado
            Equipo E1 = new Equipo(miembrosEquipo, "");
        }

        [TestMethod]
        public void TestConstructor_EquipoVacio()
        {
            //Preparacion
            Trabajador[] miembrosEquipo = new Trabajador[0];

            //Ejecucion y Resultado
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");
        }

        [TestMethod]
        public void TestConstructor_EquipoSobredimensionado()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador T5 = new Trabajador("Francisco", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[5];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            miembrosEquipo.SetValue(T5, 4);

            //Ejecucion y Resultado
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");
        }

        [TestMethod]
        public void TestConstructor_RangosNoValidos()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T6 = new Trabajador("Roberto", "Peon", 1200.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T6, 3);

            //Ejecucion y Resultado
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");
        }

        [TestMethod]
        public void TestConstructor_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);

            //Ejecucion
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");
            double sueldoEquipo = E1.GetSueldo();

            //Resultado
            Console.Write("Se ha creado el equipo " + E1.GetNombre() + " con un coste por servicio de " + sueldoEquipo + "€");
        }

        [TestMethod]
        public void TestSetNombreEquipo_Vacio()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion y Resultado
            E1.SetNombreEquipo("");
        }

        [TestMethod]
        public void TestSetNombreEquipo_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion
            E1.SetNombreEquipo("E.Cucaracha");
            string nombreEquipo = E1.GetNombre();

            //Resultado 
            Assert.AreEqual("E.Rata", nombreEquipo, false, "El nombre del equipo deberia ser E.Rata");
        }

        [TestMethod]
        public void TestSetNombreEquipo_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            E1.SetNombreEquipo("E.Cucaracha");
            string nombreEquipo = E1.GetNombre();

            //Resultado 
            Console.Write("El equipo E.Rata ahora se llama " + E1.GetNombre());
        }

        [TestMethod]
        public void TestGetNombre_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            string nombreEquipo = E1.GetNombre();

            //Resultado 
            Assert.AreEqual("E.Cucaracha", nombreEquipo, false, "E.Rata no ha cambiado el nombre a E.Cucaracha");
        }

        [TestMethod]
        public void TestGetNombre_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            E1.SetNombreEquipo("E.Cucaracha");
            string nombreEquipo = E1.GetNombre();

            //Resultado 
            Console.Write("El Equipo E.Rata ha cambiado su nombre por " + E1.GetNombre());
        }

        [TestMethod]
        public void TestGetRango_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            string rangoEquipo = E1.GetRango();

            //Resultado 
            Assert.AreEqual("Peon / Peon / Peon / Peon", rangoEquipo, false, "No esta permitido crear un equipo solo de Peones");
        }

        [TestMethod]
        public void TestGetRango_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            string rangoEquipo = E1.GetRango();

            //Resultado 
            Console.Write("El equipo " + E1.GetNombre() + " consta de los siguientes rangos: " + E1.GetRango());
        }

        [TestMethod]
        public void TestGetSueldo_FAIL()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            double sueldoEquipo = E1.GetSueldo();

            //Resultado 
            Assert.AreEqual(3250.02, sueldoEquipo, 0.001, "El equipo no esta cobrando lo establecido");
        }

        [TestMethod]
        public void TestGetSueldo_OK()
        {
            //Preparacion
            Trabajador T1 = new Trabajador("Pedro", "Peon", 1200.50);
            Trabajador T2 = new Trabajador("Pablo", "Peon", 1200.50);
            Trabajador T3 = new Trabajador("Manolo", "Peon", 1200.50);
            Trabajador T4 = new Trabajador("Rodrigo", "JefeEquipo", 1600.50);
            Trabajador[] miembrosEquipo = new Trabajador[4];
            miembrosEquipo.SetValue(T1, 0);
            miembrosEquipo.SetValue(T2, 1);
            miembrosEquipo.SetValue(T3, 2);
            miembrosEquipo.SetValue(T4, 3);
            Equipo E1 = new Equipo(miembrosEquipo, "E.Rata");

            //Ejecucion         
            double sueldoEquipo = E1.GetSueldo();

            //Resultado 
            Console.Write("El equipo " + E1.GetNombre() + " tiene un coste por servicio de " + sueldoEquipo + "€");
        }
    }
}