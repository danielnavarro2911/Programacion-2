using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_problema_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string input = "";
            List<object> ventas = new List<object>();//lista que contendra los diccionarios de cada venta
            int n_entradas_NS=0;
            double acumulado_NS=0;
            int n_entradas_EO=0;
            double acumulado_EO=0;
            int n_entradas_pref=0;
            double acumulado_pref=0;

            //bucle que pide datos de las ventas llamando la clase Venta
            while (input!="s") {

                
                Console.WriteLine("Presiona enter para ingresar una venta o s para salir:");
                input = Console.ReadLine();
                if (input != "s")
                {
                    Venta venta = new Venta();// creammos la instancia
                    ventas.Add(venta.get_datos());//llamamos al metodo y guardamos en la lista
                    venta.mostrar_datos();
                }

            }
            foreach (Dictionary<string, object> i in ventas)
            {
                if ((string)i["Localidad"] == "Sol Norte/Sur")
                {
                    n_entradas_NS++;
                    acumulado_NS = (double)i["Total a Pagar"] + acumulado_NS;

                }
                else if ((string)i["Localidad"] == "Sombra Este/Oeste")
                {
                    n_entradas_EO++;
                    acumulado_EO = (double)i["Total a Pagar"] + acumulado_EO;

                }
                else
                {
                    n_entradas_pref++;
                    acumulado_pref = (double)i["Total a Pagar"] + acumulado_pref;
                }

            }

            //imprimimos los resultados, con cuidado en caso de que n sea cero

            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur: {n_entradas_NS}");
            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur: {acumulado_NS}");

            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {n_entradas_EO}");
            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {acumulado_EO}");

            Console.WriteLine($"Cantidad Entradas Localidad Preferencial: {n_entradas_pref}");
            Console.WriteLine($"Acumulado Dinero Localidad Preferencial: {acumulado_pref}");

            Console.Read();

        }
    }


    public class Venta
    {
        public string factura;
        public string cedula;
        public string nombre;
        public string localidad;
        public int n_entradas=0;
        public double precio_NS = 10500;
        public double precio_EO = 20500;
        public double precio_pref = 25500;
        public double submonto;
        public double servicios;


        public Dictionary<string, object> datos_venta;

        // preguntamos atributos por consola con el siguiente metodo
        public Dictionary<string, object> get_datos()
        {
            Console.Write("Digite numero de factura: ");
            factura = Console.ReadLine();

            Console.Write("Digite nombre de comprador: ");
            nombre = Console.ReadLine();

            Console.Write("Digite numero de cedula: ");
            cedula = Console.ReadLine();

            Console.Write("Digite localidad de empleado (1 para Sol Norte/Sur, 2 para Sombra Este/Oeste, 3 para Preferencial), : ");
            localidad = Console.ReadLine();

            //bucle infinito hasta que se digite un numero menor o igual a 4
            while (true)
            {
                Console.Write("Digite cantidad de entradas: ");
                n_entradas = int.Parse(Console.ReadLine());

                if (n_entradas <= 4)
                {
                    break;
                }
                else { Console.WriteLine("Error, maximo 4 entradas"); }

            }
            

            servicios = 1000 * n_entradas;

            submonto = calcular_montos();

            //creamos diccionario para guardar todos los datos
            datos_venta = new Dictionary<string, object>();

            datos_venta.Add("Factura", factura);
            datos_venta.Add("Cedula", cedula);
            datos_venta.Add("Nombre", nombre);
            datos_venta.Add("Localidad", localidad);
            datos_venta.Add("Cantidad de Entradas", n_entradas);
            datos_venta.Add("Subtotal", submonto);
            datos_venta.Add("Cargos por Servicios", servicios);
            datos_venta.Add("Total a Pagar", submonto + servicios);

            //datos_empleado.Add("localidad de empleado", localidad);

            return datos_venta;
        }

        public double calcular_montos()
        {
            if (localidad == "1")
            {
                localidad = "Sol Norte/Sur";
                return n_entradas * precio_NS;
            }
            else if (localidad == "2")
            {
                localidad = "Sombra Este/Oeste";
                return n_entradas * precio_EO;
            }
            else
            {
                localidad = "Preferencial";
                return n_entradas * precio_pref;
            }

        }

        public void mostrar_datos()
        {

            // Imprimimos el diccionario obtenido
            foreach (KeyValuePair<string, object> i in datos_venta)
            {
                // Imprimimos la clave
                Console.WriteLine($"{i.Key}: {i.Value}");
            }


        }






    }
}



