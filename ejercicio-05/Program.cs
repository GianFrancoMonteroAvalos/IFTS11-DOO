using System;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pokedex

            Pokemon[] pokedex = new Pokemon[] {

                new PokemonFuego("Charmander", 5),
                new PokemonAgua("Squirtle", 6),
                new PokemonElectrico("Pikachu", 7),
                new Pokemon("Eevee", 4)


            };

            for (int i = 0; i < pokedex.Length; i++)
            {
                pokedex[i].Atacar();
            }
        }
    }


    /*
 5) Crear una Pokedex para registrar información de diversos Pokemones, para esto te propongo
clasificarlos en:
Pokemon (clase padre) con atributos: nombre y nivel y método: Atacar: Muestra en pantalla:
this.nombre ataca!
PokemonFuego: Atacar es: Pokemon this.nombre lanza una llamarada!
PokemonAgua: Atacar es: Pokemon this.nombre lanza un chorro de agua!
PokemonElectrico: Atacar es: Pokemon this.nombre lanza un impactrueno!
Crear un arreglo de objetos Pokemon y luego ejecutar sus respectivos ataques
*/


    class Pokemon
    {

        public string nombre;
        public int nivel;

        public Pokemon() { }

        public Pokemon(string nombre, int nivel)
        {

            this.nombre = nombre;
            this.nivel = nivel;

        }

        public virtual void Atacar()
        {

            Console.WriteLine(this.nombre + " ataca! ");
        }
    }
    class PokemonFuego : Pokemon
    {

        public PokemonFuego() { }

        public PokemonFuego(string nombre, int nivel) : base(nombre, nivel)
        {

            this.nombre = nombre;
            this.nivel = nivel;
        }

        public override void Atacar()
        {

            Console.WriteLine(this.nombre + " lanza una llamarada!");
        }
        


    }
    class PokemonAgua : Pokemon
    {

        public PokemonAgua() { }

        public PokemonAgua(string nombre, int nivel) : base(nombre, nivel)
        {

            this.nombre = nombre;
            this.nivel = nivel;
        }

        public override void Atacar()
        {

            Console.WriteLine(this.nombre + " lanza una llamarada!");
        }


    }
    class PokemonElectrico : Pokemon
    {

        public PokemonElectrico() { }

        public PokemonElectrico(string nombre, int nivel) : base(nombre, nivel)
        {

            this.nombre = nombre;
            this.nivel = nivel;
        }

        public override void Atacar()
        {

            Console.WriteLine(this.nombre + " lanza una llamarada!");
        }


    }


}