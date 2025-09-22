using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto a1 = new Auto();
            a1.marca = "Toyota";
            a1.modelo = "Corolla";
            a1.anio = new DateTime(2020, 1, 1);
            a1.cantidadPuertas = 4;
            a1.esAutomatico = true;

            Console.WriteLine("== AUTO ==");
            a1.MostrarInformacion();
            a1.CambiarMarcha();
            a1.CantidadPuertas();
            a1.EsAutomatico();

            Console.WriteLine();

            Moto m1 = new Moto();
            m1.marca = "Honda";
            m1.modelo = "CBR500";
            m1.anio = new DateTime(2022, 1, 1);
            m1.manubrio = "Deportivo";

            Console.WriteLine("== MOTO ==");
            m1.MostrarInformacion();
            m1.CambiarMarcha();
            m1.TipoManubrio();

            Console.WriteLine();

            Camioneta c1 = new Camioneta();
            c1.marca = "Ford";
            c1.modelo = "Ranger";
            c1.anio = new DateTime(2023, 1, 1);
            c1.cantidadPuertas = 4;
            c1.es4x4 = true;

            Console.WriteLine("== CAMIONETA ==");
            c1.MostrarInformacion();
            c1.CambiarMarcha();
            c1.CantidadPuertas();
            c1.Es4x4();

            Console.WriteLine();


        }




        /*
         2) Crear la clase Vehiculo que contenga marca, modelo y anio. Debe tener los métodos:
        CambiarMarcha() (simplemente un texto que informe el cambio de marcha)
        MostrarInformacion()
        Luego, crear tres clases que hereden de Vehiculo
        Auto
        Camioneta
        Moto
        Agregar propiedades específicas:
        Auto: CantidadPuertas, esAutomatico (booleano)
        Moto: TipoManubrio
        Camioneta: cantidadPuertas, es4x4 (booleano).
        Se deben instanciar en el Main, creando un objeto de cada clase hija y llamar a sus métodos.
         */

        class Vehiculo
        {

            public string marca;
            public string modelo;
            public DateTime anio;

            public Vehiculo()
            { }




            public Vehiculo(String marca, String modelo, DateTime anio)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.anio = anio;


            }

            public void CambiarMarcha()
            {

                Console.WriteLine("Cambio la marcha");
            }

            public void MostrarInformacion()
            {

                Console.WriteLine("La marca es: " + this.marca + "- El modelo " + this.modelo + "- El año: " + this.anio);
            }

            public virtual void CantidadPuertas()
            {
                Console.WriteLine("Cantidad de puertas genérico");
            }
        }
        class Auto : Vehiculo
        {

            public int cantidadPuertas;

            public Boolean esAutomatico;

            public Auto()
            {

            }

            public override void CantidadPuertas()
            {

                Console.WriteLine("Contiene " + this.cantidadPuertas + " puertas.");
            }


            public void EsAutomatico()
            {

                Console.WriteLine("Automatico Si/No: " + this.esAutomatico);


            }



        }

        class Moto : Vehiculo
        {

            public string manubrio;


            public Moto()
            {

            }

            public void TipoManubrio()
            {

                Console.WriteLine("Tipo manubrio: " + this.manubrio);
            }





        }


        class Camioneta : Vehiculo
        {

            public int cantidadPuertas;

            public Boolean es4x4;

            public Camioneta()
            {

            }

            public override void CantidadPuertas()
            {

                Console.WriteLine("Contiene " + this.cantidadPuertas + " puertas.");
            }

            public void Es4x4()
            {

                Console.WriteLine("La camioneta es 4x4: " + this.es4x4);
            }



        }



    }
}