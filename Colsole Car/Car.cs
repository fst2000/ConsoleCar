using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ColsoleCar
{
    internal class Car
    {
        bool carDirection = true;
        public int posX { get; private set; }
        public int posY { get; private set; }
        public void CarMove()
        {
            posX += carDirection ? 1 : -1;
        }
    }
}
