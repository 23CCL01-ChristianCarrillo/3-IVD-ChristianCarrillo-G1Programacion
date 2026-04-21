using System;

class AprobadoReprobado
{
    static void Main()
    {
        double calificacion;

        Console.Write("Ingrese la calificación del alumno: ");
        calificacion = Convert.ToDouble(Console.ReadLine());

        if (calificacion >= 60)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}