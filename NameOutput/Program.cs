using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            int lowerBorder = 2;
            int centerLine = 1;
            int zeroLinePosition = 0;
            int currentLineTop;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите сивол: ");
            symbol = Console.ReadLine()[0];
            currentLineTop = Console.GetCursorPosition().Top;

            for (int i = 0; i <= name.Length+1; i++)
            {
                Console.SetCursorPosition(i, currentLineTop);
                Console.Write(symbol);
                Console.SetCursorPosition(i, currentLineTop + lowerBorder);
                Console.Write(symbol);
            }

            Console.SetCursorPosition(zeroLinePosition, currentLineTop + centerLine);
            Console.Write($"{symbol}{name}{symbol}");
            Console.SetCursorPosition(zeroLinePosition, currentLineTop + centerLine + lowerBorder);
        }
    }
}
