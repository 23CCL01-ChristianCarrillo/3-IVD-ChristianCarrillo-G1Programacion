using System;

class PromedioAlumno
{
    static void Main()
    {
        double cal1, cal2, cal3, cal4, cal5, promedio;

        Console.Write("Ingrese la primera calificación: ");
        cal1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda calificación: ");
        cal2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera calificación: ");
        cal3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cuarta calificación: ");
        cal4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la quinta calificación: ");
        cal5 = Convert.ToDouble(Console.ReadLine());

        promedio = (cal1 + cal2 + cal3 + cal4 + cal5) / 5;

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 60)
        {
            Console.WriteLine("El alumno APRUEBA");
        }
        else
        {
            Console.WriteLine("El alumno REPRUEBA");
        }
    }
}