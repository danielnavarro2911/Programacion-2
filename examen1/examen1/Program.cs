using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionVehiculos carros=new GestionVehiculos();
            carros.menu();
        }
    }


    internal class GestionVehiculos
    {
        string cedula, marca, modelo, placa, color, fallas;
        int anio;
        List<Dictionary<string, object>> database = new List<Dictionary<string, object>>();
        // creamos un dato ficticio solo para que el diccionario no empiece vacio. Normalmente eso no se haria pues se toman los campos de la base de datos real
        Dictionary<string, object> dato1 = new Dictionary<string, object>
        {
            { "Cedula", "" },
            { "Marca", "" },
            { "Modelo", "" },
            { "Placa","123"},
            {"Año",0 },
            {"Color","" },
            {"Fallas","" } };
        
        public void borrar_vehiculo()
        {
            Dictionary<string, object> vehiculoAEliminar = null;
       
            Console.WriteLine("Digite placa del vehiculo a eliminar");
            placa = Console.ReadLine();

            foreach(var carro in database)
            {
                if (carro["Placa"].ToString() == placa)
                {
                    vehiculoAEliminar = carro;
                    Console.WriteLine("vehiculo removido");
                }
            }
                if (vehiculoAEliminar == null)
                {
                    Console.WriteLine("No se encuentra este vehiculo en nuestra base de datos");
                }
            //removemos el vehiculo y sus datos
            database.Remove(vehiculoAEliminar);
            
            
        }
        public void menu()
        {
            database.Add(dato1);
            bool ejecutando = true;
            while (ejecutando)
            {
                Console.WriteLine("Digite 1 para agregar un vehiculo\n Digite 2 para remover un vehiculo\n Digte 3 para consultar la base de datos\n Escriba 'salir' para terminar");
                string consulta = Console.ReadLine();
                switch (consulta)
                {
                    case "salir":
                        ejecutando=false;
                        break;
                    case "1":
                        agregar_vehiculo();
                        break;
                    case "2":
                        borrar_vehiculo();
                        break;
                    case "3":
                        consultar_vehiculo();
                        break;
                    default:
                        Console.WriteLine("Escribe opcion valida");
                        break;
                }
            }
        }

        public void consultar_vehiculo()
        {
            
            Console.WriteLine("Digite placa del vehiculo a consultar o digte 'todo' para ver todos los registros");
            placa = Console.ReadLine();

            foreach (var carro in database)
            {
                if (carro["Placa"].ToString() == placa)
                {
                    foreach (var k in carro)
                    {
                        Console.WriteLine($"{k.Key}: {k.Value}");
                    }
                }
                if (placa == "todo")
                {
                    foreach (var k in carro)
                    {
                        Console.WriteLine($"{k.Key}: {k.Value}");
                    }
                }

            }
            Console.Read();
        }
        public void agregar_vehiculo()
        {
            Dictionary<string, object> nuevo_carro = null;
            bool placaExiste;

            while (true)
            {
                placaExiste = false;

                // Pedimos la placa
                Console.WriteLine("Digite placa del vehiculo o escriba 'salir' para terminar");
                placa = Console.ReadLine();

                // Agregamos opción de salida
                if (placa == "salir")
                {
                    return; // Salimos del método completamente
                }

                // Verificamos si la placa ya existe en la base de datos
                foreach (var carro in database)
                {
                    if (carro["Placa"].ToString() == placa)
                    {
                        placaExiste = true;
                        break;
                    }
                }

                if (!placaExiste)
                {
                    // Si la placa no existe, creamos un nuevo diccionario y salimos del bucle
                    nuevo_carro = new Dictionary<string, object>
            {
                { "Placa", placa }
            };
                    break;
                }
                else
                {
                    // Si la placa existe, pedimos al usuario que ingrese una nueva placa
                    Console.WriteLine("Esta placa ya se encuentra registrada en nuestra base de datos, por favor escriba una valida");
                }
            }

            // Si hemos salido del bucle, completamos el resto de la información del vehículo
            Console.WriteLine("Digite cedula del propietario ");
            cedula = Console.ReadLine();
            nuevo_carro["Cedula"] = cedula;

            Console.WriteLine("Digite marca del vehiculo ");
            marca = Console.ReadLine();
            nuevo_carro["Marca"] = marca;

            Console.WriteLine("Digite modelo del vehiculo ");
            modelo = Console.ReadLine();
            nuevo_carro["Modelo"] = modelo;

            Console.WriteLine("Digite año del vehiculo ");
            anio = int.Parse(Console.ReadLine());
            nuevo_carro["Año"] = anio;

            Console.WriteLine("Digite color del vehiculo ");
            color = Console.ReadLine();
            nuevo_carro["Color"] = color;

            Console.WriteLine("Escriba las fallas, golpes o rayaduras que presenta el vehiculo ");
            fallas = Console.ReadLine();
            nuevo_carro["Fallas"] = fallas;

            // Añadimos el carro nuevo a nuestra base de datos
            database.Add(nuevo_carro);

            Console.WriteLine("Vehículo agregado correctamente.");
            Console.Read();
        }

    }


}
