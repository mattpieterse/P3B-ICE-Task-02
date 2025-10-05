using ICETask02.Views;
using Spectre.Console;

namespace ICETask02;

internal static class App
{
#region Fields

    private static readonly Dictionary<string, IConsoleScreen> Screens = new() {
        ["Task 2.1"] = new TaskScreen1(),
        ["Task 2.2"] = new TaskScreen2(),
        ["Task 2.3"] = new TaskScreen3()
    };

#endregion

#region Lifecycle

    private static void Main(string[] args) {
        var selection = string.Empty;
        while (selection != "Exit") {
            Console.Clear();
            AnsiConsole.Write(
                new FigletText("ST10257002\n").Color(Color.Aqua)
            );

            selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select any task to display its output")
                    .AddChoices(
                        "Task 2.1",
                        "Task 2.2",
                        "Task 2.3",
                        "Exit"
                    )
            );

            if (Screens.TryGetValue(selection, out var screen)) {
                screen.Launch();
            }
        }
    }

#endregion
}
