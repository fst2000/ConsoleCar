using Colsole_Car;
using System.Diagnostics.Metrics;
using System.Threading;
class Program
{
    static void Main()
    {
        Car car = new Car();

        while (true)
        {
            car.CarDrawing();            
            Thread.Sleep(30);
        }
    }
}
