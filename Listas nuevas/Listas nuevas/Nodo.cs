using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas_nuevas
{
    class Nodo
    {
        private object dato;

        public object Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private Nodo next;

        public Nodo Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return string.Format(" ({0}) ", dato);
        }
    }
}
