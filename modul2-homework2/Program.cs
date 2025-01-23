namespace modul2_homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = 123.432;
            Console.WriteLine(input);
            operation reverse = new operation();
            double a =reverse.Reverse(input);
            Console.WriteLine(a);

            string inputS = Console.ReadLine();
            capitalize inputt = new capitalize();
            string b =inputt.Capitalize(inputS);
            Console.WriteLine(b);

        }
    }
}
