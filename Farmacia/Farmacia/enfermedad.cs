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
            Cliente cliente = new Cliente();
            Console.WriteLine("Que tipo de enfermedad presenta: \n1-Gripe y tos \n2-Diarrea \n3-Quemaduras \n4-Dolor de garganta ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo="Gripe y tos";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.gripeyTos(medi.TEnfermedad,medi.TPrecio);
                    Console.WriteLine(medi.MostrarGP());
                    Console.WriteLine("PRECIO:"+medi.TPrecio);
                    break;
                case 2:
                    tipo = "Diarrea";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.diarrea(medi.TDiarrea,medi.TPrecio1);
                    Console.WriteLine(medi.MostrarD());
                    Console.WriteLine("PRECIO:" + medi.TPrecio1);
                    break;
                case 3:
                    tipo = "Quemaduras";
                    Console.WriteLine("Si las" + " " + tipo + " " + "son leves pueden ser tratadas con las siguientes cremas:");
                    medi.quemadura(medi.TQuemadura,medi.TPrecio2);
                    Console.WriteLine(medi.MostrarQ());
                    Console.WriteLine("PRECIO:" + medi.TPrecio2);
                    break;
                case 4:
                    tipo = "Dolor de garganta ";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.dGarganta(medi.TGarganta,medi.TPrecio3);
                    Console.WriteLine(medi.MostrarG());
                    Console.WriteLine("PRECIO:" + medi.TPrecio3);
                    break;

                

               
            }
        }
        
    }
}
