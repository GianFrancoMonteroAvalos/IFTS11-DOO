using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////




            Persona p1 = new Persona();
            p1.nombre = "Gian";
            p1.SetEdad(27);
            Console.WriteLine("La edad es: " + p1.GetEdad());
            p1.dni = 40748087;
            p1.MostrarInformacion();


        }
    }


    /*
    3) Crear la clase Persona con los siguientes atributos:
   nombre
   private edad
   DNI 
   Método:
   MostrarInformación() que imprima por consola los tres atributos.
   Crear 3 constructores: Uno vacío. Uno que reciba por parámetro el nombre y la edad. Uno que
   reciba el nombre, la edad y el DNI.
   En el Main: Crear tres objetos de Persona usando los distintos constructores y mostrar los valores
   de sus propiedades con el método MostrarInformación(). 

    */

    class Persona
    {

        public string nombre;
        private int edad;
        public int dni;

        public Persona()
        {
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public void MostrarInformacion()
        {

            Console.WriteLine("El nombre es: " + this.nombre + " - La edad: " + this.edad + " - DNI: " + this.dni);
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return this.edad;
        }


    }

}
    




