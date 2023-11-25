﻿using Copia_practica_2;

// Para visualizar mi menú
bool encendido = true;

if (encendido)
{
    while (encendido)
    {
        Console.Clear();
        Console.WriteLine("         ╔══════════════════════════════════════════════════╗");
        Console.WriteLine("         ║                                                  ║");
        Console.WriteLine("         ║                      Menú                        ║");
        Console.WriteLine("         ║              Opciones de compra                  ║");
        Console.WriteLine("         ║              1.Sedán                             ║");
        Console.WriteLine("         ║              2.Moto                              ║");
        Console.WriteLine("         ║              3.Coupé/Sport                       ║");
        Console.WriteLine("         ║              4.Camionetas                        ║");
        Console.WriteLine("         ║              5.Detener programa                  ║");
        Console.WriteLine("         ║                                                  ║");
        Console.WriteLine("         ╠══════════════════════════════════════════════════╣");
        Console.Write("\nElija: ");
        int opcion = int.Parse(Console.ReadLine());
        Console.Clear();

        //completar el menú
        if (opcion == 5)
        {
            Console.Clear();
            Console.WriteLine("         ╔════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("         ║                                                                                                ║");
            Console.WriteLine("         ║          Gracias por utilizar el Sistema de Inscripción de Estudiantes. ¡Hasta luego!          ║");
            Console.WriteLine("         ║                                                                                                ║");
            Console.WriteLine("         ╠════════════════════════════════════════════════════════════════════════════════════════════════╣");
            break;
        }

        IVehiculos auto = CFabrica.GetVehiculos(opcion); // llamada a la fábrica

        auto.CrearAuto(); // implementación de la interfaz

    }
}


