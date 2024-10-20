namespace MyExecutableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example usage: get user input
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());  // int.Parse string-i integer-ə çevirir

            Console.WriteLine("Enter birth date (YYYY-MM-DD):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()); // 'DateTime.Parse' string-i tarixə çevirir

        }
    }
}
