using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_def
{
    public class Matricula
    {
        private List<object> estudiante;
        private List<object> materias;
        private List<float> precios;
        //el constructor recibe 2 listas
        public Matricula(List<object> estudiante, List<object> materias, List<float> precios)
        {
            this.estudiante = estudiante; this.materias = materias;
            this.precios = precios;
        }
        //metodos 
        //mostramos todo en consola
        public void MostrarListas()

        {

            float total = 0;
            Console.WriteLine("Datos Estudiante:");
            foreach (var item in estudiante)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Materias Matriculadas:");
            Console.WriteLine("Materia  |   Precio");
            for (int i = 0; i < materias.Count; i++)
            {
                Console.WriteLine($"{materias[i]}   |   {precios[i]}");
                total = total + precios[i];

            }

            Console.WriteLine($"Total: {total}");

        }
    }
    }
