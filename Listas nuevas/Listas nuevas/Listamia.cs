using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas_nuevas
{
    class Listamia
    {
        protected Nodo Pivote;
        protected Nodo Trabajo;
        protected Nodo Apoyo;

        public Listamia()
        {
            Pivote = new Nodo();
            Pivote.Next = null;
        }

        public void MirarLista()
        {
            Trabajo = Pivote;
            while (Trabajo.Next != null)
            {
                Trabajo = Trabajo.Next;
                Console.WriteLine(Trabajo.ToString());
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void add(object Elemento)
        {
            Trabajo = Pivote;
            while (Trabajo.Next != null)
            {
                Trabajo = Trabajo.Next;
            }
            Nodo NuevaCadena = new Nodo();
            NuevaCadena.Dato = Elemento;
            NuevaCadena.Next = null;
            Trabajo.Next = NuevaCadena;
        }

        public object Mirar(int index)
        {
            Trabajo = Pivote;
            int contador = 0;
            while (contador != index && Trabajo != null) 
            {
                Trabajo = Trabajo.Next;

                contador++;
            }
            if (index != contador)
            {
                return "Error";
            }
            else
            {
                return Trabajo.Dato;
            }
        }

    }
}
