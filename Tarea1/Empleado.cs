using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Empleado
    {
        internal string Nombre;
        internal string apellido1;
        internal string apellido2;
        internal int edad;
        internal string nif;
        internal Double salario;

        public Empleado()
        {
        }

        public Empleado(string nombre, string apellido1, string apellido2, int edad, string nif, Double salario)
        {
            this.Nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.nif = nif;
            this.salario = salario;

        }



    }
}
