namespace PrototipPattern.Documents
{
    /// <summary>
    /// Класс, представляющий зачетную книжку.
    /// </summary>
    public class RecordBook
    {
        /// <summary>
        /// Номер зачетной книжки.
        /// </summary>
        public string Number { get; set; }

        public RecordBook(string number)
        {
            Number = number;
        }

    }
}
