using Spectre.Console;

namespace ICETask02.Views;

public class TaskScreen2
    : IConsoleScreen
{
#region Fields

    private readonly HashSet<string> _codes = [
        "PROG1A",
        "PROG1B",
        "PROG1C",
        "PROG2A",
        "PROG2B",
        "PROG2C",
        "PROG3A",
        "PROG3B",
        "PROG3C"
    ];

#endregion

#region Lifecycle

    public void Launch() {
        ShowHeader();
        TryAddDuplicateToShowIgnoredAttempts();

        var table = new Table()
            .Border(TableBorder.Rounded)
            .Title("[bold underline aqua]Set of Courses[/]")
            .AddColumn("Course Code");

        foreach (var code in _codes) {
            table.AddRow(code);
        }

        AnsiConsole.Write(table);
        ShowFooter();
    }

#endregion

#region Helpers

    /// <summary>
    /// This method attempts to add duplicates to the set to show how the
    /// attempt is ignored as all values must be unique.
    /// </summary>
    private void TryAddDuplicateToShowIgnoredAttempts() {
        _codes.Add("PROG3A");
        _codes.Add("PROG3B");
        _codes.Add("PROG3C");
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
