namespace PrototipPattern.Documents
{
    /// <summary>
    /// Класс, представляющий паспорт.
    /// </summary>
    public class Passport
    {
        /// <summary>
        /// Номер паспорта.
        /// </summary>
        public string PassportNumber { get; set; }
        /// <summary>
        /// Дата выдачи.
        /// </summary>
        public DateTime IssuingDate { get; set; }

        public Passport(string passportNumber, DateTime issuingDate)
        {
            PassportNumber = passportNumber;
            IssuingDate = issuingDate;
        }

    }
}
