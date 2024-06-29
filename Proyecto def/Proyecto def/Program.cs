using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Proyecto_def
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Alumno alumno = new Alumno();
            PadreTutor padres = new PadreTutor();
            Materias materias=new Materias();

            //Matricula matricula = new Matricula();

            do
            {
                Console.WriteLine("\nSistema de matricula - Colegio Politecnico\n");
                Console.WriteLine("1 - Registrar estudiante y padres/tutores");
                Console.WriteLine("2 - Seleccionar grado");
                Console.WriteLine("3 - Mostrar materias");
                Console.WriteLine("4 - Mostrar costo total");
                Console.WriteLine("5 - Mostrar resumen de matricula");
                Console.WriteLine("6 - Salir");
                Console.Write("\nSeleccione una opcion: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        alumno.RegistrarAlumno();
                        padres.RegistrarPadreTutor();

                        break;
                    case "2":
                        materias.seleccionar_grado();
                        break;
                    case "3":
                        materias.mostrar_materias();
                        break;
                    case "4":
                        materias.calcular_costo();
                        break;
                    case "5":
                        alumno.mostrar_datos();
                        padres.mostrar_datos();
                        materias.mostrar_materias();
                        materias.calcular_costo();
                        break;
                    case "6":
                        Console.WriteLine("\nGuardando y saliendo del sistema...\n");
                        break;
                    default:
                        Console.WriteLine("\nOpcion no valida. Por favor, intente de nuevo.\n");
                        break;
                }
            } while (opcion != "6");



        }
    }
}
