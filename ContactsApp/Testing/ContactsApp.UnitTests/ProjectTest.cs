using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс тестов для тестирования класса Project
    /// </summary>
    [TestFixture]
    class ProjectTest
    {

        [Test(Description = "Позитивный тест Project")]
        public void TestProjectSet_CorrectValue()
        {
            //Setup
            Project _project = new Project();
            var expected = _project.Contacts.Count;

            //Act
            var actual = 0;

            //Assert
            Assert.AreEqual(expected,actual,"Проект пуст");

        }


    }
}
