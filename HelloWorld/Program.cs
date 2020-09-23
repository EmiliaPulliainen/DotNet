using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero2 = 0;
            

            Console.WriteLine("Anna numero:");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Anna toinen numero:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            int tulos = int.Parse(numero1) + numero2;

            Console.WriteLine("Tulos on " + tulos);
        }
    }
}
