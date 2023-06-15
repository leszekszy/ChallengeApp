using ChallengeApp;

var employee = new Employee("Janusz", "Kowalski");
employee.AddGrade(1);
employee.AddGrade(3);
employee.AddGrade(9);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
