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
                    Console.WriteLine("Le ofrecemos viro grip de dia y de noche, a $0.50 cada unidad");
                    break;
                case 2:
                    tipo = "Loratadina";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "de 500 gramos cada 12 horas");
                    Console.WriteLine("Le tenemos el blister a $2.50");
                    break;
                case 3:
                    tipo = "Te de Limon";
                    Console.WriteLine("Tomarse un" + " " + tipo + " " + "al dia (disolver en un vaso con agua de 12 onzas)");
                    Console.WriteLine("Le ofrececemos el sobresito de te de limon a $0.25");
                    break;
                case 4:
                    tipo = "Jarabe";
                    Console.WriteLine("Tomarse una cucharada de" + " " + tipo + " " + "cada 8 horas");
                    Console.WriteLine("Le tenemos el jarabe a $6.50 cada uno");
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
                    Console.WriteLine("Le tenemos cada unidad a $0.50");
                    break;
                case 2:
                    tipo = "Alkaa-D";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "de 500 gramos cada 12 horas");
                    Console.WriteLine("Le tenemos cada unidad a $0.75");
                    break;
                case 3:
                    tipo = "Diloxanida";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas de 600 gramos ");
                    Console.WriteLine("Le ofrecemos el blister a $1.75");
                    break;
                case 4:
                    tipo = "Loperamina";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "cada 8 horas de 450 gramos");
                    Console.WriteLine("Le ofrecemos el blister a $2.00");
                    break;


            }
        }
        public void quemadura()
        {
            Console.WriteLine("1-Bepanthol Crema \n2-Rilastil neoviderm \n3-Cicapost Crema \n4-A-Derma Epitheliale Crema");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo = "Bepanthol Crema";
                    Console.WriteLine("Aplicar" + " " + tipo + " " + "en la quemadura 2 veces al dia");
                    Console.WriteLine("Le tenemos el tubito de crema a $10.70");
                    break;
                case 2:
                    tipo = "Rilastil neoviderm";
                    Console.WriteLine("Aplicar" + " " + tipo + " " + "en la quemadura 3 veces al dia");
                    Console.WriteLine("Le tenemos el tubito de crema a $11.00");
                    break;
                case 3:
                    tipo = "Cicapost Crema";
                    Console.WriteLine("Aplicar" + " " + tipo + " " + "en la quemadura cada 12 horas");
                    Console.WriteLine("Le tenemos el tubito de crema a $12.75");
                    break;
                case 4:
                    tipo = "A-Derma Epitheliale Crema";
                    Console.WriteLine("Aplicar" + " " + tipo + " " + "en la quemadura 1 vez al dia");
                    Console.WriteLine("Le tenemos el tubito de crema a $15.00");
                    break;


            }
        }
        public void dGarganta()
        {
            Console.WriteLine("1-Acetaminofen\n2-Amoxicilina\n3-Panadol\n4-Trimetropin");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tipo = "Acetaminofen";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + " cada 8 horas en caso de tener fiebre");
                    Console.WriteLine("Le ofrecemos el blister a $2.50");
                    break;
                case 2:
                    tipo = "Amoxicilina";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas de 500 gramos");
                    Console.WriteLine("Le ofrecemos el blister a $2.75");
                    break;
                case 3:
                    tipo = "Panadol";
                    Console.WriteLine("Tomarse una" + " " + tipo + " " + "cada 12 horas en caso de tener un fuerte dolor de cabez");
                    Console.WriteLine("Le ofrecemos cada unidad a $0.25");
                    break;
                case 4:
                    tipo = "Trimetropin";
                    Console.WriteLine("Tomarse una " + " " + tipo + " " + "cada 12 horas de 450 gramos");
                    Console.WriteLine("Le ofrecemos el blister a $3.00");
                    break;


            }
        }
    }
}
