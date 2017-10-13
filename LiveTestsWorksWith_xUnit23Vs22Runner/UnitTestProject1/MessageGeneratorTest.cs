using ConsoleApp1;
using Xunit;

// ReSharper disable once CheckNamespace
public class TestMessageGenerator
{
    public class Greet
    {
        [Fact]
        public void SaysHelloToPerson()
        {
            //Arrange
            
            //Act
            var greeting = MessageGenerator.GreetPerson("FakeName");

            //Assert
            Assert.Equal("Hello FakeName", greeting);
        }
    }
}