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
    }


}
