using System;
using System.Collections.Generic;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Listas
    {
        private class Nodo
        {
            public int Dato { get; set; }
            public Nodo Siguiente { get; set; }

            public Nodo(int dato)
            {
                Dato = dato;
                Siguiente = null;
            }
        }

        private Nodo cabeza;

        public Listas()
        {
            cabeza = null;
        }

        
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        
        public bool Eliminar(int dato)
        {
            if (cabeza == null)
            {
                return false;
            }

            if (cabeza.Dato == dato)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }

            return false;
        }

        
        public bool Buscar(int dato)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == dato)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

       
        public void Limpiar()
        {
            cabeza = null;
        }

      
        public List<int> Recorrer()
        {
            List<int> elementos = new List<int>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                elementos.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return elementos;
        }
    }
}
