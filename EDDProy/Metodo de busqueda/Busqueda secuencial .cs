using System;
using System.Collections.Generic;

namespace EDDemo.Metodo_de_busqueda
{
    internal class Busqueda_secuenial
    {
        public static int Buscar(List<int> lista, int valor)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == valor)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}
