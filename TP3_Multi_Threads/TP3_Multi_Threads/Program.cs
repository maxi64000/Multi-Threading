using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP3_Multi_Threads
{
    class Program
    {
        static FileThreadUnsafe<int> f;

        public static void Thread1Function()
        {
            Console.WriteLine(f.NbElements());
            if (!f.Vide())
            {
                f.Defiler();
            }
        }

        public static void Thread2Function()
        {
            Console.WriteLine(f.NbElements());
            while (!f.Vide())
            {
                Console.WriteLine(f.Premier());
            }
        }

        static void Main(string[] args)
        {
            f = new FileThreadUnsafe<int>(10);

            //for (int i = 1; i <= 2; i++)
            //{
            //    f.Enfiler(1);
            //}

            //Console.WriteLine("Nombre d'éléments : " + f.NbElements());

            //while (!f.Vide())
            //{
            //    Console.WriteLine(f.Premier());
            //    f.Defiler();
            //}

            f.Enfiler(1);

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.ReadLine();
        }
    }
}
