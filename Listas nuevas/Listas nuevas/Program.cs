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
            Console.WriteLine(MiLista.Mirar(int.Parse(Console.ReadLine().ToString())));
            Console.ReadLine();
            Console.WriteLine("Ahora probamos las pilas");

            Pilamia Mipila = new Pilamia();

            Mipila.add(1);
            Mipila.add(9);
            Mipila.add(5);
            Mipila.add("Rock");
            Mipila.add(17);
            Mipila.add(11);
            Mipila.MirarLista();
            Console.WriteLine("Agarramos el primer valor que es este: " + Mipila.Agarrar());
            Console.ReadLine();
            Mipila.MirarLista();
            Console.WriteLine("Agarramos el primer valor que es este: " + Mipila.Agarrar());
            Console.ReadLine();
        }
    }
}
