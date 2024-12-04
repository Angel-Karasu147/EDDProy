using System;
using System.Text;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Listas_circulares
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

        public Listas_circulares()
        {
            cabeza = null;
        }

       
        public void CrearLista()
        {
            cabeza = null;
        }

       
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Siguiente = cabeza;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != cabeza)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = cabeza;
            }
        }

        
        public string VerLista()
        {
            if (cabeza == null)
            {
                return "(vacía)";
            }

            StringBuilder sb = new StringBuilder();
            Nodo actual = cabeza;

            do
            {
                sb.Append(actual.Dato + " -> ");
                actual = actual.Siguiente;
            } while (actual != cabeza);

            sb.Append("(circular)");
            return sb.ToString();
        }

        
        public bool Buscar(int dato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            do
            {
                if (actual.Dato == dato)
                {
                    return true;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

        
        public bool Eliminar(int dato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            Nodo anterior = null;

            do
            {
                if (actual.Dato == dato)
                {
                    if (anterior == null) 
                    {
                        if (actual.Siguiente == cabeza) 
                        {
                            cabeza = null;
                        }
                        else
                        {
                            Nodo temp = cabeza;
                            while (temp.Siguiente != cabeza)
                            {
                                temp = temp.Siguiente;
                            }
                            temp.Siguiente = cabeza.Siguiente;
                            cabeza = cabeza.Siguiente;
                        }
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

       
        public bool Modificar(int datoViejo, int datoNuevo)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;

            do
            {
                if (actual.Dato == datoViejo)
                {
                    actual.Dato = datoNuevo;
                    return true;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }
    }
}
