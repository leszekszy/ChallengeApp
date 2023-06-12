namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var user = new Employee("Janusz", "Kowalski", "32");
            user.AddScore(5);
            user.AddScore(-2);
            user.AddScore(7);
            user.AddScore(8);
            user.AddScore(-5);

            // Act
            var result = user.Result;

            // Assert
            Assert.AreEqual(13, result);
        }
    }
}