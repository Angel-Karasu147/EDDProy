using System.Collections.Generic;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class Burbuja
    {
        private List<int> elementos;

        public Burbuja()
        {
            elementos = new List<int>();
        }

      
        public void AgregarElemento(int elemento)
        {
            elementos.Add(elemento);
        }

      
        public List<int> ObtenerElementos()
        {
            return new List<int>(elementos);
        }

       
        public void Ordenar()
        {
            int n = elementos.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (elementos[j] > elementos[j + 1])
                    {
                       
                        int temp = elementos[j];
                        elementos[j] = elementos[j + 1];
                        elementos[j + 1] = temp;
                    }
                }
            }
        }
    }
}
