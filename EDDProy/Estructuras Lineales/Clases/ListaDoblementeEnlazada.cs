using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    public class NodoListaDoble
    {
        public int Dato;
                public NodoListaDoble Sig;
        public NodoListaDoble Ant;
    }

    public class ListaDoblementeEnlazada
    {
        private NodoListaDoble cabeza = null;

     
        public void Agregar(int dato)
        {
            NodoListaDoble nuevo = new NodoListaDoble
            {
                Dato = dato,
                Sig = null,
                Ant = null
            };

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoListaDoble actual = cabeza;
                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                actual.Sig = nuevo;
        
                nuevo.Ant = actual;
            }
            Console.WriteLine($"Se agregó el dato {dato} a la lista doblemente enlazada.");
        }

        public void Eliminar(int dato)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoListaDoble actual = cabeza;
            while (actual != null && actual.Dato != dato)
            {
                actual = actual.Sig;
            }

            if (actual == null)
            {
                Console.WriteLine($"El dato {dato} no se encontró en la lista.");
                return;
            }

            if (actual.Ant == null)
            {
                cabeza = actual.Sig;
                if (cabeza != null) cabeza.Ant = null;
            }
            else
            {
                actual.Ant.Sig = actual.Sig;
                if (actual.Sig != null)
                {
                    actual.Sig.Ant = actual.Ant;
                }
            }

            Console.WriteLine($"Se eliminó el dato {dato} de la lista doblemente enlazada.");
        }

        public string MostrarDesdeInicio()
        {
            if (cabeza == null)
            {
                return "La lista está vacía.";
            }

            NodoListaDoble actual = cabeza;
            string resultado = "Elementos de la lista (desde el inicio): ";

            while (actual != null)
            {
                resultado += actual.Dato + " <-> ";
                actual = actual.Sig;
            }
            resultado += "null";

            return resultado;
        }

        
        public string MostrarDesdeFinal()
        {
            if (cabeza == null)
            {
                return "La lista está vacía.";
            }

           
            NodoListaDoble actual = cabeza;
            while (actual.Sig != null)
            {
                actual = actual.Sig;
            }

            
            string resultado = "Elementos de la lista (desde el final): ";
            while (actual != null)
            {
                resultado += actual.Dato + " <-> ";
                actual = actual.Ant;
            }
            resultado += "null";

            return resultado;
        }
    }
}

