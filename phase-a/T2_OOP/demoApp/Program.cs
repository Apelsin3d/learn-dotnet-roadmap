using OOP;

namespace demoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Toyota",2025);
            car1.ShowInfo();

            var car2 = new Car("BMW", 2023);
            car2.ShowInfo();
        }
    }
}
