using FluentAssertions;
using Newtonsoft.Json;
using PrototipPattern.Documents;
using PrototipPattern.Persons;

namespace PrototipPattern.Tests.PersonsTests
{
    public class PersonTests
    {
        [Fact]
        public void Person_MyClone_Failed()
        {
            //Arrange
            var person = new Person("Иван Петров", 44, new Passport("445566", new DateTime(2000, 01, 01)));

            //Act
            var clonedPerson = person.MyClone();

            //Assert
            Assert.NotEqual(person, clonedPerson);

        }

        [Fact]
        public void Person_MyClone_Success()
        {
            //Arrange
            var person = new Person("Иван Петров", 44, new Passport("445566", new DateTime(2000, 01, 01)));

            //Act
            var clonedPerson = person.MyClone();

            //Assert
            var object1Json = JsonConvert.SerializeObject(person);
            var object2Json = JsonConvert.SerializeObject(clonedPerson);

            object1Json.Should().Be(object2Json);

        }



        [Fact]
        public void Person_Clone_Failed()
        {
            //Arrange
            var person = new Person("Иван Петров", 44, new Passport("445566", new DateTime(2000, 01, 01)));

            //Act
            var clonedPerson = person.Clone();

            //Assert
            Assert.NotEqual(person, clonedPerson);

        }

        [Fact]
        public void Person_Clone_Success()
        {
            //Arrange
            var person = new Person("Иван Петров", 44, new Passport("445566", new DateTime(2000, 01, 01)));

            //Act
            var clonedPerson = person.Clone();

            //Assert
            var object1Json = JsonConvert.SerializeObject(person);
            var object2Json = JsonConvert.SerializeObject(clonedPerson);

            object1Json.Should().Be(object2Json);

        }
    }
}
