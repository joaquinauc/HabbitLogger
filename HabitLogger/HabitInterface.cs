using HabitLogger;
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

        HabitLoggerFunctionality habitLoggerFunctionality = new();

        switch (mainMenuOption)
        {
            case MainMenuOptions.InsertRecord:
                habitLoggerFunctionality.InsertHabitLog();
                break;

            case MainMenuOptions.DeleteRecord:
                break;

            case MainMenuOptions.UpdateRecord:
                break;

            case MainMenuOptions.ViewAllRecords:
                break;

            default:
                break;
        }
    }

    internal void InsertMenu()
    {
        Console.Clear();


    }
}
