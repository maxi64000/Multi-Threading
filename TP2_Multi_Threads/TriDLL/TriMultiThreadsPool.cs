using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TriDLL
{
    public class TriMultiThreadsPool : TriMultiThreads
    {
        private static int TriRapideMultiThreadsPool(double[] tableau, int debut, int fin)
        {
            if (debut < fin)
            {
                int indicePivot = Segmenter(tableau, debut, fin);

                Task<int> thread1 = new Task<int>(() => TriRapideMultiThreadsPool(tableau, debut, indicePivot - 1));
                Task<int> thread2 = new Task<int>(() => TriRapideMultiThreadsPool(tableau, indicePivot + 1, fin));

                thread1.Start();
                thread2.Start();

                return thread1.Result + thread2.Result;
            }
            else
            {
                return 0;
            }
        }

        public static void TriRapideMultiThreadsPool(double[] tableau)
        {
            TriRapideMultiThreadsPool(tableau, 0, tableau.Length - 1);
        }
    }
}
