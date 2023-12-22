using FluentAssertions;
using Newtonsoft.Json;
using PrototipPattern.Documents;
using PrototipPattern.Persons;

namespace PrototipPattern.Tests.PersonsTests
{
    public class StudentTests
    {
        [Fact]
        public void Student_MyClone_Failed()
        {
            //Arrange
            var student = new Student
                ("Александр Васильев", 19, new Passport("12345", new DateTime(2010, 8, 23)),
                "МГУ", "Географический", 2, new RecordBook("abc123"));

            //Act
            var clonedStudent = student.MyClone();

            //Assert
            Assert.NotEqual(student, clonedStudent);

        }

        [Fact]
        public void Student_MyClone_Success()
        {
            //Arrange
            var student = new Student
                ("Александр Васильев", 19, new Passport("12345", new DateTime(2010, 8, 23)),
                "МГУ", "Географический", 2, new RecordBook("abc123"));

            //Act
            var clonedStudent = student.MyClone();

            //Assert
            var object1Json = JsonConvert.SerializeObject(student);
            var object2Json = JsonConvert.SerializeObject(clonedStudent);

            object1Json.Should().Be(object2Json);

        }


        [Fact]
        public void Student_Clone_Failed()
        {
            //Arrange
            var student = new Student
                ("Александр Васильев", 19, new Passport("12345", new DateTime(2010, 8, 23)),
                "МГУ", "Географический", 2, new RecordBook("abc123"));

            //Act
            var clonedStudent = student.Clone();

            //Assert
            Assert.NotEqual(student, clonedStudent);

        }

        [Fact]
        public void Student_Clone_Success()
        {
            //Arrange
            var student = new Student
                ("Александр Васильев", 19, new Passport("12345", new DateTime(2010, 8, 23)),
                "МГУ", "Географический", 2, new RecordBook("abc123"));

            //Act
            var clonedStudent = student.Clone();

            //Assert
            var object1Json = JsonConvert.SerializeObject(student);
            var object2Json = JsonConvert.SerializeObject(clonedStudent);

            object1Json.Should().Be(object2Json);

        }
    }
}
