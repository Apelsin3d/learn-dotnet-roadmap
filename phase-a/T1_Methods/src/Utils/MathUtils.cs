namespace Utils
{
    public static class MathUtils
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
            return ++a;
        }

        public static int Decrement(ref int a)
        {
            return --a;
        }

        public static int Square(in int a)
        {
            return a * a;
        }

        /// <summary>
        /// Dangerous division, may contain errors, not checked for 0
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        public static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
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
