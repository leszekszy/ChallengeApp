using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("");
var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: /q żeby zakończyć");
    var input = Console.ReadLine();
    if (input.Length == 0)
    {
        Console.WriteLine("Wpisz ocenę!");
        Console.WriteLine();
    }
    else if (input == "q")
    {
        break;
    }
    else if (input.All(Char.IsLetter))
    {
        employee.AddGrade(char.Parse(input));
    }
    else 
    { 
        employee.AddGrade(input); 
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
