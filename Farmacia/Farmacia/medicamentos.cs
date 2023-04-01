using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class medicamentos
    {
        private string tEnfermedad;
        enfermedad enfe = new enfermedad();
        public string TEnfermedad { get => tEnfermedad; set => tEnfermedad = value ; }

        public void gripeyTos(string _Enfermedad)
        {
            this.TEnfermedad = _Enfermedad;
            Console.WriteLine("1-Viro Grip \n2-Loratadina \n3-Te de Limon \n4-Jarabe ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TEnfermedad = "Viro Grip";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TEnfermedad + " " + "en el dia y otra en la noche");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos viro grip de dia y de noche, a $0.50 cada unidad");
                    break;
                case 2:
                    TEnfermedad = "Loratadina";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TEnfermedad + " " + "de 500 gramos cada 12 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el blister a $2.50");
                    break;
                case 3:
                    TEnfermedad = "Te de Limon";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse un" + " " + TEnfermedad + " " + "al dia (disolver en un vaso con agua de 12 onzas)");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrececemos el sobresito de te de limon a $0.25");
                    break;
                case 4:
                    TEnfermedad = "Jarabe";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una cucharada de" + " " + TEnfermedad + " " + "cada 8 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el jarabe a $6.50 cada uno");
                    break;


            }
        }
        public String MostrarGP()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TEnfermedad + "";
            
        }
        private string tDiarrea;

        public string TDiarrea { get => tDiarrea; set => tDiarrea = value; }

        public void diarrea(string _Diarrea)
        {
            this.TDiarrea = _Diarrea;
            Console.WriteLine("1-Intestinomicina AD+ \n2-Alkaa-D \n3-Diloxanida \n4-Loperamina ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TDiarrea = "Intestinomicina AD+";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TDiarrea + " " + "de 500 gramos al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos cada unidad a $0.50");
                    break;
                case 2:
                    TDiarrea = "Alkaa-D";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TDiarrea + " " + "de 500 gramos cada 12 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos cada unidad a $0.75");
                    break;
                case 3:
                    TDiarrea = "Diloxanida";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TDiarrea + " " + "cada 12 horas de 600 gramos ");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $1.75");
                    break;
                case 4:
                    TDiarrea = "Loperamina";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TDiarrea + " " + "cada 8 horas de 450 gramos");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $2.00");
                    break;


            }
        }
        public String MostrarD()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TDiarrea + "";
        }
        private string tQuemadura;

        public string TQuemadura { get => tQuemadura; set => tQuemadura = value; }
        public void quemadura(string _Quemadura)
        {
            this.TQuemadura = _Quemadura;
            Console.WriteLine("1-Bepanthol Crema \n2-Rilastil neoviderm \n3-Cicapost Crema \n4-A-Derma Epitheliale Crema");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TQuemadura = "Bepanthol Crema";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura 2 veces al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $10.70");
                    break;
                case 2:
                    TQuemadura = "Rilastil neoviderm";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura 3 veces al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $11.00");
                    break;
                case 3:
                    TQuemadura = "Cicapost Crema";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura cada 12 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $12.75");
                    break;
                case 4:
                    TQuemadura = "A-Derma Epitheliale Crema";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura 1 vez al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $15.00");
                    break;


            }
        }
        public String MostrarQ()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TQuemadura + "";
        }
        private string tGarganta;

        public string TGarganta { get => tGarganta; set => tGarganta = value; }
        public void dGarganta(string _Garganta)
        {
            this.TGarganta = _Garganta;
            Console.WriteLine("1-Acetaminofen\n2-Amoxicilina\n3-Panadol\n4-Trimetropin");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TGarganta = "Acetaminofen";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TGarganta + " " + " cada 8 horas en caso de tener fiebre");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $2.50");
                    break;
                case 2:
                    TGarganta = "Amoxicilina";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TGarganta + " " + "cada 12 horas de 500 gramos");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $2.75");
                    break;
                case 3:
                    TGarganta = "Panadol";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TGarganta + " " + "cada 12 horas en caso de tener un fuerte dolor de cabez");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos cada unidad a $0.25");
                    break;
                case 4:
                    TGarganta = "Trimetropin";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TGarganta + " " + "cada 12 horas de 450 gramos");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $3.00");
                    break;


            }
        }
        public String MostrarG()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TGarganta + "";
        }
    }
}
