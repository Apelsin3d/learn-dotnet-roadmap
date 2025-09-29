using Utils;

namespace demoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DemoApp!");

            var a = 20;
            var b = 10;
            var array = new int[] { 1, 5, 8 };
            var emptyArray = new int[0];

            Console.WriteLine($"Sum of numbers {a} and {b} equal to {MathUtils.Add(a, b)}");
            Console.WriteLine($"Multiply of number {a} and {b} equal to {MathUtils.Multiply(a, b)}");
            Console.WriteLine($"Is possible to divide numbers 'a' by numbers 'b' - {MathUtils.TryDivide(a, b, out var c)}, result equal to {c}");
            Console.WriteLine($"Increment {a} equal to {MathUtils.Increment(ref a)}");
            Console.WriteLine($"Decrement {a} equal to {MathUtils.Decrement(ref a)}");
            Console.WriteLine($"Square {a} equal to {MathUtils.Square(a)}");
            Console.WriteLine($"The result of dividing {a} and {b} equal to {MathUtils.Divide(a, b)}");
            Console.WriteLine($"'a' before swap equal to {a}, 'b' before swap equal to {b}'");
            MathUtils.Swap(ref a, ref b);
            Console.WriteLine($"'a' after swap equal to {a}, 'b' after swap equal to {b}'");
            Console.WriteLine($"Sum of numbers in array: '1,5,8' equal to {MathUtils.ArraySum(array)}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array tests");
            Console.WriteLine("Empty array:");
            if (!MathUtils.ArrayMinMaxValue(emptyArray, out var min, out var max))
            {
                Console.WriteLine($"Array {emptyArray.Length} - empty");
            }
            Console.WriteLine("Not empty array:");
            Console.WriteLine(MathUtils.ArrayMinMaxValue(array, out var min1, out var max2));
            Console.WriteLine($"Min value in array: '1,5,8' equal to {min1} and max value equal to {max2}");


        }
    }
}
