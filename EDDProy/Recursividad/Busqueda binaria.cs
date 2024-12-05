using System;

namespace EDDemo.Recursividad
{
    internal class Busqueda_binaria
    {
        public int Buscar(int[] arreglo, int inicio, int fin, int dato)
        {
            if (inicio > fin) return -1; 

            int medio = (inicio + fin) / 2;

            if (arreglo[medio] == dato) return medio; 
            if (arreglo[medio] > dato)
                return Buscar(arreglo, inicio, medio - 1, dato); 
            else
                return Buscar(arreglo, medio + 1, fin, dato); 
        }
    }
}
