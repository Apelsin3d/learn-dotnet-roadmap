using OOP;

namespace demoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Brand = "Toyota";
            car1.Year = 2025;
            car1.ShowInfo();


            var car2 = new Car();
            car2.Brand = "BMW";
            car2.Year = 2023;
            car2.ShowInfo();
        }
    }
}
