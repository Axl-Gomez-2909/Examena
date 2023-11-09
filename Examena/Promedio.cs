using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examena
{
    class Promedio : Promediointerfaz
    {
        private double nota1;
        private double nota2;
        private double nota3;

        public Promedio(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public string mostrarPromedio()
        {
            return "Promedio: " + calcularPromedio().ToString();
        }

        public string mostrarPromedio(double nota1, double nota2, double nota3)
        {
            return "Promedio: " + calcularPromedio(nota1, nota2, nota3).ToString();
        }

        public double calcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public double calcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
   
}
