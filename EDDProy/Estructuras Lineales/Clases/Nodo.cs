using System;
using System.Collections.Generic;

public class Cola
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

    private Nodo frente;
    private Nodo final;

    public Cola()
    {
        frente = null;
        final = null;
    }

    public bool EstaVacia()
    {
        return frente == null;
    }

    public void Encolar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (EstaVacia())
        {
            frente = nuevo;
            final = nuevo;
        }
        else
        {
            final.Siguiente = nuevo;
            final = nuevo;
        }
    }

    public int Desencolar()
    {
        if (EstaVacia())
        {
            throw new InvalidOperationException("La cola está vacía.");
        }

        int dato = frente.Dato;
        frente = frente.Siguiente;

        if (frente == null)
        {
            final = null;
        }

        return dato;
    }

    public bool Buscar(int dato)
    {
        Nodo actual = frente;
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
        frente = null;
        final = null;
    }

    public List<int> Recorrer()
    {
        List<int> elementos = new List<int>();
        Nodo actual = frente;
        while (actual != null)
        {
            elementos.Add(actual.Dato);
            actual = actual.Siguiente;
        }
        return elementos;
    }
}
