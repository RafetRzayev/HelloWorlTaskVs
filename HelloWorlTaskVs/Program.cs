namespace HelloWorlTaskVs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("A ededini daxil et:");
            a = int.Parse(Console.ReadLine());
            Console.Write("B ededini daxil et:");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine($"{a}%{b}={a%b}");

            Console.WriteLine("From dev");
        }
    }
}