using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("");
var employee = new EmployeeInFile("Janusz", "Kowalski");
employee.AddGrade(50.1212f);
employee.AddGrade(70d);
employee.AddGrade('A');
employee.AddGrade("50");
employee.AddGrade(45);

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: /q żeby zakończyć");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    else if (input.All(Char.IsLetter) && input.Length == 1)
//    {
//        try
//        {
//            employee.AddGrade(char.Parse(input));
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine($"Exception handled / {e.Message}");
//        }
//    }
//    else
//    {
//        try
//        {
//            employee.AddGrade(input);
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine($"Exception handled / {e.Message}");
//        }
//    }
//}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
