using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Block_de_tareas_del_dia
{
    public static class Memoria
    {
        public static Stack<string> NotasStack()
        {
            using (Stream stream = File.Open("Datos.stack", FileMode.OpenOrCreate))
            {
                var formato = new BinaryFormatter();
                if (stream.Length != 0)
                {
                    return (Stack<string>)formato.Deserialize(stream);
                }
                else
                {
                    return null;
                }
            }
        }

        public static void CambiadorStack(Stack<string> notitas)
        {
            using (Stream stream = File.Open("Datos.stack", FileMode.Create))
            {
                BinaryFormatter formato = new BinaryFormatter();
                formato.Serialize(stream, notitas);
            }
        }
        public static Queue<string> NotasQueue()
        {
            using (Stream stream = File.Open("Datos.stack", FileMode.OpenOrCreate))
            {
                var formato = new BinaryFormatter();
                if (stream.Length != 0)
                {
                    return (Queue<string>)formato.Deserialize(stream);
                }
                else
                {
                    return null;
                }
            }
        }

        public static void CambiadorQueue(Queue<string> notitas)
        {
            using (Stream stream = File.Open("Datos.stack", FileMode.Create))
            {
                BinaryFormatter formato = new BinaryFormatter();
                formato.Serialize(stream, notitas);
            }
        }
    }
}
