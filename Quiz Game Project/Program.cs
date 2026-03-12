namespace Quiz_Game_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3]
            {
                "1. What is the capital of Italy?",
                "2. What is the red Planet?",
                "3. What is the largest Animal?"
            };

            string[] answers = new string[3]
            {
                "Rome",
                "Mars",
                "Whale"
            };

            Console.WriteLine("Welcome To The Game\n");
            Console.WriteLine("Please answer the following question: \n");
            int Score = 0;
            for(int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswer = Console.ReadLine();

                try
                {
                    bool result = istheanswercorrect(userAnswer, answers[i]);

                    if (result)
                    {
                        Console.WriteLine("\nCorrect Answer!\n");
                        Score++;
                    }
                    else
                    {
                        Console.WriteLine($"\nSorry, Incorrect Answer, The Correct Answer is {answers[i]}\n");

                    }
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                
            }

            Console.WriteLine($"\nYour Score : {Score}/{answers.Length}\n");
            Console.WriteLine("Quiz Completed, Thank You!");
        }

        private static bool istheanswercorrect(string userInput, string correctAnswer)
        {
            if(string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer can't be empty");
            }
            if (userInput == correctAnswer) 
            
                return true;
            
            return false;
            
        }
    }
}
