namespace Utils
{
    public class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static bool TryDivide(int a, int b, out int result)
        {
            if (b == 0)
            {
                result = 0;
                return  false;
            }
            result = a / b;
            return true;
        }

        public static int Increment(ref int a)
        {
            return a++;
        }

        public static int Decrement(ref int a)
        {
            return a--;
        }

        public static int Square(in int a)
        {
            return a * a;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Swap(ref int a, int b)
        {
            return a = b;
        }

        public static int ArraySum(in int[] a)
        {
            return a.Sum();
        }

        public static bool ArrayMinMaxValue(int[] a, out int min, out int max)
        {
            if (a.Length == 0)
            {
                min = 0;
                max = 0;
                return false;
            }

            min = a.Min();
            max = a.Max();
            return true;
        }
    }
}
