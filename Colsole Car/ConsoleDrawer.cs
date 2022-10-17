using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colsole_Car
{
    internal class ConsoleDrawer
    {
        public void ConsoleDraw(string subject, int x,int y)
        {
            string[] array = subject.Split("\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(array[i]);
            }
        }

    }
}
