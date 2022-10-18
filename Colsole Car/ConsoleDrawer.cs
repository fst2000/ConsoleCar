using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ColsoleCar
{
    internal class ConsoleDrawer
    {
        public void Draw(string subject, int x,int y)
        {
            Console.CursorVisible = false;
            string[] array = subject.Split("\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(array[i]);
            }
        }
        public void Clear(string subject, int x,int y)
        {
            string[] array = subject.Split("\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(x - 1, y + i);
                Console.WriteLine("              ");
            }
        }

    }
}
