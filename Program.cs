using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {

            double fahren, graus;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" conversor de graus Fahrenheit para Graus Celsius \n ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" Digite a temperatura em Fahrenheit: ");            
            fahren = Convert.ToDouble(Console.ReadLine());
            graus = (fahren - 32) / 1.8;
            Console.WriteLine($" {fahren}°F equivalente a {graus}°C ");
            Console.ResetColor( );
        }
    }
}
