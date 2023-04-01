using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class Cliente
    {
        public string nombre;
        public string apellido;
        public void Datos()
        {
            Console.WriteLine("Su nombre por favor:");
            nombre = Console.ReadLine();
            Console.WriteLine("Su apellido:");
            apellido = Console.ReadLine();

        }
        public String Ver()
        {

            return "DATOS DEL CLIENTE:\nNombre:" + nombre + "   " + "\nApellido:" + apellido + "  ";
        }

    }
}
