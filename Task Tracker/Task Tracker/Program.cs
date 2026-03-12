namespace TaskTrecker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Task Tracker");

            while(true)
            {
                Console.WriteLine("\nEnter your choice from 1 to 5\n" +
                "1. Add Task\n" +
                "2. View Task\n" +
                "3. Mark Task\n" +
                "4. Remove Task\n" +
                "5. Exit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        //Add Task
                        Add_Task();
                        break;
                    case "2":
                        // view Task
                        ViewTasks();
                        break;
                    case "3":
                        //mark Task
                        MarkComplete();
                        break;
                    case "4":
                        //remove Task
                        DeleteTask();
                        break;
                    case "5":
                        //exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error..." +
                            "Please enter number from 1 to 5 only");
                        break;
                }
            }
        }
    
        private static void Add_Task()
        {
            Console.WriteLine("Enter Task Title");
            string newTask = Console.ReadLine();

            tasks[count] = newTask;

            Console.WriteLine("Done!");

            count++; 
        }

        private static void ViewTasks()
        {
            Console.WriteLine("Task list : ");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. {tasks[i]}");
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine("Enter Task number");

            string Tasknumber = Console.ReadLine();

            int IdTask = Convert.ToInt32(Tasknumber);

            IdTask--;

            tasks[IdTask] = tasks[IdTask] + "--COMPLETED";
        }

        private static void DeleteTask()
        {
            Console.WriteLine("Enter Task number to delete");

            string tasknumber = Console.ReadLine();

            int IdTask = Convert.ToInt32(tasknumber);

            IdTask--;

            for (int i = IdTask; i < count; i++)
            {
                tasks[i] = tasks[i+1] ;
            }
            count--;
        }
    }
}