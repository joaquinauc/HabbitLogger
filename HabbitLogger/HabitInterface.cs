using Spectre.Console;
using static HabbitLogger.Enums;

namespace HabbitLogger;

internal class HabitInterface
{
    internal static void MainMenu()
    {
        Console.Clear();

        var mainMenuOption = AnsiConsole.Prompt(
            new SelectionPrompt<MainMenuOptions>()
            .Title("Select which action you wish to do: ")
            .AddChoices(Enum.GetValues<MainMenuOptions>())
        );
    }
}
