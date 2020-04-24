using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas_nuevas
{
    class Program
    {
        static void Main(string[] args)
        {
            Listamia MiLista = new Listamia();

            MiLista.add(1);
            MiLista.add(9);
            MiLista.add(5);
            MiLista.add("Rock");
            MiLista.add(17);
            MiLista.add(11);

            MiLista.MirarLista();
            Console.WriteLine("Escribi el indice que buscas");
            Console.WriteLine(MiLista.devolver(int.Parse(Console.ReadLine().ToString())));
            Console.ReadLine();
        }
    }
}
