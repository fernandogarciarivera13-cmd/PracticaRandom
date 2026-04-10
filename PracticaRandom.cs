using System;

class PracticaRandom
{
    static void Main()
    {
        Random rnd = new Random();
        int a, b, c, suma;
        int intentos = 0;

        do
        {
            intentos++;

            a = rnd.Next(1, 101); // Genera número entre 1 y 100
            b = rnd.Next(1, 101);
            c = rnd.Next(1, 101);

            suma = a + b + c;

            Console.WriteLine($"Intento {intentos}: Números -> {a}, {b}, {c} | Suma: {suma}");
        }
        while (suma != 100);

        Console.WriteLine("\n¡La suma de los tres números es 100!");
        Console.WriteLine($"Se logró en {intentos} intentos.\n");

        // Imprimir caracteres con ciclos for
        Console.WriteLine($"a = {a} ");
        for (int i = 0; i < a; i++)
        {
            Console.Write("☺");
        }
        Console.WriteLine("\n");

        Console.WriteLine($"b = {b} ");
        for (int i = 0; i < b; i++)
        {
            Console.Write("♥");
        }
        Console.WriteLine("\n");

        Console.WriteLine($"c = {c} ");
        for (int i = 0; i < c; i++)
        {
            Console.Write("♪");
        }
        Console.WriteLine("\n");
    }
}
