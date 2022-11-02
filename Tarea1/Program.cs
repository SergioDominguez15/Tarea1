using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static Empleado empleado;
        static void Main(string[] args)
        {

            int opcion;
            bool terminado = false;


            while (!terminado)
            {
                try
                {

                    Console.WriteLine("\n\n0 - Salir\r\n1 - Crear empleado\r\n2 - Actualizar salario\r\n3 – Mostrar nombre\r\n4 - Mostrar NIF\r\n5" +
                                      " - Actualizar NIF\r\n6 - Mostrar edad\r\n7 – Mostrar empleado");

                    Console.Write("\nIntroduzca su opción: ");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {

                        case 0:
                            terminado = true;
                            break;

                        case 1:
                            CrearEmpleado();
                            break;

                        case 2:
                            ActualizarSalario();
                            break;

                        case 3:
                            MostrarNombre();
                            break;

                        case 4:
                            MostrarNIF();
                            break;

                        case 5:
                            ActualizarNIF();
                            break;

                        case 6:
                            MostrarEdad();
                            break;

                        case 7:
                            MostrarEmpleado();
                            break;

                        default:
                            Console.WriteLine("Por favor, introduce una opción válida");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("\nTipo de dato mal introducido");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nDato Introducido demasiado grande");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("\nDebes crear un usuario");
                }
            }

        }

        static void MostrarEmpleado()
        {
            Console.Write($"Nombre: {empleado.Nombre} \nEdad: {empleado.Edad} años\nNIF: {empleado.Nif}\nSalario:{empleado.Salario}€");
        }


        static void MostrarEdad()
        {
            Console.WriteLine(empleado.Edad);
        }

        static void ActualizarNIF()
        {
            try
            {
                Console.Write("Introduce el nuevo NIF: ");
                string nif = Console.ReadLine();
                empleado.Nif = nif;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de dato mal introducido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nDato Introducido demasiado grande");
            }

        }

        static void MostrarNIF()
        {
            Console.WriteLine(empleado.Nif);
        }

        static void MostrarNombre()
        {
            Console.WriteLine(empleado.NombreCompleto(empleado.Nombre, empleado.Apellido1, empleado.Apellido2));
        }

        static void ActualizarSalario()
        {
            try
            {
                Console.Write("Introduce el nuevo salario: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                empleado.Salario = salario;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de dato mal introducido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nDato Introducido demasiado grande");
            }


        }

        static void CrearEmpleado()
        {
            try
            {
                Console.Write("\nIntroduce un nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Introduce un primer apellido: ");
                string apellido1 = Console.ReadLine();

                Console.Write("Introduce un segundo apellido: ");
                string apellido2 = Console.ReadLine();

                Console.Write("Introduce una edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduce un nif: ");
                string nif = Console.ReadLine();

                Console.Write("Introduce un salario: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                empleado = new Empleado(nombre, apellido1, apellido2, edad, nif, salario); ;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de dato mal introducido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nDato Introducido demasiado grande");
            }
        }
    }
}


