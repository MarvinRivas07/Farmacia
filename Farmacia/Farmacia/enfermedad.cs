using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class enfermedad
    {

        public string tipo;

        public void tiposEnfermedades()
        {
            medicamentos medi = new medicamentos(); 
            Console.WriteLine("Que tipo de enfermedad presenta: \n1-Gripe y tos \n2-Diarrea \n3-Quemaduras \n4-Dolor de garganta ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo="Gripe y tos";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.gripeyTos();
                    break;
                case 2:
                    tipo = "Diarrea";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.diarrea();
                    break;
                case 3:
                    tipo = "Quemaduras";
                    Console.WriteLine("Si las" + " " + tipo + " " + "son leves pueden ser tratadas con las siguientes cremas:");
                    medi.quemadura();
                    break;
                case 4:
                    tipo = "Dolor de garganta ";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.dGarganta();
                    break;

               
            }
        }
        public string nombre;
        public string apellido;
        public void Datos()
        {
            Console.WriteLine("Su nombre por favor:");
            nombre = Console.ReadLine();
            Console.WriteLine("Su apellido:");
            apellido = Console.ReadLine();

        }
    }
}
