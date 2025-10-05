using Spectre.Console;

namespace ICETask02.Views;

public class TaskScreen3
    : IConsoleScreen
{
#region Fields

    private readonly HashSet<string> _mathStudents = [
        "Alice",
        "Brian",
        "Cindy",
        "David",
        "Emma"
    ];


    private readonly HashSet<string> _scienceStudents = [
        "Cindy",
        "David",
        "Frank",
        "Grace",
        "Hannah"
    ];

#endregion

#region Lifecycle

    public void Launch() {
        ShowHeader();

        // Operate on The Sets

        var intersects = new HashSet<string>(_mathStudents);
            intersects.IntersectWith(_scienceStudents);

        var difference = new HashSet<string>(_mathStudents);
            difference.ExceptWith(_scienceStudents);

        var union = new HashSet<string>(_mathStudents);
            union.UnionWith(_scienceStudents);

        // Display Outputs

        DisplayTable("Students in both classes", intersects);
        DisplayTable("Students only in the maths class", difference);
        DisplayTable("Union of all students", union);

        ShowFooter();
    }

#endregion

#region Decorations

    private void DisplayTable(
        string tableTitle,
        HashSet<string> collection
    ) {
        var table = new Table()
            .Border(TableBorder.Rounded)
            .Title($"[bold underline aqua]{tableTitle}[/]")
            .AddColumn("Student Name");

        if (collection.Count == 0) {
            table.AddRow("[grey]Collection is empty or none could be found[/]");
        }
        else {
            foreach (var student in collection) {
                table.AddRow(student);
            }
        }

        AnsiConsole.Write(table);
    }


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
