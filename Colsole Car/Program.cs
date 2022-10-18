using ColsoleCar;
using System.Diagnostics.Metrics;
using System.Threading;
class Program
{
    static void Main()
    {
        string carRight = "   ____\n__/ |  \\____\n'–@–---—––@–'";
        string carLeft = "     ____\n____/  | \\__\n'–@–---—––@–'";
        Car car = new Car();
        ConsoleDrawer consoleDrawer = new ConsoleDrawer();

        while (true)
        {
            car.CarMove();
            consoleDrawer.Clear(carRight, car.posX, car.posY);
            consoleDrawer.Draw(carRight, car.posX, car.posY);
            Thread.Sleep(30);
        }
    }
}
