using System;
using System.Collections.Generic;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class Quicksort
    {
        private List<int> elementos;

        public Quicksort()
        {
            elementos = new List<int>();
        }

        public void GenerarElementosAleatorios(int cantidad)
        {
            Random random = new Random();
            elementos.Clear(); 

            for (int i = 0; i < cantidad; i++)
            {
                elementos.Add(random.Next(1, 101)); 
            }
        }

        public List<int> ObtenerElementos()
        {
            return new List<int>(elementos); 
        }

        public void Ordenar()
        {
            QuickSortRecursivo(elementos, 0, elementos.Count - 1);
        }

        private void QuickSortRecursivo(List<int> arreglo, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int indicePivote = Particionar(arreglo, inicio, fin);
                QuickSortRecursivo(arreglo, inicio, indicePivote - 1);
                QuickSortRecursivo(arreglo, indicePivote + 1, fin);
            }
        }

        private int Particionar(List<int> arreglo, int inicio, int fin)
        {
            int pivote = arreglo[fin];
            int indice = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (arreglo[j] <= pivote)
                {
                    indice++;
                    Intercambiar(arreglo, indice, j);
                }
            }

            Intercambiar(arreglo, indice + 1, fin);
            return indice + 1;
        }

        private void Intercambiar(List<int> arreglo, int i, int j)
        {
            int temp = arreglo[i];
            arreglo[i] = arreglo[j];
            arreglo[j] = temp;
        }
    }
}
