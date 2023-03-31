using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class medicamentos
    {
        public string tipo;

        public void gripeyTos()
        {
            Console.WriteLine("1-Viro Grip \n2-Loratadina \n3-Te de Limon \n4-Jarabe ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo = "Viro Grip";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "en el dia y otra en la noche");
                    break;
                case 2:
                    tipo = "Loratadina";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "de 500 gramos cada 12 horas");
                    break;
                case 3:
                    tipo = "Te de Limon";
                    Console.WriteLine("Tomarse un" + " " + tipo + " " + "al dia (disolver en un vaso con agua de 12 onzas)");
                    break;
                case 4:
                    tipo = "Jarabe";
                    Console.WriteLine("Tomarse una cucharada de" + " " + tipo + " " + "cada 8 horas");
                    break;


            }
        }
        public void diarrea()
        {
            Console.WriteLine("1-Intestinomicina AD+ \n2-Alkaa-D \n3-Diloxanida \n4-Loperamina ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo = "Intestinomicina AD+";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "de 500 gramos al dia");
                    break;
                case 2:
                    tipo = "Alkaa-D";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "de 500 gramos cada 12 horas");
                    break;
                case 3:
                    tipo = "Diloxanida";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas de 600 gramos ");
                    break;
                case 4:
                    tipo = "Loperamina";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "cada 8 horas de 450 gramos");
                    break;


            }
        }
        public void vomito()
        {
            Console.WriteLine("1-Intestinomicina AD+ \n2-Alkaa-D \n3-Diloxanida \n4-Loperamina ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo = "Intestinomicina AD+";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "de 500 gramos al dia");
                    break;
                case 2:
                    tipo = "Alkaa-D";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "de 500 gramos cada 12 horas");
                    break;
                case 3:
                    tipo = "Diloxanida";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas de 600 gramos ");
                    break;
                case 4:
                    tipo = "Loperamina";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "cada 8 horas de 450 gramos");
                    break;


            }
        }
        public void dGarganta()
        {
            Console.WriteLine("1-Acetaminofen\n2-Amoxicilina\n3-Panadol\n4-");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo = "Acetaminofen";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + " cada 8 horas en caso de tener fiebre");
                    break;
                case 2:
                    tipo = "Amoxicilina";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas de 500 gramos");
                    break;
                case 3:
                    tipo = "Panadol";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas en caso de tener un fuerte dolor de cabez");
                    break;
                case 4:
                    tipo = "Loperamina";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "cada 8 horas de 450 gramos");
                    break;


            }
        }
    }
}
