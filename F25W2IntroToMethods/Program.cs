namespace F25W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);

            ChangeValue(n, s);

            Console.WriteLine("\n\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
        }

        static void ChangeValue(int num, string str)
        {
            num = 100;
            str = "bye";
        }
    }
}
