using System;

namespace Estructuras
{
    public class NodoListaCircularDoble
    {
        public int Dato;
        public NodoListaCircularDoble Sig;
        public NodoListaCircularDoble Ant;
    }

    public class ListaCircularDoble
    {
        private NodoListaCircularDoble cabeza = null;

        public void Agregar(int dato)
        {
            NodoListaCircularDoble nuevo = new NodoListaCircularDoble { Dato = dato, Sig = null, Ant = null };

            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Sig = cabeza;
                cabeza.Ant = cabeza;
            }
            else
            {
                NodoListaCircularDoble ultimo = cabeza.Ant;
                ultimo.Sig = nuevo;
                nuevo.Ant = ultimo;
                nuevo.Sig = cabeza;
                cabeza.Ant = nuevo;
            }
            Console.WriteLine($"Se agregó el dato {dato} a la lista circular doblemente encadenada.");
        }

        public void Eliminar(int dato)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoListaCircularDoble actual = cabeza;

            do
            {
                if (actual.Dato == dato)
                {
                    if (actual == cabeza && actual.Sig == cabeza)
                    {
                        cabeza = null;
                    }
                    else
                    {
                        actual.Ant.Sig = actual.Sig;
                        actual.Sig.Ant = actual.Ant;
                        if (actual == cabeza)
                        {
                            cabeza = actual.Sig;
                        }
                    }
                    Console.WriteLine($"Se eliminó el dato {dato} de la lista circular doblemente encadenada.");
                    return;
                }
                actual = actual.Sig;
            } while (actual != cabeza);

            Console.WriteLine($"El dato {dato} no se encontró en la lista.");
        }

        public string Mostrar()
        {
                if (cabeza == null)
                {
                    Console.WriteLine("La lista está vacía.");
                    return "La lista está vacía.";
                }

                NodoListaCircularDoble actual = cabeza;
                string resultado = "Elementos de la lista circular doblemente encadenada: ";

                do
                {
                    resultado += actual.Dato + " <-> ";
                    actual = actual.Sig;
                } while (actual != cabeza);

                resultado += "(de vuelta a la cabeza)";
                Console.WriteLine(resultado);
                return resultado; 
            }
        }
    }

