using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_def
{
    internal class Materias
    {
        string grado;
        List<string> materias;
        List<float> precios;
        List<String> horario;
        int costoxmateria = 25000;
        int matricula = 35000;


        //metodo que pregunta por grado, y asigna automaticamente las materias
        public List<object> seleccionar_grado() {
            Console.WriteLine("Seleccione grado académico");
            Console.WriteLine("7 - Séptimo");
            Console.WriteLine("8 - Octavo");
            Console.WriteLine("9 - Noveno");
            Console.WriteLine("10 - Décimo");
            Console.WriteLine("11 - Undécimo");

            grado = Console.ReadLine();
            List<object> consolidado = new List<object>();  
            switch (grado)
            {
                case "7":
                    materias = new List<string> { "Español", "Matemáticas", "Sociales", "Ciencias", "Cívica", "Inglés", "Educación Física", "Artes" };
                    horario= new List<string> { "7:00 - 8:00", "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00" };
                    break;
                case "8":
                    materias = new List<string> { "Matemáticas", "Ciencias", "Sociales", "Inglés", "Español", "Artes", "Educación Física", "Cívica" };
                    horario = new List<string> { "7:00 - 8:00", "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00" };
                    break;
                case "9":
                    materias = new List<string> { "Artes", "Ciencias", "Cívica", "Educación Física", "Español", "Inglés", "Matemáticas", "Sociales" };
                    horario = new List<string> { "7:00 - 8:00", "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00" };
                    break;
                case "10":
                    materias = new List<string> { "Física", "Biología", "Qumica", "Español", "Matemáticas", "Sociales", "Cívica", "Inglés", "Educación Física", "Artes" };
                    horario = new List<string> { "7:00 - 8:00", "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00","15:00-16:00",  "16:00-17:00" };
                    break ;
                case "11":
                    materias = new List<string> { "Química", "Biología", "Física", "Matemáticas", "Español", "Inglés", "Sociales", "Cívica", "Educación Física", "Artes" };
                    horario = new List<string> { "7:00 - 8:00", "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00", "15:00-16:00", "16:00-17:00" };
                    break;
                default:
                    Console.WriteLine("Grado no válido. Ingrese un número de 7 a 11.");
                    break;

            }

            consolidado.Add(materias);
            consolidado.Add(horario);
            consolidado.Add(grado);
            consolidado.Add(materias.Count * costoxmateria + matricula);
            return consolidado;
        }
        // metodo para mostrar materias
        public void mostrar_materias()
        {
            //usamos try para que en caso que no se haya escogido el grado, tire error
            try
            {
                Console.WriteLine("Materias Matriculadas");
                Console.WriteLine("Materia  |   Horario");
                for (int i = 0; i < materias.Count; i++)
                {
                    Console.WriteLine($"{materias[i]}   |   {horario[i]}");

                }
            }
            catch (System.NullReferenceException ex) { Console.WriteLine("Error, no se ha seleccionado el grado"); }
        }
        //metodo para calcular costo
        public void calcular_costo()
        {
            //usamos try para que en caso que no se haya escogido el grado, tire error
            try
            {

                Console.WriteLine($"Costo por materia: {costoxmateria}");
                Console.WriteLine($"Cantidad de materias: {materias.Count}");
                Console.WriteLine($"Costo de matricula: {matricula}");
                Console.WriteLine($"Total: {materias.Count * costoxmateria + matricula}");
            } catch (System.NullReferenceException ex) { Console.WriteLine("Error, no se ha seleccionado el grado"); }
        }



    }
}
