using Spectre.Console;

namespace ICETask02.Views;

public class TaskScreen1
    : IConsoleScreen
{
#region Lifecycle

    public void Launch() {
        ShowHeader();
        var students = new Dictionary<string, string> {
            ["ST1001"] = "Alice Mokoena",
            ["ST1002"] = "Brian Nkosi",
            ["ST1003"] = "Cindy Mahlangu",
            ["ST1004"] = "David Smith",
            ["ST1005"] = "Emma Botha"
        };

        var table = new Table()
            .Border(TableBorder.Rounded)
            .Title("[bold underline aqua]Student List[/]")
            .AddColumn("Student ID")
            .AddColumn("Name");

        foreach (var pair in students) {
            table.AddRow(pair.Key, pair.Value);
        }

        AnsiConsole.Write(table);
        ShowFooter();
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
