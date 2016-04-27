using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Multi_Threads
{
    class FileThreadUnsafe<T>
    {
        readonly object verrou = new object();

        private T[] tab;
        private int tete, queue;

        private void Init()
        {
            lock(verrou)
            {
                tete = queue = -1;
            }
        }

        public FileThreadUnsafe(int taille)
        {
            tab = new T[taille];
            Init();
        }

        public bool Pleine()
        {
            lock(verrou)
            {
                return tete == Suivant(queue);
            }
        }

        private int Suivant(int i)
        {
            lock(verrou)
            {
                return (i + 1) % tab.Length;
            }
        }

        public void Enfiler(T element)
        {
            lock(verrou)
            {
                if (Pleine())
                    throw new ExceptionFilePleine();
                else if (Vide())
                    tab[queue = tete = 0] = element;
                else
                    tab[queue = Suivant(queue)] = element;
            }
        }

        public bool Vide()
        {
            lock (verrou)
            {
                if (tete == queue && queue == -1)
                    return true;
                return false;
            }
        }

        public void Defiler()
        {
            lock(verrou)
            {
                if (Vide())
                {
                    throw new ExceptionFilePleine();
                }
                else if (tete == queue)
                {
                    System.Threading.Thread.Sleep(100);
                    Init();
                }
                else
                {
                    tete = Suivant(tete);
                }
            }     
        }

        public int NbElements()
        {
            lock(verrou)
            {
                if (Vide())
                    return 0;
                else if (tete <= queue)
                    return queue - tete + 1;
                else
                    return tab.Length + queue - tete + 1;
            }
        }

        public T Premier()
        {
            lock (verrou)
            {
                if (Vide())
                {
                    throw new ExceptionFileVide();
                }
                else
                {
                    System.Threading.Thread.Sleep(5000);

                    return tab[tete];
                }
            }
        }
    }

    public class ExceptionFileVide : Exception { }
    public class ExceptionFilePleine : Exception { }
}
