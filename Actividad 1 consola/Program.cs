using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir variables
            string Nombre;
            short Edad;
            DateTime FechaNacimiento;
            string Carrera;

            //Mensaje de bienvenida
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");

            //Datos requeridos
            Console.WriteLine("\n\nIngrese su nombre completo:");
            Nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese su edad:");
            Edad = short.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese su fecha de nacimiento (formato: dd/mm/yy):");
            FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el nombre de la carrera a la que desea ingresar:");
            Carrera = Console.ReadLine();
                       
            Console.WriteLine("\n\nGracias, " + Nombre);
            Console.WriteLine("por formar parte de UMI/Universidad Coppel.");
            Console.WriteLine("\nBienvenid@ a la carrera: " + Carrera);

            //Salida
            Console.WriteLine("\n\nPresione enter para salir.");
            Console.WriteLine();
        }
    }
}
