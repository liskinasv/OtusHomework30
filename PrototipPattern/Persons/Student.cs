using PrototipPattern.Documents;
using System.Text;

namespace PrototipPattern.Persons
{
    /// <summary>
    /// Класс, представляющий студента.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Университет.
        /// </summary>
        public string University { get; set; }
        /// <summary>
        /// Факультет.
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Год обучения.
        /// </summary>
        public int YearOfStudy { get; set; }
        /// <summary>
        /// Зачетная книжка.
        /// </summary>
        public RecordBook RecordBook { get; set; }


        public Student(string name, int age, Passport passport,
            string university, string department, int yearOfStudy, RecordBook recordBook
            ) : base(name, age, passport)
        {
            University = university;
            Department = department;
            YearOfStudy = yearOfStudy;
            RecordBook = new RecordBook(recordBook.Number);
        }

        public override Student MyClone()
        {
            var student = new Student(Name, Age, Passport, University, Department, YearOfStudy, RecordBook);

            return student;
        }


        public override object Clone()
        {
            return MyClone();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());

            sb.Append($"Университет: {University}\n");
            sb.Append($"Факультет: {Department}\n");
            sb.Append($"Год обучения: {YearOfStudy}\n");
            sb.Append($"Зачетная книжка: {RecordBook.Number}\n");

            return sb.ToString();
        }

    }
}
