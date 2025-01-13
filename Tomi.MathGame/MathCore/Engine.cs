namespace MathCore
{
    public class Engine
    {

        public Engine()
        {

        }

        internal static (int operand1, int operand2) GenerateRandomOperands()
        {
            Random rand = new();
            return (rand.Next(1, 101), rand.Next(1, 101));
        }


        private static int GetUserAnswer((int, int) operands, string operation)
        {
            return 0;
        }


        public void ViewHistory()
        {
            Console.WriteLine("Your History");
        }


        public void ProcessSelectedOption(string Option)
        {
            Console.WriteLine("Processing selected options");
        }
    }

    
}


