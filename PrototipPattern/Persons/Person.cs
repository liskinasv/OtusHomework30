using PrototipPattern.Abstractions;
using PrototipPattern.Documents;
using System.Text;

namespace PrototipPattern.Persons
{
    /// <summary>
    /// Класс, представляющий человека.
    /// </summary>
    public class Person : IMyCloneable<Person>, ICloneable
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возраст.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Паспорт.
        /// </summary>
        public Passport Passport { get; set; }


        public Person(string name, int age, Passport passport)
        {
            Name = name;
            Age = age;
            Passport = new Passport(passport.PassportNumber, passport.IssuingDate);
        }

        public virtual Person MyClone()
        {
            var person = new Person(Name, Age, Passport);

            return person;
        }


        public virtual object Clone()
        {
            return MyClone();
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Имя: {Name}\n");
            sb.Append($"Возраст: {Age}\n");
            sb.Append($"Номер паспорта: {Passport.PassportNumber}\n");
            sb.Append($"Дата выдачи: {Passport.IssuingDate.ToString("dd/MM/yyyy")}\n");

            return sb.ToString();
        }

    }
}
