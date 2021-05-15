using System;
using System.Collections.Generic;
using System.Text;


namespace ContactsApp
{
    /// <summary>
    /// Класс проект храняший список контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Обьявление списка контактов.
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Сортировка контактов по алфавиту.
        /// </summary>
        /// <param name="contact"></param>
        public List<Contact> SortedContacts()
        {
            this.Contacts.Sort();
            return Contacts;
        }

        /// <summary>
        /// Поиск дня рождения контакта.
        /// </summary>
        /// <param name="dataBirthday"></param>
        /// <returns></returns>
        public List<Contact> SearchBirthdayContact(DateTime dataBirthday)
        {
            List<Contact> contactBirthday = new List<Contact>();
            foreach (var contact in Contacts)
            {
                if (contact.DateBirth.Month == dataBirthday.Month && contact.DateBirth.Day == dataBirthday.Day)
                {
                    contactBirthday.Add(contact);
                }
            }

            return contactBirthday;
        }
    }


}
