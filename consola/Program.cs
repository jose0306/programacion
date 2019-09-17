using System;
using System.Collections.Generic;
using System.Linq;
namespace consola
{
    class Program
    {
        static void Main(string[] args)
        { 
        /*
         Console.WriteLine("Hola como te llams ?");
            string nombre =Console.ReadLine();
            Console.WriteLine("que edad tienes");
            var edad =Convert.ToInt32( Console.ReadLine());
            var edadamigo=edad+5;
            Console.WriteLine("Hello"+ nombre);
            Console.WriteLine($"hello {edadamigo}");
         */
           /* var lista =new List <string> {
                "Manzana", "Uva", "Piña", "Naranja", "Pera",
                "Plátano", "Granadilla", "Melón", "Papaya"};
            var frutasP=lista.Where(x => x.StartsWith("p"));
            foreach(var x in frutasP){
                Console.WriteLine(x);
            }
            var primera=frutasP.First();
            var ultima=frutasP.Last();
            Console.WriteLine(primera);
            Console.WriteLine(primera);*/
            
            var lista = new List<int> { 15, 20, 8, 13, 12, 15, 15, 20, 0, 6, 12 };
            int sum=0;
            var aprobados = lista.Where(x => x > 10);
            for(int i=0;i<lista.Count();i++) {
                 sum=sum+lista[i];
            }
            double prom=sum/lista.Count();           
                        
            Console.WriteLine(prom);
        }
    }
}
