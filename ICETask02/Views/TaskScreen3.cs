using Spectre.Console;

namespace ICETask02.Views;

public class TaskScreen3
    : IConsoleScreen
{
#region Lifecycle

    public void Launch() {
        throw new NotImplementedException();
    }

#endregion

#region Decorations

    public void ShowHeader() {
        Console.Clear();
    }


    public void ShowFooter() {
        AnsiConsole.WriteLine();
        AnsiConsole.MarkupLine("[grey]Tap any key to continue...[/]");
        Console.ReadKey();
    }

#endregion
}
