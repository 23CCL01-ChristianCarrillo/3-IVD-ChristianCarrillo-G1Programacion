using System;

class BuzonDeVozDepartamentos
{
    static void Main()
    {
        int opcion;

        Console.WriteLine("=== Buzón de Voz ===");
        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Recepción");
        Console.WriteLine("3. Dirección");
        Console.WriteLine("4. Compras");
        Console.Write("Seleccione una opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Bienvenido al departamento de Ventas");
                Console.WriteLine("Responsable: Ana López");
                Console.WriteLine("Correo: ventas@empresa.com");
                break;

            case 2:
                Console.WriteLine("Bienvenido al departamento de Recepción");
                Console.WriteLine("Responsable: Carlos Pérez");
                Console.WriteLine("Correo: recepcion@empresa.com");
                break;

            case 3:
                Console.WriteLine("Bienvenido al departamento de Dirección");
                Console.WriteLine("Responsable: María Gómez");
                Console.WriteLine("Correo: direccion@empresa.com");
                break;

            case 4:
                Console.WriteLine("Bienvenido al departamento de Compras");
                Console.WriteLine("Responsable: José Martínez");
                Console.WriteLine("Correo: compras@empresa.com");
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}