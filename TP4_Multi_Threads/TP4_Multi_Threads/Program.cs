using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Multi_Threads
{
    class Program
    {
        static void PrintArray(double[] tableau)
        {
            string printTableau = "";

            for (var i = 0; i < tableau.Length; i++)
            {
                if (i == 0)
                {
                    printTableau += "|" + tableau[i];
                }
                else if (i == tableau.Length - 1)
                {
                    printTableau += tableau[i] + "|";
                }
                else
                {
                    printTableau += "|" + tableau[i] + "|";
                }
            }

            Console.WriteLine(printTableau);
        }

        static void TriSelectionPermutation(double[] tableau)
        {
            int i, iRech, iMin;
            double tmp;
            int N = tableau.Length;
            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                    if (tableau[iRech] < tableau[iMin])
                        iMin = iRech;
            if (iMin != i)
                {
                    tmp = tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }
            }
        }

        static void Main(string[] args)
        {
            double[] tableau = new double[] { 9, 1, 2, 0, 4, 5, 6, 7, 8, 3 };

            PrintArray(tableau);

            TriSelectionPermutation(tableau);

            PrintArray(tableau);

            Console.ReadLine();
        }
    }
}
