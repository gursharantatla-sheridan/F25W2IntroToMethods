namespace F25W2IntroToMethods
{
    internal class Program
    {
        //int x;

        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Before changes:");
            //Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValue(ref n, ref s, a);

            Console.WriteLine("\n\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            Console.WriteLine("\n\n\n");



            int rad = 5;
            //double circum, area;

            Calculate(rad, out double circum, out double area);

            Console.WriteLine("Circumference = " + circum.ToString("F"));
            Console.WriteLine("Area = " + area.ToString("F"));



            //Console.Write("\n\nEnter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int num))
            //    Console.WriteLine("num = " + num);
            //else
            //    Console.WriteLine("Invalid input. Please try again");

            Console.WriteLine("\n\n\n");



            int x = 3, y = 5, z = 6;

            Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
            Console.WriteLine($"x = {x} y = {y} z = {z}");
            Console.WriteLine("x = {0} y = {1} z = {2}", x, y, z);



            int[] array = { 5, 3, 4, 6, 7, 8, 8, 6, 4 };

            PrintArray(array);
            PrintArray(3, 4, 5, 6, 76, 7, 8, 7, 6, 5, 4, 43);


            PersonInfo("John", 34);
            PersonInfo(name: "John", age: 34);
            PersonInfo(age: 34, name: "John");
            PersonInfo("John");
        }

        static void PersonInfo(string name, int age = 21)
        {
            // method body
        }



        static void PrintArray(params int[] arr)
        {
            Console.WriteLine("\n\nNumber of items: " + arr.Length);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }



        static void Calculate(int r, out double cir, out double ar)
        {
            cir = 2 * Math.PI * r;
            ar = Math.PI * r * r;
        }



        static void ChangeValue(ref int num, ref string str, int[] arr)
        {
            num = 100;
            str = "bye";
            arr[0] = 100;
        }
    }
}
