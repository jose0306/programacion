using System;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola como te llams ?");
            string nombre =Console.ReadLine();
            Console.WriteLine("que edad tienes");
            var edad =Convert.ToInt32( Console.ReadLine());
            var edadamigo=edad+5;
            Console.WriteLine("Hello"+ nombre);
            Console.WriteLine($"hello {nombre}");
        }
    }
}
