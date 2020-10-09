using System;

namespace alfabeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LETRA G:");
            int length = 7;
            string asterisco = "*";
            string blanco = " ";
            for (int row = 0; row < length; row++)
            {
                for (int column = 0; column < length; column++)

                {
                    Console.Write(
                        column == 0 ||
                        (column == 6 && row > 2) ||
                        (row == 3 && column > 3) ||
                        row == 0 ||
                        row == 6
                        ? asterisco : blanco);
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("LETRA F:");
            for (int row = 0; row < length; row++)
            {
                for (int column = 0; column < length; column++)
                {
                    Console.Write(
                        row == 0 ||
                        row == 3 ||
                        column == 0
                        ? asterisco : blanco);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
