using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas_nuevas
{
    class Filamia:Listamia
    {
        public object Agarrar()
        {
            Trabajo = Pivote;
            if (Trabajo.Next != null)
            {
                while (Trabajo.Next.Next != null)
                {
                    Trabajo = Trabajo.Next;
                }
                Apoyo = Trabajo.Next;
                Trabajo.Next = null;
                return Apoyo;

            }else return null;
        }

        public Filamia()
        {
            Pivote = new Nodo();
            Pivote.Next = null;
        }
    }
}