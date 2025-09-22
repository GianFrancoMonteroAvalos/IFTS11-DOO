using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //JUGADOR//
            Jugador j1 = new Jugador("Gian", 27, new DateTime(2022, 10, 3), "DC");
            Jugador j2 = new Jugador("Franco", 29, new DateTime(2023, 09, 8), "MCD");


            //TECNICO
            Tecnico t1 = new Tecnico("Carlos", 45, new DateTime(2010, 5, 10), "Preparación Física");
            Tecnico t2 = new Tecnico("Lucía", 38, new DateTime(2015, 9, 20), "Estrategia Táctica");


            Console.WriteLine("== JUGADORES ==");
            j1.MostrarInformacion();
            j2.MostrarInformacion();

            Console.WriteLine("\n== TÉCNICOS ==");
            t1.MostrarInformacion();
            t2.MostrarInformacion();

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
        }




        /*4) Crear la clase Integrante que posea nombre, edad, antigüedad y sus constructores.
        Crear dos clases hijas:
        Jugador.
        Tecnico.
        Jugador debe tener posicion.
        Tecnico debe tener especialidad.
        Instanciar en el Main al menos dos objetos de la clase Jugador y dos objetos de la clase Tecnico,
        ejecutar los métodos descriptos para cada tipo de Integrante y mostrar la información final por
        pantalla con un método de MostrarInformación().*/
        class Integrante
        {

            public string nombre;
            public int edad;
            public DateTime antiguedad;

            public Integrante()
            {

            }

            public Integrante(string nombre, int edad, DateTime antiguedad)
            {

                this.nombre = nombre;
                this.edad = edad;
                this.antiguedad = antiguedad;

            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine("Nombre: " + this.nombre + "- Edad: " + this.edad + " - Antiguedad: " + this.antiguedad);
            }


        }


        class Jugador : Integrante
        {
            public string posicion;

            public Jugador() { }

            public Jugador(string nombre, int edad, DateTime antiguedad, string posicion)
                : base(nombre, edad, antiguedad)
            {
                this.posicion = posicion;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine("Posición: " + this.posicion);
            }
        }

        class Tecnico : Integrante
        {
            public string especialidad;

            public Tecnico() { }

            public Tecnico(string nombre, int edad, DateTime antiguedad, string especialidad)
                : base(nombre, edad, antiguedad)
            {
                this.especialidad = especialidad;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine("Especialidad: " + this.especialidad);
            }
        }


    }
        

    }


    




