using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Empleados_practica1
{
    //TODO Clase base "Empleado", que define las propiedades comunes de un empleado
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        //TODO Constructor que inicializa las propiedades de un empleado
        public Empleado(string nombre, string apellido, int edad, string cargo, decimal salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            Salario = salario;
        }
    }


}
