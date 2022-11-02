///////////////////////////////////////////
// Tarea: UD2T1
// Alumno/a: Sergio Dominguez Gomez
// Curso: 2022/2023
///////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Empleado
    {
        string nombre;
        string apellido1;
        string apellido2;
        int edad;
        string nif;
        double salario;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public Empleado(string nombre, string apellido1, string apellido2, int edad, string nif, double salario)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.nif = nif;
            this.salario = salario;
        }


        public String NombreCompleto(string nombre, string apellido1, string apellido2)
        {
            return $"{nombre} {apellido1} {apellido2}";
        }

    }
}
