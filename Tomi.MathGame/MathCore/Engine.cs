namespace MathCore
{
    public class Engine
    {
        private readonly List<GameData> gameData = [];
        private delegate bool OperationDelegate();

        public Engine()
        {

        }

        internal static (int operand1, int operand2) GenerateRandomOperands()
        {
            Random rand = new();
            return (rand.Next(1, 101), rand.Next(1, 101));
        }

        private static GameData CreateNewGameData((int, int) Operands, string sign, int playerAnswer)
        {
            GameData gameData = sign switch
            {
                "+" => new() { Operands = Operands, Operation = sign, PlayerAnswer = playerAnswer, QuestionAnswer = Operands.Item1 + Operands.Item2 },

                "-" => new() { Operands = Operands, Operation = sign, PlayerAnswer = playerAnswer, QuestionAnswer = Operands.Item1 - Operands.Item2 },

                "*" => new() { Operands = Operands, Operation = sign, PlayerAnswer = playerAnswer, QuestionAnswer = Operands.Item1 * Operands.Item2 },

                "/" => new() { Operands = Operands, Operation = sign, PlayerAnswer = playerAnswer, QuestionAnswer = Operands.Item1 / Operands.Item2 },

                _ => new() { Operands = Operands, Operation = sign, PlayerAnswer = playerAnswer, QuestionAnswer = Operands.Item1 - Operands.Item2 }
            };

            return gameData;
        }

        private static int GetUserAnswer((int, int) operands, string operation)
        {
            string question = MathCoreUtils.GetQuestion(operands, operation);
            return MathCoreUtils.PromptForInt(question);
        }

        private bool Add()
        {
            (int, int) addOperands = GenerateRandomOperands();
            int playerAnswer = GetUserAnswer(addOperands, "+");

            GameData tempGameData = CreateNewGameData(addOperands, "+", playerAnswer);

            gameData.Add(tempGameData);
            return tempGameData.IsCorrect();
        }

        private bool Subtract()
        {
            (int, int) subtractOperands = GenerateRandomOperands();

            int playerAnswer = GetUserAnswer(subtractOperands, "-");

            GameData tempGameData = CreateNewGameData(subtractOperands, "-", playerAnswer);

            gameData.Add(tempGameData);
            return tempGameData.IsCorrect();
        }

        private bool Multiply()
        {
            (int, int) multiplicationOperands = GenerateRandomOperands();

            int playerAnswer = GetUserAnswer(multiplicationOperands, "*");

            GameData tempGameData = CreateNewGameData(multiplicationOperands, "*", playerAnswer);
            gameData.Add(tempGameData);
            return tempGameData.IsCorrect();
        }

        private bool Division()
        {
            (int, int) divisionOperands;
            while (true)
            {
                (int, int) tempOperands = GenerateRandomOperands();
                if (tempOperands.Item1 % tempOperands.Item2 != 0) continue;
                divisionOperands = tempOperands;
                break;
            }

            int playerAnswer = GetUserAnswer(divisionOperands, "/");

            GameData tempGameData = CreateNewGameData(divisionOperands, "/", playerAnswer);

            gameData.Add(tempGameData);
            return tempGameData.IsCorrect();
        }

        private bool RandomMode()
        {
            int index = new Random().Next(4);

            bool isCorreect = index switch
            {
                0 => Add(),

                1 => Subtract(),

                2 => Multiply(),

                3 => Division(),

                _ => false
            };

            return isCorreect;
        }

        public void ViewHistory()
        {
            int correctAnswers = 0;

            foreach (GameData data in gameData)
            {
                if (data.IsCorrect()) correctAnswers++;
                Console.WriteLine();
                Console.WriteLine(data);
            }
            Console.WriteLine($"\nYou total score is {correctAnswers} out of {gameData.Count} questions");
        }


        public void ProcessSelectedOption(string Option)
        {
            Console.Clear();

            OperationDelegate? operationDelegate = null;

            switch (Option)
            {
                case "1":
                    operationDelegate = Add;
                    break;
                case "2":
                    operationDelegate = Subtract;
                    break;
                case "3":
                    operationDelegate = Multiply;
                    break;
                case "4":
                    operationDelegate = Division;
                    break;
                case "5":
                    operationDelegate = RandomMode;
                    break;
                case "6":
                    ViewHistory();
                    return;
                default:
                    Console.WriteLine("You did not select an appropriate option..");
                    return;
            }

            int numberOfAttempts = MathCoreUtils.PromptForInt("How many questions do you want to attempt:");

            if (operationDelegate != null)
            {
                int tempScore = 0;
                for (int i = 0; i < numberOfAttempts; i++)
                {
                    if (operationDelegate()) tempScore++;
                }

                Console.WriteLine($"\nYou got {tempScore} out of {numberOfAttempts}");
            }
        }
    }

    public struct GameData
    {
        public (int, int) Operands;
        public string Operation;

        public int QuestionAnswer;

        public int PlayerAnswer;

        public readonly bool IsCorrect()
        {
            return QuestionAnswer == PlayerAnswer;
        }

        public override readonly string ToString()
        {
            string feedBackEmoji = IsCorrect() ? "✅" : "🗙";
            return $"Math Question: {MathCoreUtils.GetQuestion(Operands, Operation)}\nCorrect Answer: {QuestionAnswer} ✅\nYour Answer: {PlayerAnswer} {feedBackEmoji}";
        }
    }
}


