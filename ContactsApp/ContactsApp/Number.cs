using System;


namespace ContactsApp
{
    /// <summary>
    /// Класс номер хранящий информацию о номере телефона контакта.
    /// </summary>
    public class NumberPhone : IEquatable<NumberPhone>

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
            if (value == null)
            {
                throw new ArgumentException("Пустая строка");
            }

            if (value < 70000000000 || value > 79999999999)
            {
                throw new ArgumentException("Номер должен начинаться с 7 и содержать 11 цифр");
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
    public NumberPhone()
    {
    }

    public bool Equals(NumberPhone other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _number == other._number;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((NumberPhone) obj);
    }

    public override int GetHashCode()
    {
        return _number.GetHashCode();
    }
    }
}