namespace MathCore
{
    public static class MathCoreUtils
    {

        public static void WelcomePlayer()
        {
            Console.WriteLine("Welcome");
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