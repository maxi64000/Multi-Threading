using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TriDLL
{
    public class TriMultiThreads : Tri
    {
        private static void TriRapideMultiThreads(double[] tableau, int debut, int fin)
        {
            if (debut < fin)
            {
                int indicePivot = Segmenter(tableau, debut, fin);

                Thread thread1 = new Thread(() => TriRapideMultiThreads(tableau, debut, indicePivot - 1));
                Thread thread2 = new Thread(() => TriRapideMultiThreads(tableau, indicePivot +1, fin));

                thread1.Start();
                thread2.Start();

                thread1.Join();
                thread2.Join();
            }
        }

        public static void TriRapideMultiThreads(double[] tableau)
        {
            TriRapideMultiThreads(tableau, 0, tableau.Length - 1);
        }
    }
}
