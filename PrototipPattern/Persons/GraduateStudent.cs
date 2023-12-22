using PrototipPattern.Documents;
using System.Text;

namespace PrototipPattern.Persons
{
    /// <summary>
    /// Класс, представляющий аспиранта.
    /// </summary>
    public class GraduateStudent : Student
    {
        /// <summary>
        /// Тема исследования.
        /// </summary>
        public string ResearchTopic { get; set; }


        public GraduateStudent(string name, int age, Passport passport,
            string university, string department, int yearOfStudy, RecordBook recordBook, string researchTopic) :
            base(name, age, passport, university, department, yearOfStudy, recordBook)
        {
            ResearchTopic = researchTopic;
        }


        public override GraduateStudent MyClone()
        {
            var graduateStudent = new GraduateStudent(Name, Age, Passport,
                University, Department, YearOfStudy, RecordBook, ResearchTopic);

            return graduateStudent;
        }



        public override object Clone()
        {
            return MyClone();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());

            sb.Append($"Тема исследования: {ResearchTopic}");

            return sb.ToString();
        }

    }
}
