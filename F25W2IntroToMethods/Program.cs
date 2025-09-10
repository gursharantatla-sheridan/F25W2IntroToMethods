namespace F25W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValue(n, s, a);

            Console.WriteLine("\n\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);
        }

        static void ChangeValue(int num, string str, int[] arr)
        {
            num = 100;
            str = "bye";
            arr[0] = 100;
        }
    }
}
