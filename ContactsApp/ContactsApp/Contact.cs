using System;


namespace ContactsApp
{
    /// <summary>
    /// Класс контакт храняший информацию о имени, фамилии, номера телефона,
    /// даты рождения,e-mail и ID ВКонтакте.
    /// </summary>
    public class Contact : IComparable<Contact>, IEquatable<Contact>, ICloneable
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
        private string _idVk;

        /// <summary>
        /// Переменная хранящая некорректные символы для Имени и Фамилии.
        /// </summary>
        string _invalidСharacter = @"0123456789!№%:,.;()_+=-@#$%^&*\|/?<>§±~][`";

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    foreach (var symbol in _invalidСharacter)
                    {
                        if (value[i] == symbol)
                        {
                            throw new ArgumentException("Имя должно состоять только из латинских букв или кириллицы");
                        }
                    }
                }
                if (value == string.Empty)
                {
                    throw new ArgumentException("Пустая строка");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя не должно превышать 50 символов");
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
                for (int i = 0; i < value.Length; i++)
                {
                    foreach (var symbol in _invalidСharacter)
                    {
                        if (value[i] == symbol)
                        {
                            throw new ArgumentException("Фамилия должна состоять только из латинских букв или кириллицы");
                        }
                    }
                }
                if (value == string.Empty)
                {
                    throw new ArgumentException("Пустая строка");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия не должно превышать 50 символов");
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
                if (value == string.Empty)
                {
                    throw new ArgumentException("Пустая строка");
                }
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("E-mail должен содержать '@' ");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("E-mail не должно превышать 50 символов");
                }
                else
                {
                    _email = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает ID Вконтакте.
        /// </summary>
        public string IdVk
        {
            get { return _idVk; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Пустая строка");
                }
                if (value.Length > 15)
                {
                    throw new ArgumentException("ID не должно превышать 15 символов");
                }
                else
                {
                    _idVk = value;
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
                    throw new ArgumentException("Дата не может быть больше текущей даты.");
                }
                else if (value.Year < 1900)
                {
                    throw new ArgumentException("Дата не может быть меньше 1900 года.");
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
        public NumberPhone Number { get; set; } = new NumberPhone();


        /// <summary>
        /// Реализация интерфейса IClonable
        /// </summary>
        public object Clone()
        {
            return new Contact(this.Name, this.Surname, this.DateBirth, this.Email, this._idVk,
                this.Number.Number);
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
            IdVk = idVkontacte;
            Number.Number = number;
            
        }


        public int CompareTo(Contact other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(_surname, other._surname, StringComparison.Ordinal);
        }

        public bool Equals(Contact other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _surname == other._surname &&
                   _name == other._name && 
                   _dateBirth.Equals(other._dateBirth) &&
                   _email == other._email &&
                   _idVk == other._idVk &&
                   _invalidСharacter == other._invalidСharacter &&
                   Equals(Number, other.Number);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Contact) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_surname != null ? _surname.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_name != null ? _name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _dateBirth.GetHashCode();
                hashCode = (hashCode * 397) ^ (_email != null ? _email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_idVk != null ? _idVk.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_invalidСharacter != null ? _invalidСharacter.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Number != null ? Number.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
    
}
