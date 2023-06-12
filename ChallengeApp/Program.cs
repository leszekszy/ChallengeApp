using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", "34");
Employee employee2 = new Employee("Marta", "Tarnowska", "28");
Employee employee3 = new Employee("Janusz", "Tratwa", "55");

employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);

employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(4);

employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMax = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMax = employee;
    }
}

Console.WriteLine("Najlepszym pracownikiem jest: " + employeeWithMax.Name + " " + employeeWithMax.Surname);