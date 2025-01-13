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
            //infinite loop - this is just to bootstrap the project skeleton
            return true;

        }

        public static string PresentGameMenu()
        {
            Console.Clear();
            return "Presenting Game Menu";
        }

        public static string GetQuestion((int firstOperand, int secondOperand) operands, string operation)
        {
            return "Util method to return a question";
        }

        public static int PromptForInt(string prompt)
        {
            return 0;
        }

    }
}