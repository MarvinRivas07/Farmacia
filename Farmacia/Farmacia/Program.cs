using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bienvenidos a farmacia MARVIN \n");
            Console.WriteLine("En que le podemos ayudar... \n");
            Console.WriteLine("Opciones \n1-Comprar Medicina  \n2-Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    Console.WriteLine("Bienvenido...");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    enfermedad enfer = new enfermedad();
                    enfer.Datos();
                    enfer.tiposEnfermedades();
                    break;
                    default:
                    Console.WriteLine("Opcion no valida...");
                    break; 
            }
        }
       
    }
}
