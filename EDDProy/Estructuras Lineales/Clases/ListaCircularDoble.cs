namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Nodo
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

    internal class Lista_circular_doble
    {
        private Nodo cabeza;

        public Lista_circular_doble()
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
                cabeza.Anterior = cabeza;
            }
            else
            {
                Nodo ultimo = cabeza.Anterior;
                nuevo.Siguiente = cabeza;
                nuevo.Anterior = ultimo;
                cabeza.Anterior = nuevo;
                ultimo.Siguiente = nuevo;
            }
        }
        public string VerLista()
        {
            if (cabeza == null) return "La lista está vacía.";

            Nodo actual = cabeza;
            string resultado = "";
            do
            {
                resultado += actual.Dato + " ";
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return resultado.Trim();
        }

        public Nodo Buscar(int dato)
        {
            if (cabeza == null) return null;

            Nodo actual = cabeza;
            do
            {
                if (actual.Dato == dato) return actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return null;
        }

        public bool Eliminar(int dato)
        {
            if (cabeza == null) return false;

            Nodo actual = cabeza;
            do
            {
                if (actual.Dato == dato)
                {
                    if (actual == cabeza && cabeza.Siguiente == cabeza)
                    {
                        cabeza = null; // Si es el único nodo
                    }
                    else
                    {
                        Nodo anterior = actual.Anterior;
                        Nodo siguiente = actual.Siguiente;
                        anterior.Siguiente = siguiente;
                        siguiente.Anterior = anterior;
                        if (actual == cabeza) cabeza = siguiente;
                    }
                    return true;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return false;
        }

        public void CrearListaVacia()
        {
            cabeza = null;
        }
    }
}