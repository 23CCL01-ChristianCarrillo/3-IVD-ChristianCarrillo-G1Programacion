using System;

class ValidarContrasena
{
    static void Main()
    {
        string clave;

        Console.Write("Ingrese la contraseña: ");
        clave = Console.ReadLine();

        if (clave == "Password123")
        {
            Console.WriteLine("Bienvenido");
        }
        else
        {
            Console.WriteLine("Ingreso prohibido");
        }
    }
}