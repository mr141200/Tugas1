using System;

namespace PerancanganAnalisa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 12;
            int c = 5;

            Console.WriteLine("\n\nNama : Misbah Ramadhani");
            Console.WriteLine("Tugas 1");
            Console.WriteLine("Jawaban :");
            Console.WriteLine($"No 1 = {jawab1(a, b, c)} ");
            Console.WriteLine($"No 2 = {jawab2(a, b, c)} ");
            Console.WriteLine($"No 3 = {jawab3(a, b, c)} ");
            Console.WriteLine($"No 4 = {jawab4(a, b, c)} ");
            Console.WriteLine("\n\nTekan tombol apapun untuk keluar .. ");

            Console.ReadKey(); 
        }
        private static float jawab1(float a, float b, float c)
        {
            float x = 0;
            float x1 = a / b;
            float x2 = c % 2;
            x = x1 + x2;
            return x;
        }

        private static float jawab2(float a, float b, float c)
        {
            float x = 0;
            float x1 = a / b;
            float x2 = c / 2;
            x = x1 + x2;
            return x;
        }
        private static float jawab3(float a, float b, float c)
        {
            float x = 0;
            float x1 = b + c;
            float x2 = a / x1;
            x = x2 % 2;
            return x;
        }
        private static float jawab4(float a, float b, float c)
        {
            float x = 0;
            float x1 = b + c;
            float x2 = a * x1;
            x = x2 + 2;
            return x;
        }
    }
}
