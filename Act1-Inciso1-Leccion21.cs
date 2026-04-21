using System;

class DiaDeLaSemanaTexto
{
    static void Main()
    {
        int dia;

        Console.Write("Ingrese un número del 1 al 7: ");
        dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Hoy es lunes");
                break;
            case 2:
                Console.WriteLine("Hoy es martes");
                break;
            case 3:
                Console.WriteLine("Hoy es miércoles");
                break;
            case 4:
                Console.WriteLine("Hoy es jueves");
                break;
            case 5:
                Console.WriteLine("Hoy es viernes");
                break;
            case 6:
                Console.WriteLine("Hoy es sábado");
                break;
            case 7:
                Console.WriteLine("Hoy es domingo");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}