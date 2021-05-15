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
        private Project _project;

        public void Setup()
        {
            _project = new Project();
        }

        [TestCase(null, "Должно возникать исключение, если проект - пустой",
            TestName = "Присвоение пустого значения в проект")]
        public void TestProjectSet_ArgumentException(Project wrongProject, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _project = wrongProject;
                    ;
                },
                message);
        }
    }
}
