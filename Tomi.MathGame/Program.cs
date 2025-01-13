using MathCore;

static void StartGame()
{
    Console.Clear();
    MathCoreUtils.WelcomePlayer();
    Engine gameEngine = new();

    while (MathCoreUtils.ContinueGame())
    {
        string selectedMenu = MathCoreUtils.PresentGameMenu();
        if (selectedMenu == "q")
        {
            break;
        }

        gameEngine.ProcessSelectedOption(selectedMenu);
    }

    gameEngine.ViewHistory();
    Console.WriteLine("oops.. we do not wanna see you go.. but the above is your game history");
}

StartGame();