﻿using System;


namespace NoteApp
{
    /// <summary>
    /// Класс контакт храняший информацию о имени, фамилии, номера телефона,
    /// даты рождения,e-mail и ID ВКонтакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Дата рождения. Дата рождения не может быть более текущей даты
        /// и не может быть менее 1900 года
        /// </summary>
        private DateTime _dateBirth;

        /// <summary>
        /// Эмаил контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// ID контакта.
        /// </summary>
        private string _idVkontacte;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Ошибка. Имя не должно превышать 50 символов");
                }
                else if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Ошибка. Пустая строка");
                }
                else
                {
                    value= value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Ошибка. Фамилия не должно превышать 50 символов");
                }
                else if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Ошибка. Пустая строка");
                }
                else
                {
                    value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    _surname = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает e-mail контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Ошибка. E-mail не должно превышать 50 символов");
                }
                else if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Ошибка. Пустая строка");
                }
                else
                {
                    value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    _email = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает ID Вконтакте.
        /// </summary>
        public string IdVkonacte
        {
            get { return _idVkontacte; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Ошибка. ID не должно превышать 15 символов");
                }
                else if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Ошибка. Пустая строка");
                }
                else
                {
                    _idVkontacte = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения.
        /// </summary>
        public DateTime DateBirth
        {
            get { return _dateBirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Ошибка. Дата не может быть более текущей даты.");
                }
                else if (value.Year < 1900)
                {
                    throw new ArgumentException("Ошибка. Дата не может быть меньше 1900 года.");
                }
                else
                {
                    _dateBirth = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public NumberPhone Number { get; set; }


        /// <summary>
        /// Реализация интерфейса IClonable
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Конструктор контакта.
        /// </summary>
        public Contact(string name, string surname, DateTime dateBirth, string email, string idVkontacte, long number)
        {
            Name = name;
            Surname = surname;
            DateBirth = dateBirth;
            Email = email;
            IdVkonacte = idVkontacte;
            NumberPhone.Number = number;
        }

        /// <summary>
        /// Выводит данные о контакте на экран.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {_name}  Фамилия: {_surname}  Дата рождения: {_dateBirth}  " +
                              $"E-mail: {_email}  ID VK: {_idVkontacte}  Номер телефона: {NumberPhone.Number}" );
        }
    }
    
}
