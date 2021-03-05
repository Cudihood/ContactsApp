using System;


namespace NoteApp
{
    /// <summary>
    /// Класс номер хранящий информацию о номере телефона контакта.
    /// </summary>
    public class NumberPhone
    {

        /// <summary>
        /// Номер контакта.
        /// </summary>
        private long _number;

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public long Number
        {
            get { return _number; }
            set
            {
                if (value < 70000000000 || value > 79999999999)
                {
                    throw new ArgumentException("Ошибка. Номер должен начинаться с 7 и содержать 11 цифр");
                }
                else
                {
                    _number = value;
                }
            }
        }

        /// <summary>
        /// Конструктор принимающий на вход номер.
        /// </summary>
        /// <param name="number"></param>
        public NumberPhone(long number)
        {
            Number = number;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public NumberPhone() { }
    }
}