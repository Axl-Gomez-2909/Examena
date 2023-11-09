using Examena;
using System;

static void Main()
{
    try
    {
        
        string nombreAlumno = "Axel Ricardo Gomez Enamorado";
        string numeroCuenta = "T6211112";
        string email = "ax.gomez0929@gmail.com";
        string nombreClase ="Programación";
        string horaClase = "6:00 a 7:30";
        string nombreCatedratico = "Roger Ivan Gurdian";

        Console.WriteLine("Ingrese las notas del Alumno:");
        Console.Write("Nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        Clase alumnoClase = new Clase(nombreAlumno, numeroCuenta, email, nombreClase, horaClase, nombreCatedratico);
        alumnoClase.mostrarAlumno();
        alumnoClase.mostrarClase();

        Promedio promedio = new Promedio(nota1, nota2, nota3);
        Console.WriteLine(promedio.mostrarPromedio());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ha ocurrido un error: " + ex.Message);
    }
}
Main();
