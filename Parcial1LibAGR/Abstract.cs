using Parcial1LibAGR;
using System;
using System.Collections.Generic;
using System.Text;


}

Empleado empleado = new EmpleadoConcreto();
empleado.nombre = "Juan Perez";
empleado.salarioBase = 2000;
empleado.obtenerInformacion();

Console.WriteLine($"Nombre: {empleado.nombre}");