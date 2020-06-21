using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndMultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            escribeUnaLetraX();
            escribeUnaLetraY();
            Console.ReadKey();*/
            
            
            Thread t = new Thread(escribeUnaLetraY);
            t.Start();
            escribeUnaLetraX();
            Console.ReadKey();
        }
        static void escribeUnaLetraX()
        {
            escribeUnaLetra('X');
        }
        static void escribeUnaLetraY()
        {
            escribeUnaLetra('Y');
        }
        static void escribeUnaLetra(Char letra)
        {
            /*for (int i = 0; i < 1000; i++) Console.Write(letra);*/
            
            Parallel.For(0, 1000, i =>
            {
                Console.Write(letra);
                i++;
            });
        }
    }
}
