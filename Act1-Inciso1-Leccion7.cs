using System;
using System.Collections.Generic;

class BuzonVoz
{
    static void Main()
    {
        List<string> mensajes = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("=== Buzón de Voz ===");
            Console.WriteLine("1. Dejar un mensaje");
            Console.WriteLine("2. Escuchar mensajes");
            Console.WriteLine("3. Borrar mensajes");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida.\n");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Escriba su mensaje:");
                    string mensaje = Console.ReadLine();
                    mensajes.Add(mensaje);
                    Console.WriteLine("Mensaje guardado.\n");
                    break;

                case 2:
                    if (mensajes.Count == 0)
                    {
                        Console.WriteLine("No hay mensajes.\n");
                    }
                    else
                    {
                        Console.WriteLine("Mensajes:");
                        for (int i = 0; i < mensajes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {mensajes[i]}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    mensajes.Clear();
                    Console.WriteLine("Todos los mensajes han sido eliminados.\n");
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar el sistema.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }

        } while (opcion != 4);
    }
}