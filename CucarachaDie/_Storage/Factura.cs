using System;
using System.Collections.Generic;
using System.Text;
using CucarachaDie.Clientes;
using CucarachaDie.Servicios;
using CucarachaDie.Empleados;
                                    /* EN DESARROLLO */
namespace CucarachaDie.Facturas
{
    public class Factura
    {
        Cliente cliente;
        List<Servicio> servicios;
        float precio = 0;

        public Factura (Cliente c, List<Servicio> s)
        {
            this.cliente = c;
            this.servicios = s;
        }

        public float DameFactura()
        {
            foreach (var serv in servicios)
            {
                precio = precio + serv.DamePrecioServicio();
            }
            return precio;
        }
    }
}
