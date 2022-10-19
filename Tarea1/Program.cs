using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Empleado e1 = new Empleado();

            do
            {
                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Crear empleado");
                Console.WriteLine("2 - Actualizar salario");
                Console.WriteLine("3 - Mostrar nombre");
                Console.WriteLine("4 - Mostrar NIF");
                Console.WriteLine("5 - Actualizar NIF");
                Console.WriteLine("6 - Mostrar edad");
                Console.WriteLine("7 - Mostrar empleado");
                Console.WriteLine();
                Console.Write("Introduzca su opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        CrearEmpleado();
                        break;
                    case 2:
                        Console.Write("Ingrese nuevo salario: ");
                        e1.salario = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Nombre: {0}", e1.Nombre);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("NIF: {0}", e1.nif);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Write("Ingrese nuevo NIF: ");
                        e1.nif = Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Edad: {0}", e1.edad, "años");
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine(e1);
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
        public static void CrearEmpleado()
        {

            Console.WriteLine("Introduzca el nombre:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el primer apellido:");
            string apellido1 = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo apellido:");
            string apellido2 = Console.ReadLine();
            Console.WriteLine("Introduzca la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el NIF:");
            string nif = Console.ReadLine();
            Console.WriteLine("Introduzca el salario:");
            int salario = int.Parse(Console.ReadLine());
            Empleado e1 = new Empleado(Nombre, apellido1, apellido2, edad, nif, salario);
        }
    }
}
    

