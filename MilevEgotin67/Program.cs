namespace MilevEgotin67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Въведете десетично число: ");
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            Console.WriteLine($"Двоично: Камбуракис ала КМК {binary}");
        }
    }
}
