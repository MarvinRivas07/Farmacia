﻿using System;
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
                    medi.gripeyTos(medi.TEnfermedad);
                    Console.WriteLine(medi.MostrarGP());
                    break;
                case 2:
                    tipo = "Diarrea";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.diarrea(medi.TDiarrea);
                    Console.WriteLine(medi.MostrarD());
                    break;
                case 3:
                    tipo = "Quemaduras";
                    Console.WriteLine("Si las" + " " + tipo + " " + "son leves pueden ser tratadas con las siguientes cremas:");
                    medi.quemadura(medi.TQuemadura);
                    Console.WriteLine(medi.MostrarQ());
                    break;
                case 4:
                    tipo = "Dolor de garganta ";
                    Console.WriteLine("La enfermedad que uste tiene " + " " + tipo + " " + "puede ser tratada con los siguientes medicamentos:");
                    medi.dGarganta(medi.TGarganta);
                    Console.WriteLine(medi.MostrarG());
                   
                    break;

               
            }
        }
        
    }
}
