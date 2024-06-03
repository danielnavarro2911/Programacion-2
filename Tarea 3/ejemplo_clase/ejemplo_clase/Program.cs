using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_clase
{
    internal class Program
    {
        public static string salir = "";
        static void Main(string[] args)
        {   
            
            while (true)
            {
                if (salir != "salir")
                {
                    Console.WriteLine("Digite enter para iniciar una operacion o escriba 'salir' para salir");
                    salir = Console.ReadLine();
                    Operacion operacion = new Operacion();
                    operacion.preguntar_operacion();
                    operacion.ejecutar_operacion();
                    Console.Read();
                }else { break;}
            }

        }
    }


    public class Operacion
    {
        public float n1, n2,resultado;
        public string pregunta;


        public void preguntar_operacion()
        {
            Console.WriteLine("Digite operacion a ejectutar");
            pregunta = Console.ReadLine();

            Console.WriteLine("Digite numero 1");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite numero 2");
            n2 = float.Parse(Console.ReadLine());

        }

        public void ejecutar_operacion()
        {
            switch(pregunta){
                case "suma":
                    resultado = suma();
                    break;
                case "resta":
                    resultado= restar();
                    break;
                case "dividir":
                    resultado=dividir();
                    break;
                case "potencia":
                    resultado=potencia();
                    break;
                case "triangulo":
                    resultado=triangulo();
                    break;
                case "cuadrado":
                    resultado=cuadrado(); 
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;

            }
            Console.WriteLine($"El resultado es {resultado}");
        }

        float suma()
        {
            return n1 + n2;
        }

        float restar()
        {
            return (n1 - n2);
        }

        float dividir()
        {
            return n1 / n2;
        }

        float potencia()
        {
            return (float)Math.Pow(n1, n2);
        }

        float triangulo()
        {
            return n1 * n2 / 2;
        }
        float cuadrado ()
        {
            return n1 * n2;
        }

        
    }
}
