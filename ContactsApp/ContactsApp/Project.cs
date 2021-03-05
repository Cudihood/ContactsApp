using System;
using System.Collections.Generic;
using System.Text;


namespace NoteApp
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
    }
}
