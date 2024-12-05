using System;
using System.Collections.Generic;

namespace EDDemo.Metodo_de_busqueda
{
    internal class Busqueda_binaria_no_recursiva
    {
        public static int Buscar(List<int> lista, int valor)
        {
            int inicio = 0;
            int fin = lista.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (lista[medio] == valor)
                {
                    return medio; 
                }
                else if (lista[medio] < valor)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return -1; 
        }
    }
}
