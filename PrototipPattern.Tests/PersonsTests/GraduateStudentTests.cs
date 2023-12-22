using FluentAssertions;
using Newtonsoft.Json;
using PrototipPattern.Documents;
using PrototipPattern.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipPattern.Tests.PersonsTests
{
    public class GraduateStudentTests
    {
        [Fact]
        public void GraduateStudent_MyClone_Failed()
        {
            //Arrange
            var graduateStudent = new GraduateStudent
             ("Екатерина Иванова", 25, new Passport("67890", new DateTime(2012, 4, 25)),
             "ВШЭ", "ФКН", 3, new RecordBook("efg678"), "Алгебры Горенштейна и единственность аддитивных действий");

            //Act
            var clonedGraduateStudent = graduateStudent.MyClone();

            //Assert
            Assert.NotEqual(graduateStudent, clonedGraduateStudent);

        }

        [Fact]
        public void GraduateStudent_MyClone_Success()
        {
            //Arrange
            GraduateStudent graduateStudent = new GraduateStudent
             ("Екатерина Иванова", 25, new Passport("67890", new DateTime(2012, 4, 25)),
             "ВШЭ", "ФКН", 3, new RecordBook("efg678"), "Алгебры Горенштейна и единственность аддитивных действий");

            //Act
            GraduateStudent clonedGraduateStudent = graduateStudent.MyClone();

            //Assert
            var object1Json = JsonConvert.SerializeObject(graduateStudent);
            var object2Json = JsonConvert.SerializeObject(clonedGraduateStudent);

            object1Json.Should().Be(object2Json);

        }


        [Fact]
        public void GraduateStudent_Clone_Failed()
        {
            //Arrange
            var graduateStudent = new GraduateStudent
             ("Екатерина Иванова", 25, new Passport("67890", new DateTime(2012, 4, 25)),
             "ВШЭ", "ФКН", 3, new RecordBook("efg678"), "Алгебры Горенштейна и единственность аддитивных действий");

            //Act
            var clonedGraduateStudent = graduateStudent.Clone();

            //Assert
            Assert.NotEqual(graduateStudent, clonedGraduateStudent);

        }

        [Fact]
        public void GraduateStudent_Clone_Success()
        {
            //Arrange
            var graduateStudent = new GraduateStudent
             ("Екатерина Иванова", 25, new Passport("67890", new DateTime(2012, 4, 25)),
             "ВШЭ", "ФКН", 3, new RecordBook("efg678"), "Алгебры Горенштейна и единственность аддитивных действий");

            //Act
            var clonedGraduateStudent = graduateStudent.Clone();

            //Assert
            var object1Json = JsonConvert.SerializeObject(graduateStudent);
            var object2Json = JsonConvert.SerializeObject(clonedGraduateStudent);

            object1Json.Should().Be(object2Json);

        }
    }
}
