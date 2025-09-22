using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] latitudes = { -34.6037, 40.7128, 35.6895, 48.8566, -33.4489 };
            double?[] longitudes = { null, null, null, null, null, -58.3816, -74.0060, 139.6917, 2.3522, -70.6693 };


            for (int i = 0; i < latitudes.Length; i++)
            {
                double lat = latitudes[i];
                double? lng = longitudes[i + 5]; 

                Console.WriteLine($"Ubicación {i}: Lat {lat}, Lng {lng}");
            }
        }
    }

        /*
         1) Necesitamos registrar las coordenadas geograficas de las bases militares argentinas secretas en el
         mundo. Para ello nos requieren tener un arreglo donde se almacene la latitud y otro de longitud que
         imprimiendo sus indices equivalentes nos brinden la ubicación exacta (es decir, latitud[0] con
        longitud[0] es una ubicación, latitud[1] con longitud[1] es otra ubicación.
        En caso de resolverlo fácilmente, te propongo que implementes una encriptación disimulada. Por
        ejemplo la latitud[i= 0] va con la longitud [i +5 ] existiendo una diferencia de 5 posiciones entre
         latitud y longitud.
         */



    }

