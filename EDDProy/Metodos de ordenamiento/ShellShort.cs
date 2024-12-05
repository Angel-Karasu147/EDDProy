using System.Collections.Generic;

namespace EDDemo.Metodos_de_busqueda
{
    internal class ShellShort
    {
        private List<int> elementos;

        public ShellShort()
        {
            elementos = new List<int>();
        }

        
        public void AgregarElemento(int elemento)
        {
            elementos.Add(elemento);
        }

        
        public string ObtenerElementos()
        {
            return string.Join(", ", elementos);
        }

       
        public void Ordenar()
        {
            int n = elementos.Count;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = elementos[i];
                    int j = i;

                    while (j >= gap && elementos[j - gap] > temp)
                    {
                        elementos[j] = elementos[j - gap];
                        j -= gap;
                    }

                    elementos[j] = temp;
                }
                gap /= 2;
            }
        }
    }
}
