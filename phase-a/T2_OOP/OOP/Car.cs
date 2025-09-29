
namespace OOP
{
    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public Car(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Car is {Brand}, {Year} year of manufacture");
        }
    }
}
