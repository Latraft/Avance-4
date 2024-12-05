using System.Collections.Generic;

public class Pilas
{
    public Stack<int> pila;

    public Pilas()
    {
        pila = new Stack<int>();
    }

    public void Push(int dato)
    {
        pila.Push(dato);
    }

    public int Pop()
    {
        return pila.Count > 0 ? pila.Pop() : -1; 
    }

    
    public string Mostrar()
    {
        if (pila.Count == 0)
        {
            return "La pila está vacía.";
        }

        
        return string.Join(", ", pila);
    }
}

