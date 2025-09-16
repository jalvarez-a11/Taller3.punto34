using System;
using MatrixExample;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz (impar recomendado): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

        // Si quieres forzar impar: if (n % 2 == 0) n++;

        var m = new HourglassMatrix(n);
        m.Fill();

        Console.WriteLine("\nMATRIZ COMPLETA\n");
        m.Print();

        m.PrintHourglass();

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}



