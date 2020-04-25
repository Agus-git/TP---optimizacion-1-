using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas_nuevas
{
    class Pilamia:Listamia
    {
        public object Agarrar()
        {
            Trabajo = Pivote;
            bool vacio = true;

            if (Trabajo.Next != null)
            {
                Apoyo = Trabajo.Next;
                //(Apoyo.Next == null)? Trabajo.Next = null : Trabajo.Next = Apoyo.Next; ¿como funciona?
                Trabajo.Next = Apoyo.Next;
                return Apoyo.Dato;
            }
            return null;
        }
        public Pilamia()
        {
            Pivote = new Nodo();
            Pivote.Next = null;
        }
    }
}
