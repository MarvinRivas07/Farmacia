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
        private string tPrecio;

        enfermedad enfe = new enfermedad();
        public string TEnfermedad { get => tEnfermedad; set => tEnfermedad = value ; }
        public string TPrecio { get => tPrecio; set => tPrecio = value ;}

        public void gripeyTos(string _Enfermedad , string _Precio)
        {
            this.TEnfermedad = _Enfermedad;
            this.TPrecio = _Precio;
            Console.WriteLine("1-Viro Grip \n2-Loratadina \n3-Te de Limon \n4-Jarabe ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TEnfermedad = "Viro Grip";
                    TPrecio = "$0.50";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TEnfermedad + " " + "en el dia y otra en la noche");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos viro grip de dia y de noche, a $0.50 cada unidad");
                    break;
                case 2:
                    TEnfermedad = "Loratadina";
                    TPrecio = "$2.50";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TEnfermedad + " " + "de 500 gramos cada 12 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el blister a $2.50");
                    break;
                case 3:
                    TEnfermedad = "Te de Limon";
                    TPrecio = "$0.25";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse un" + " " + TEnfermedad + " " + "al dia (disolver en un vaso con agua de 12 onzas)");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrececemos el sobresito de te de limon a $0.25");
                    break;
                case 4:
                    TEnfermedad = "Jarabe";
                    TPrecio = "$6.50";
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
        public String MostrarP0()
        {
            return "\nPRECIO:\n" + TPrecio + "";

        }

        private string tDiarrea;
        private string tPrecio1;

        public string TDiarrea { get => tDiarrea; set => tDiarrea = value; }
        public string TPrecio1 { get => tPrecio1; set => tPrecio1 = value; }
        public void diarrea(string _Diarrea,string _Precio1)
        {
            this.TDiarrea = _Diarrea;
            this.TPrecio1 = _Precio1;
            Console.WriteLine("1-Intestinomicina AD+ \n2-Alkaa-D \n3-Diloxanida \n4-Loperamina ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TDiarrea = "Intestinomicina AD+";
                    TPrecio1 = "$0.50";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TDiarrea + " " + "de 500 gramos al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos cada unidad a $0.50");
                    break;
                case 2:
                    TDiarrea = "Alkaa-D";
                    TPrecio1 = "$0.75";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TDiarrea + " " + "de 500 gramos cada 12 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos cada unidad a $0.75");
                    break;
                case 3:
                    TDiarrea = "Diloxanida";
                    TPrecio1 = "$1.75";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TDiarrea + " " + "cada 12 horas de 600 gramos ");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $1.75");
                    break;
                case 4:
                    TDiarrea = "Loperamina";
                    TPrecio1 = "$2.00";
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
        public String MostrarP1()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TPrecio1 + "";
        }


        private string tQuemadura;
        private string tPrecio2;

        public string TQuemadura { get => tQuemadura; set => tQuemadura = value; }
        public string TPrecio2 { get => tPrecio2; set => tPrecio2 = value; }
        public void quemadura(string _Quemadura, string _Precio2)
        {
            this.TQuemadura = _Quemadura;
            this.TPrecio2 = _Precio2;
            Console.WriteLine("1-Bepanthol Crema \n2-Rilastil neoviderm \n3-Cicapost Crema \n4-A-Derma Epitheliale Crema");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TQuemadura = "Bepanthol Crema";
                    TPrecio2 = "$10.70";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura 2 veces al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $10.70");
                    break;
                case 2:
                    TQuemadura = "Rilastil neoviderm";
                    TPrecio2 = "$11.00";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura 3 veces al dia");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $11.00");
                    break;
                case 3:
                    TQuemadura = "Cicapost Crema";
                    TPrecio2 = "$12.75";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Aplicar" + " " + TQuemadura + " " + "en la quemadura cada 12 horas");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le tenemos el tubito de crema a $12.75");
                    break;
                case 4:
                    TQuemadura = "A-Derma Epitheliale Crema";
                     TPrecio2 = "$15.00";
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
        public String MostrarP2()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TPrecio1 + "";
        }


        private string tGarganta;
        private string tPrecio3;

        public string TGarganta { get => tGarganta; set => tGarganta = value; }
        public string TPrecio3 { get => tPrecio3; set => tPrecio3 = value;}
        public void dGarganta(string _Garganta, string _Precio3)
        {
            this.TGarganta = _Garganta;
            this.TPrecio3 = _Precio3;
            Console.WriteLine("1-Acetaminofen\n2-Amoxicilina\n3-Panadol\n4-Trimetropin");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TGarganta = "Acetaminofen";
                    TPrecio3 = "$2.50";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una " + " " + TGarganta + " " + " cada 8 horas en caso de tener fiebre");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $2.50");
                    break;
                case 2:
                    TGarganta = "Amoxicilina";
                    TPrecio3 = "$2.75";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TGarganta + " " + "cada 12 horas de 500 gramos");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos el blister a $2.75");
                    break;
                case 3:
                    TGarganta = "Panadol";
                    TPrecio3 = "$0.25";
                    Console.WriteLine("\nINDICACIONES:");
                    Console.WriteLine("Tomarse una" + " " + TGarganta + " " + "cada 12 horas en caso de tener un fuerte dolor de cabez");
                    Console.WriteLine("PRECIO:");
                    Console.WriteLine("Le ofrecemos cada unidad a $0.25");
                    break;
                case 4:
                    TGarganta = "Trimetropin";
                    TPrecio3 = "$3.00";
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
        public String MostrarP3()
        {
            return "\nSU FACTURA:\nMEDICAMENTO SELECCIONADO:\n" + TPrecio3 + "";
        }
    }
}
