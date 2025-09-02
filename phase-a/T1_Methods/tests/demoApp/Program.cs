using Utils;

namespace demoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DemoApp!");

            var a = new int[] { 1,5,8 };

            if (MathUtils.ArrayMinMaxValue(a, out var min, out var max))
            {
                Console.WriteLine($"Array max value:{max}, min value:{min}");
            }
            else
            {
                Console.WriteLine("Array is empty");
            }
        }
    }
}
