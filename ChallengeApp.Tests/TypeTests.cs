namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void intNumbersShouldBeTheSameValue()
        {
            // Arrange
            int number1 = 12;
            int number2 = 12;

            // Act

            // Assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void floatNumbersShouldBeDifferentValue()
        {
            // Arrange
            float number3 = 123.12F;
            float number4 = 1275.12F;

            // Act

            // Assert
            Assert.AreNotEqual(number3, number4);
;
        }
        [Test]
        public void namesShouldBeTheSame()
        {
            // Arrange
            string str1 = "Janusz";
            string str2 = "Janusz";

            // Act

            // Assert
            Assert.AreEqual(str1, str2);
        }

        [Test]
        public void namesShouldBeDifferent()
        {
            // Arrange
            var employee1 = GetEmployee("Janusz");
            var employee2 = GetEmployee("Tomasz");

            // Act

            // Assert
            Assert.AreNotEqual(employee1.Name, employee2.Name);

        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
