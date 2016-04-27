using System;
using TriDLL;

namespace TP2_Multi_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tableau = new double[1000];

            Tri.Initialiser(tableau);


            Console.WriteLine("Sequentiel : ");

            DateTime avant = DateTime.Now;

            Tri.TriRapideSequentiel(tableau);

            DateTime apres = DateTime.Now;

            TimeSpan diff = apres - avant;

            Console.WriteLine(diff);


            Console.WriteLine("");


            Console.WriteLine("Multi Threads : ");

            DateTime avant2 = DateTime.Now;

            TriMultiThreadsPool.TriRapideMultiThreadsPool(tableau);

            DateTime apres2 = DateTime.Now;

            TimeSpan diff2 = apres2 - avant2;

            Console.WriteLine(diff2);


            Console.WriteLine("");


            Console.WriteLine("Multi Threads Pool : ");

            DateTime avant3 = DateTime.Now;

            TriMultiThreadsPool.TriRapideMultiThreadsPool(tableau);

            DateTime apres3 = DateTime.Now;

            TimeSpan diff3 = apres3 - avant3;

            Console.WriteLine(diff3);


            Console.ReadLine();
        }
    }
}
