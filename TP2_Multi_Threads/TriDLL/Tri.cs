using System;

namespace TriDLL
{
    public class Tri
    {
        public static void Afficher(double[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("T[{0}] = {1}", i, tableau[i]);
            }
        }

        public static void Initialiser(double[] tableau)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = r.NextDouble();
            }
        }

        public static int Segmenter(double[] tableau, int debut, int fin)
        {
            double valeurPivot = tableau[debut];
            int d = debut + 1;
            int f = fin;
            while (d < f)
            {
                while (d < f && tableau[f] > valeurPivot)
                    f--;
                while (d < f && tableau[d] <= valeurPivot)
                    d++;
                double temp = tableau[d];
                tableau[d] = tableau[f];
                tableau[f] = temp;
            }
            if (tableau[d] > valeurPivot)
                d--;
            tableau[debut] = tableau[d];
            tableau[d] = valeurPivot;
            return d;
        }

        private static void TriRapideSequentiel(double[] tableau, int debut, int fin)
        {
            if (debut < fin)
            {
                int indicePivot = Segmenter(tableau, debut, fin);
                TriRapideSequentiel(tableau, debut, indicePivot - 1);
                TriRapideSequentiel(tableau, indicePivot + 1, fin);
            }
        }

        public static void TriRapideSequentiel(double[] tableau)
        {
            TriRapideSequentiel(tableau, 0, tableau.Length - 1);
        }
    }
}
