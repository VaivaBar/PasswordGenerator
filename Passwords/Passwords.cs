

namespace PasswordGenerator
{
    class Passwords
    {
        static void Main()
        {
            Console.WriteLine("=== Password Generator ===\n");

            Console.Write("Password length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Use uppercase letters? (y/n): ");
            bool upper = Console.ReadLine().ToLower() == "y";

            Console.Write("Use lowercase letters? (y/n): ");
            bool lower = Console.ReadLine().ToLower() == "y";

            Console.Write("Use digits? (y/n): ");
            bool digits = Console.ReadLine().ToLower() == "y";

            Console.Write("Use symbols? (y/n): ");
            bool symbols = Console.ReadLine().ToLower() == "y";

            string password = GeneratePassword(length, upper, lower, digits, symbols);

            if (password == null)
                Console.WriteLine("\nError: please select at least one type of characters!");
            else
                Console.WriteLine($"\nGenerated password: {password}");
        }

        static string GeneratePassword(int length, bool upper, bool lower, bool digits, bool symbols)
        {
            string chars = "";
            if (upper)   chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (lower)   chars += "abcdefghijklmnopqrstuvwxyz";
            if (digits)  chars += "0123456789";
            if (symbols) chars += "!@#$%^&*()-_=+[]{}";

            if (chars == "") return null;

            Random rnd = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
                password[i] = chars[rnd.Next(chars.Length)];

            return new string(password);
        }
    }
}