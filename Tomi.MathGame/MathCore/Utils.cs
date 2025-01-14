namespace MathCore
{
    public static class MathCoreUtils
    {

        public static void WelcomePlayer()
        {
            string welcomeMessage = @"
        ************************************
        *                                  *
        *       WELCOME TO MATH GAME!       *
        *                                  *
        ************************************
        
        Hello, Math Enthusiast!
        
        In this game, you'll be challenged with various math problems.
        Try your best to solve them quickly and correctly!
        
        Are you ready to test your math skills? Let's begin!
        
        ------------------------------------
        ";
            Console.WriteLine(welcomeMessage);
        }

        public static bool ContinueGame()
        {
            string? keepPlaying = null;
            Console.Write("Wanna play math game? y/n: ");


            while (true)
            {
                keepPlaying = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(keepPlaying))
                {
                    Console.WriteLine("Input cannot be empty. Please enter 'y' or 'n'.");
                }


                if (keepPlaying != "y" && keepPlaying != "n") Console.Write("Please enter 'y' or 'n': ");
                else break;


            }

            return "y" == keepPlaying;

        }

        public static string PresentGameMenu()
        {
            Console.Clear();
            string? response = null;
            while (true)
            {
                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Random Mode");
                Console.WriteLine("6. View History");
                Console.Write("Enter the number corresponding to the operation (1/2/3/4/5/6) or 'q' to quit: ");

                response = Console.ReadLine()?.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(response)) break;

                Console.WriteLine("Input cannot be empty. Please select one of the operations");

            }
            return response;
        }

        public static string GetQuestion((int firstOperand, int secondOperand) operands, string operation)
        {
            return $"{operands.firstOperand} {operation} {operands.secondOperand} = ___";
        }

        public static int PromptForInt(string prompt)
        {
            while (true)
            {
                string? userAnswer = null;
                Console.WriteLine($"\n{prompt}");

                userAnswer = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    Console.WriteLine("You didn't input an answer..");
                    continue;
                }


                if (int.TryParse(userAnswer, out int result))
                {
                    return result;
                }
                Console.WriteLine("Your answer must be a number..");
            }
        }


    }
}