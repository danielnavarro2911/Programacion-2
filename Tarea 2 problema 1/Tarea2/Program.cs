using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tarea2;

namespace Tarea2
{
    public class Empleado
    {
        // definimos atributos de empleado
        public string nombre;
        public string cedula;
        public string tipo;
        public float horas_laboradas;
        public float precio_hora;
        public float salario_ordinario;
        public double salario_bruto;
        public double salario_neto;

        public double deducciones;

        public double aumento_calculado;

        public Dictionary<string, object> datos_empleado;




        // preguntamos atributos por consola con el siguiente metodo
        public Dictionary<string, object> get_datos()
        {
            Console.Write("Digite nombre de empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Digite numero de cedula: ");
            cedula = Console.ReadLine();

            Console.Write("Digite tipo de empleado (1 para Operario, 2 para Tecnico  3 para Profesional), : ");
            tipo = Console.ReadLine();

            Console.Write("Digite horas laboradas: ");
            horas_laboradas = float.Parse(Console.ReadLine());

            Console.Write("Digite precio por hora: ");
            precio_hora = float.Parse(Console.ReadLine());

            salario_ordinario = horas_laboradas * precio_hora;

            aumento_calculado = aumento();

            salario_bruto = salario_ordinario + aumento_calculado;

            deducciones = salario_bruto * 0.0917;

            salario_neto = salario_bruto - deducciones;

            //creamos diccionario para guardar todos los datos
            datos_empleado = new Dictionary<string, object>();

            datos_empleado.Add("Nombre", nombre);
            datos_empleado.Add("Cedula", cedula);
            datos_empleado.Add("Tipo de empleado", tipo);
            datos_empleado.Add("Salario por hora", precio_hora);
            datos_empleado.Add("Cantidad de horas", horas_laboradas);
            datos_empleado.Add("Salario ordinario", salario_ordinario);
            datos_empleado.Add("Aumento", aumento_calculado);
            datos_empleado.Add("Salario bruto", salario_bruto);
            datos_empleado.Add("Deduccion CCSS", deducciones);
            datos_empleado.Add("Salario neto", salario_neto);

            return datos_empleado;

        }
        //Calculamos el aumento y a su vez renombramos la variable tipo
        double aumento()
        {
            if (tipo == "1")
            {
                tipo = "Operario";
                return salario_ordinario + salario_ordinario * 0.15;
            }
            else if (tipo == "2")
            {
                tipo = "Tecnico";
                return salario_ordinario + salario_ordinario * 0.10;
            }
            else
            {
                tipo = "Profesional";
                return salario_ordinario + salario_ordinario * 0.05;
            }

        }
        public void mostrar_datos()
        {

            // Imprimimos el diccionario obtenido
            foreach (KeyValuePair<string, object> i in datos_empleado)
            {
                // Imprimimos la clave
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        

        }
        //creamos un bucle while donde llamamos la clase empleado, y el metodo get_datos que trae un diccionario. Haremos una lista de diccionarios
        class Program
        {
            //public Dictionary<string, object> empleado_;

            static void Main(string[] args)
            {
                List<object> empleados = new List<object>();
                string input = "";
                while (input != "s")
                {
                    Console.WriteLine("Presiona enter para ingresar un empleado o s para salir:");
                    input = Console.ReadLine();
                    if (input != "s")
                    {
                        Empleado empleado_ = new Empleado();// creammos la instancia
                        empleados.Add(empleado_.get_datos());//llamamos al metodo y guardamos en la lista
                        empleado_.mostrar_datos();
                    }
                    

                }
                //una vez guardados los diccionarios, recorremos cada diccionario para calcular los totalws
                int n_operarios = 0;
                double total_salario_neto_operario = 0;
                int n_tecnico = 0;
                double total_salario_neto_tecnico = 0;
                int n_profesional = 0;
                double total_salario_neto_profesional = 0;

                foreach (Dictionary<string, object> i in empleados)
                {
                    if (i["Tipo de empleado"] == "Operario")
                    {
                        n_operarios++;
                        total_salario_neto_operario=(double)i["Salario neto"] + total_salario_neto_operario;

                    }
                    else if (i["Tipo de empleado"] == "Tecnico")
                    {
                        n_tecnico++;
                        total_salario_neto_tecnico = (double)i["Salario neto"] + total_salario_neto_tecnico;

                    }
                    else
                    {
                        n_profesional++;
                        total_salario_neto_profesional = (double)i["Salario neto"] + total_salario_neto_profesional;
                    }

                    //imprimimos los resultados, con cuidado en caso de que n sea cero

                    Console.WriteLine($"Cantidad Empleados Tipo Operarios: {n_operarios}");
                    Console.WriteLine($"Acumulado Salario Neto para Operarios: {total_salario_neto_operario}");
                    if (n_operarios != 0)
                    {
                        Console.WriteLine($"Promedio Salario Neto para Operarios: {total_salario_neto_operario / n_operarios}");
                    }

                    Console.WriteLine($"Cantidad Empleados Tipo Tecnico: {n_tecnico}");
                    Console.WriteLine($"Acumulado Salario Neto para Tecnico: {total_salario_neto_tecnico}");
                    if (n_tecnico != 0)
                    {
                        Console.WriteLine($"Promedio Salario Neto para Tecnico: {total_salario_neto_tecnico / n_tecnico}");
                    }

                    Console.WriteLine($"Cantidad Empleados Tipo Profesional: {n_profesional}");
                    Console.WriteLine($"Acumulado Salario Neto para Profesional: {total_salario_neto_profesional}");
                    if (n_profesional != 0)
                    {
                        Console.WriteLine($"Promedio Salario Neto para Profesional: {total_salario_neto_profesional / n_profesional}");
                    }
                    Console.Read();

                }

            }
        }
    }
}


