using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_Empleados_practica1;

namespace tecnico
{
    //TODO Clase "Tecnico" que hereda de "Empleado"
    public class Tecnico : Empleado
    {
        //TODO Constructor que llama al constructor base de la clase "Empleado"
        public Tecnico(string nombre, string apellido, int edad, string cargo, decimal salario)
            : base(nombre, apellido, edad, cargo, salario) { }
    }
}
