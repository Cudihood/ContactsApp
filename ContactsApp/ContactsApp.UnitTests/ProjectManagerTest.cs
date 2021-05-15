using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс тестов для тестирования класса ProjectManager
    /// </summary>
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test]
        public void CorrectProject()
        {
            var project = new Project();
            var contact = new Contact("Иван",
                "Иванов",
                new DateTime(2001, 1, 1),
                "ivan@mail.ru",
                "idivan",
                79858456543);
            project.Contacts.Add(contact);

            contact = new Contact("Артем",
                "Висельчак",
                new DateTime(2011, 1, 1),
                "artem@mail.ru",
                "idartem",
                79854456543);
            project.Contacts.Add(contact);

            ProjectManager.SaveToFile(project, "CorrectProjectFile.json", "");
        }
    }
}
