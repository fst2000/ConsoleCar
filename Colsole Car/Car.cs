using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Colsole_Car
{
    internal class Car
    {
        string carRight = "   ____\n__/ |  \\____\n'–@–---—––@–'";
        string carLeft = "     ____\n____/  | \\__\n'–@–---—––@–'";
        int carDirection = 1;
        int shiftX = 1;
        int shiftY = 10;

        string[] carToArray(string car)
        {
           return car.Split("\n");
        }
        public void CarDrawing()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;

            if (shiftX >=Console.BufferWidth - carToArray(carRight).Last().Length)
            {
                Console.Clear();
                shiftX = 0;
            }
            else if (shiftX <= 0)
            {
                Console.Clear();
                shiftX = Console.BufferWidth - carToArray(carLeft).Last().Length;
            }

            for (int i = 0; i < carToArray(carRight).Length; i++)
            {
                Console.SetCursorPosition(shiftX, shiftY + i);
                Console.WriteLine("              ");
            }

            shiftX+= carDirection;

            if (carDirection == 1)
            {
                for (int i = 0; i < carToArray(carRight).Length; i++)
                {
                    Console.SetCursorPosition(shiftX, shiftY + i);
                    Console.WriteLine(carToArray(carRight)[i]);
                }
            }
            else
            {
                for (int i = 0; i < carToArray(carLeft).Length; i++)
                {
                    Console.SetCursorPosition(shiftX, shiftY + i);
                    Console.WriteLine(carToArray(carLeft)[i]);
                }
            }
        }
    }
}
