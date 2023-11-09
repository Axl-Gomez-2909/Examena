using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examena
{
     class Clase : Alumno
    {
        public string nombreClase;
        public string horaClase;
        public string nombreCatedratico;

        public Clase(string nombre, string numeroCuenta, string email, string nombreClase, string horaClase, string nombreCatedratico)
            : base(nombre, numeroCuenta, email)
        {
            this.nombreClase = nombreClase;
            this.horaClase = horaClase;
            this.nombreCatedratico = nombreCatedratico;
        }

        public override void mostrarAlumno()
        {
            Console.WriteLine("");
            Console.WriteLine("Datos del Alumno:");
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Número de Cuenta: " + numeroCuenta);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("");
        }

        public void mostrarClase()
        {
            Console.WriteLine("Datos de la Clase:");
            Console.WriteLine("");
            Console.WriteLine("Nombre de la Clase: " + nombreClase);
            Console.WriteLine("Hora de la Clase: " + horaClase);
            Console.WriteLine("Nombre del Catedrático: " + nombreCatedratico);
            Console.WriteLine("");
        }
    }
}
