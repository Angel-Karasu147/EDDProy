using System;
using System.Collections.Generic;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Listass_dobles
    {
        private class Nodo
        {
            public int Dato { get; set; }
            public Nodo Siguiente { get; set; }
            public Nodo Anterior { get; set; }

            public Nodo(int dato)
            {
                Dato = dato;
                Siguiente = null;
                Anterior = null;
            }
        }

        private Nodo inicio;
        private Nodo fin;

        public Listass_dobles()
        {
            inicio = null;
            fin = null;
        }

        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (inicio == null) 
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.Siguiente = nuevo;
                nuevo.Anterior = fin;
                fin = nuevo;
            }
        }

        public string ObtenerListaNormal()
        {
            Nodo actual = inicio;
            List<int> valores = new List<int>();

            while (actual != null)
            {
                valores.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return string.Join(", ", valores);
        }

        public string ObtenerListaInversa()
        {
            Nodo actual = fin;
            List<int> valores = new List<int>();

            while (actual != null)
            {
                valores.Add(actual.Dato);
                actual = actual.Anterior;
            }

            return string.Join(", ", valores);
        }

        public bool Eliminar(int valor)
        {
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    if (actual == inicio)
                    {
                        inicio = inicio.Siguiente;
                        if (inicio != null)
                            inicio.Anterior = null;
                    }
                    else if (actual == fin)
                    {
                        fin = fin.Anterior;
                        if (fin != null)
                            fin.Siguiente = null;
                    }
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;
                    }

                    return true;
                }

                actual = actual.Siguiente;
            }

            return false;
        }
    }
}
