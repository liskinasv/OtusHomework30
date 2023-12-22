using PrototipPattern;
using PrototipPattern.Documents;
using PrototipPattern.Persons;
using System.Text;

Person person = new Person
            ("Иван Петров", 44, new Passport("445566", new DateTime(2000, 01, 01)));

Person clonedPerson = person.MyClone();


Student student = new Student
("Александр Васильев", 19, new Passport("12345", new DateTime(2010, 8, 23)),
"МГУ", "Географический", 2, new RecordBook("abc123"));

Student clonedStudent = student.MyClone();


GraduateStudent graduateStudent = new GraduateStudent
("Екатерина Иванова", 25, new Passport("67890", new DateTime(2012, 4, 25)),
"ВШЭ", "ФКН", 3, new RecordBook("efg678"), "Алгебры Горенштейна и единственность аддитивных действий");

GraduateStudent clonedGraduateStudent = graduateStudent.MyClone();

List<Person> list = new List<Person>();
list.Add(person);
list.Add(clonedPerson);
list.Add(student);
list.Add(clonedStudent);
list.Add(graduateStudent);
list.Add(clonedGraduateStudent);


Console.WriteLine();

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
    Console.WriteLine();
}

Console.ReadKey();