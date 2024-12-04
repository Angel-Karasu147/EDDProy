using System.Collections.Generic;

public class Pilas
{
    private Stack<string> stack = new Stack<string>();

    
    public void Agregar(string elemento)
    {
        stack.Push(elemento);
    }

    public string Eliminar()
    {
        return stack.Count > 0 ? stack.Pop() : null;
    }

    public string ObtenerEstado()
    {
        return stack.Count > 0 ? string.Join(", ", stack) : "La pila está vacía.";
    }
}
