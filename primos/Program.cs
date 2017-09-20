using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fin, contador;
            Console.WriteLine("inicio");
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fin");
            fin = Convert.ToInt32(Console.ReadLine());
            for (int i = inicio; i <= fin; i++)
            {
                contador = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("Es primo" + i);
                }
                else
                {
                    Console.WriteLine("Es compuesto" +  i);
                }
         
            }

            Console.ReadKey();
        }
    }
}
