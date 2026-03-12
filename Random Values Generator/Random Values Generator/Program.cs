using System.Text;

namespace Random_Values_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Select an Option: ");
                Console.WriteLine("[1] Generate random number\n" +
                                  "[2] Generate random string\n" +
                                  "[3] Exit");

                var selectedOption = Console.ReadLine();
                switch (selectedOption)
                {
                    case "1":
                        Console.WriteLine("Enter the Start number");
                        int A = ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the End number");
                        int B = ToInt32(Console.ReadLine());

                        GenerateRandomNumber(A, B);
                        break;

                    case "2":
                        Console.WriteLine("Enter How many letters do you want to generate?");
                        int F = ToInt32(Console.ReadLine());
                        GenerateRandomString(F);
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please Enter number from 1 to 3 only");
                        break;
                }
            }
        }

        private static int ToInt32(string? v)
        {
            int.TryParse(v, out int num);
            return num;
        }

        static void GenerateRandomNumber(int A, int B)
        {
            var rnd = new Random();
            var value = rnd.Next(A, B);
            Console.WriteLine($"Random Value: {value}");
        }

        private static readonly string[] Buffer =
        {
            "QWERTYUIOPASDFGHJKLZXCVBNM",    // 0
            "qwertyuiopasdfghjklzxcvbnm",    // 1
            "[];',./*-+~!@#$%^&*()_+{}:<>?", // 2
            "0123456789"                     // 3
        };

        private static void GenerateRandomString(int F)
        {
            var SB = new StringBuilder();
            var rnd = new Random();

            List<int> selectedIndexes = new List<int>();

            
            while (true)
            {
                Console.WriteLine("Choose type: \n"+
                                  "[1] Capital Letters\n"+
                                  "[2] Small Letters\n"+
                                  "[3] Symbols\n"+
                                  "[4] Numbers");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": selectedIndexes.Add(0); break;
                    case "2": selectedIndexes.Add(1); break;
                    case "3": selectedIndexes.Add(2); break;
                    case "4": selectedIndexes.Add(3); break;
                    default: Console.WriteLine("Invalid Choice"); break;
                }

                Console.WriteLine("Do you want to add another option? (yes/no)");
                var more = Console.ReadLine();

                if (more?.ToLower() == "no")
                    break;
            }

            
            for (int i = 0; i < F; i++)
            {
                
                int randomGroupIndex = selectedIndexes[rnd.Next(selectedIndexes.Count)];

                
                string group = Buffer[randomGroupIndex];

                
                char randomChar = group[rnd.Next(group.Length)];

                SB.Append(randomChar);
            }

            Console.WriteLine($"Random String: {SB}");
        }
    }
}
