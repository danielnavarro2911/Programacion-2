using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_def
{
    // Clase Alumno
    public class Alumno
    {
        public string NumeroIdentificacion;
        public string NombreCompleto;
        public string FechaNacimiento;
        public string Direccion;
        List<String> list = new List<String>();

        // pedimos datos de estudiante
        public List<string> RegistrarAlumno()
        {
            

            Console.WriteLine("\nRegistro del Estudiante\n");

            Console.Write("Numero de identificacion: ");
            NumeroIdentificacion = Console.ReadLine();

            Console.Write("Nombre completo: ");
            NombreCompleto = Console.ReadLine();

            Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
            FechaNacimiento = Console.ReadLine();

            Console.Write("Direccion: ");
            Direccion = Console.ReadLine();

            Console.WriteLine("\nLos datos han sido registrados exitosamente.");

            list.Add(NumeroIdentificacion);
            list.Add(NombreCompleto);
            list.Add(FechaNacimiento);
            list.Add(Direccion);
            return list;
        }
        //metodo para mostrar los datos
        public void mostrar_datos()
        {
            Console.WriteLine("Datos estudiante");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }

    // Clase PadreTutor
    public class PadreTutor
    {
        public string NombreCompleto;
        public string Cedula;
        public string Direccion;
        public string NumeroTelefono;
        public string CorreoElectronico;
        public string RelacionConAlumno;
        public string SegundoEncargado;
        List<String> list = new List<String>();

        //metodo para registrar padre
        public List<string> RegistrarPadreTutor()
        {
            

            Console.WriteLine("\nRegistro del Padre, Madre o Tutor\n");

            Console.Write("Nombre completo: ");
            NombreCompleto = Console.ReadLine();

            Console.Write("Cedula: ");
            Cedula = Console.ReadLine();

            Console.Write("Direccion: ");
            Direccion = Console.ReadLine();

            Console.Write("Numero de telefono: ");
            NumeroTelefono = Console.ReadLine();

            Console.Write("Correo electronico: ");
            CorreoElectronico = Console.ReadLine();

            Console.Write("Relacion con el estudiante: ");
            RelacionConAlumno = Console.ReadLine();

            Console.Write("Nombre de persona autorizada para retirar: ");
            SegundoEncargado = Console.ReadLine();

            Console.WriteLine("\nLos datos han sido registrados exitosamente.\n");

            list.Add(NombreCompleto);
            list.Add(Cedula);
            list.Add(Direccion);
            list.Add(NumeroTelefono);
            list.Add(CorreoElectronico);
            list.Add(RelacionConAlumno);
            list.Add(SegundoEncargado);

            return list;
        }
        // metodo para mostrar datos
        public void mostrar_datos()
        {
            Console.WriteLine("Datos padre");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
