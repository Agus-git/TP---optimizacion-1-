using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Block_de_tareas_del_dia
{
    public class Motor
    {
        public void Arrancar()
        {
            int Guardadoenmemoria = 0;

            Console.WriteLine("[(1) Ir a la pila] [(2) Ir a la fila]");
            Guardadoenmemoria = int.Parse(Console.ReadLine().ToString());
            if (Guardadoenmemoria == 1)
            {
                if (Memoria.NotasStack() == null)
                {
                    GenerarTarea(Guardadoenmemoria);
                }
                else
                {
                    PedirQueHagaSuTarea();
                }
            }
            else
            {
                if (Memoria.NotasQueue() == null)
                {
                    GenerarTarea(Guardadoenmemoria);
                }
                else
                {
                    PedirQueHagaSuTarea();
                }
            }
        }

        private void PedirQueHagaSuTarea()
        {
            SiEsStack();
        }

        private void SiEsStack()
        {
            Stack<string> NotasEnMemoria = Memoria.NotasStack();
            Console.WriteLine("A usted le falta hacer");
            for (int i = 0; i < NotasEnMemoria.Count; i++)
            {
                Console.WriteLine(" --> " + NotasEnMemoria.Peek() + " ¿hizo esta actividad?\n  [ (S) si] [ (N) No]");
                if (Console.ReadLine().ToString() == "s")
                {
                    NotasEnMemoria.Pop();
                    Memoria.CambiadorStack(NotasEnMemoria);
                    Console.WriteLine("Felicidades, ahora...");
                    PedirQueHagaSuTarea();
                }
                else
                {
                    Console.WriteLine("Volve cuando lo hagas");
                    Console.ReadLine();
                }
            }
        }

        private void GenerarTarea(int guardadomemoria)
        {
            Console.WriteLine("No contas con tareas a hacer\n [(1) para escribir tareas] [(otro numero) salir]");
            int a = int.Parse(Console.ReadLine().ToString());
            if (a == 1 && guardadomemoria == 1)
            {
                Pila();
            }
            else if(a == 1 && guardadomemoria == 2)
            {
                Fila();
            }

        }

        private void Fila()
        {
            Queue<string> NotasEnMemoria = new Queue<string>();
            if (Console.ReadLine().ToString() == "1")
            {
                Console.Clear();
                string fin = "";
                while (fin != "1")
                {

                    Console.WriteLine("Escribi algo");
                    string nota = Console.ReadLine().ToString();
                    NotasEnMemoria.Enqueue(nota);

                    Console.WriteLine("¿seguro que quiere guardar la nota?");
                    Console.WriteLine("[(1) si] [(otra tecla) No]");
                    if (Console.ReadLine().ToString() != "1")
                    {
                        NotasEnMemoria.Dequeue();
                    }

                    Memoria.CambiadorQueue(NotasEnMemoria);
                    Console.WriteLine("¿termino? [(1) si] [(otra tecla) salir]");
                    fin = Console.ReadLine().ToString();
                }
            }
        }

        private static void Pila()
        {
            Stack<string> NotasEnMemoria = new Stack<string>();
            if (Console.ReadLine().ToString() == "1")
            {
                Console.Clear();
                string fin = "";
                while (fin != "1")
                {

                    Console.WriteLine("Escribi algo");
                    string nota = Console.ReadLine().ToString();
                    NotasEnMemoria.Push(nota);

                    Console.WriteLine("¿seguro que quiere guardar la nota?");
                    Console.WriteLine("[(1) si] [(otra tecla) No]");
                    if (Console.ReadLine().ToString() != "1")
                    {
                        NotasEnMemoria.Pop();
                    }

                    Memoria.CambiadorStack(NotasEnMemoria);
                    Console.WriteLine("¿termino? [(1) si] [(otra tecla) salir]");
                    fin = Console.ReadLine().ToString();
                }
            }
        }
    }
}
