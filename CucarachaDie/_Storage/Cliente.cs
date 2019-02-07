using System;
using System.Collections.Generic;
using System.Text;
                                    /* EN DESARROLLO */  
namespace CucarachaDie.Clientes
{
    public class Cliente
    {
        string nombre;
        string telefono;
        string email;
        string codPostal;

        public Cliente (string nombre, string telefono, string email, string codPostal)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
            this.codPostal = codPostal;
        }

        public string DameNombre()
        {
            return nombre;
        }

        public string DameTelefono()
        {
            return telefono;
        }

        public string DameMail()
        {
            return email;
        }

        public string DameCodPostal()
        {
            return codPostal;
        }
    }
}
