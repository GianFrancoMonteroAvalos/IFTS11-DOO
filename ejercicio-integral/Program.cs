using System;
using System.Data;

namespace DOOEJERCICIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instancias[] maquinas = new Instancias[4];

            maquinas[0] = new ProcesosDatos(
            "ProcDB1", "1.0", "Linux", 0, "DB_Clientes", "DB_Backup");

            maquinas[1] = new ProcesosDatos(
                "ProcDB2", "1.1", "Windows", 0, "DB_Ventas", "DB_Analitica");

            maquinas[2] = new Aplicacion(
                "AppJava", "2.0", "Linux", 0, "Java", "17", "jdbc:mysql://localhost:3306/db1");

            maquinas[3] = new Aplicacion(
                "AppDotNet", "2.1", "Windows", 0, "C#", "9.0", "sqlserver://mi-servidor/db2");



            Console.WriteLine("=== Levantando máquinas ===");


            for (int i = 0; i < maquinas.Length; i++)

                maquinas[i].Up();


            Console.WriteLine("\n=== Bajando máquinas ===");
            for (int i = 0; i < maquinas.Length; i++)


                maquinas[i].Down();



        }

    
        class Instancias
        {

            public string nombre;

            public string version;

            public string sistemaOperativo;

            public int estado;


            public Instancias()
            {

            }
            public Instancias(string nombre, string version, string sistemaOperativo, int estado)
            {
                this.nombre = nombre;   
                this.version = version;
                this.sistemaOperativo= sistemaOperativo;
                this.estado = estado;   

            }

            public virtual void Up()
            {

                this.estado = 1;

                Console.WriteLine("Estado UP: " + this.estado);
            }

            public void Down()
            {

                this.estado = 0;

                Console.WriteLine("Estado DOWN: " + this.estado);

            }


        }



        class ProcesosDatos : Instancias
        {

            public string datosOrigen;

            public string datosFin;

            public ProcesosDatos()
            {


            }

            public ProcesosDatos(string nombre, string version, string sistemaOperativo, int estado, string datosOrigen, string datosFin):base(nombre, version, sistemaOperativo, estado) {

                this.datosOrigen = datosOrigen; 
                this.datosFin = datosFin;
                
            }

            public override void Up() {
                this.estado = 1;
                Console.WriteLine("se ha levantado correctamente" +
                    "la instancia posee acceso a datos" +
                    "de origen almacenados " + this.datosOrigen + " y a " +
                    "datos de fin almacenados: " + this.datosFin);
            
            }


        }

        class Aplicacion : Instancias
        {

            public string lenguajeProgramacion;

            public string versionLenguaje;

            public string basesDatos;

            public Aplicacion()
            {

            }

            public Aplicacion(string nombre, string version, string sistemaOperativo, int estado, string lenguajeProgramacion, string versionLenguaje, string basesDatos) : base(nombre, version, sistemaOperativo, estado)
            {

                this.lenguajeProgramacion = lenguajeProgramacion;
                this.versionLenguaje = versionLenguaje;
                this.basesDatos = basesDatos;


            }

            public override void Up()
            {
                this.estado = 1;
                Console.WriteLine("Se ha instalado el lenguaje de " +
                    " programación: " + this.lenguajeProgramacion + " en la versión deseada: " + this.versionLenguaje + " y se p" +
                    "osee acceso correcto a la base de datos: " + this.basesDatos);

            }
        }
        }
    }
