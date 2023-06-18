namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void minValueTest()
        {
            // Arrange
            var employee = GetEmployee("Janusz", "Kowalski");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // Act

            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void maxValueTest()
        {
            // Arrange
            var employee = GetEmployee("Janusz", "Kowalski");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(6); ;

            // Act

            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(6, statistics.Max);
        }
        [Test]
        public void AverageValueTest()
        {
            // Arrange
            var employee = GetEmployee("Janusz", "Kowalski");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // Act

            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(3, statistics.Average);
        }
        [Test]
        public void AverageValueLetterTest()
        {
            // Arrange
            var employee = GetEmployee("Janusz", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade(70);

            // Act

            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
