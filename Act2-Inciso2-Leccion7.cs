using System;

class ClasificarCalificacion
{
    static void Main()
    {
        double calificacion;

        Console.Write("Ingrese la calificación: ");
        calificacion = Convert.ToDouble(Console.ReadLine());

        if (calificacion < 60)
        {
            Console.WriteLine("Deficiente");
        }
        else if (calificacion < 70)
        {
            Console.WriteLine("Regular");
        }
        else if (calificacion < 80)
        {
            Console.WriteLine("Bien");
        }
        else if (calificacion < 90)
        {
            Console.WriteLine("Muy bien");
        }
        else
        {
            Console.WriteLine("Excelente");
        }
    }
}