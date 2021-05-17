using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
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

        /// <summary>
        /// Корректное имя файла
        /// </summary>
        private const string CorrectProjectFilename = "CorrectProjectFile.json";

        /// <summary>
        /// Некорректный файл
        /// </summary>
        private const string UncorrectProjectFilename = "UncorrectProjectFile.json";

        /// <summary>
        /// Корректный путь 
        /// </summary>
        private const string CorrectProjectFolder = @"TestData\";

        /// <summary>
        /// Корректные данные
        /// </summary>
        /// <returns></returns>
        private Project GetCorrectProject()
        {
            var correctProject = new Project();

            var contact = new Contact("Иван",
                "Иванов",
                new DateTime(2001, 1, 1),
                "ivan@mail.ru",
                "idivan",
                79858456543);
            correctProject.Contacts.Add(contact);

            contact = new Contact("Артем",
                "Висельчак",
                new DateTime(2011, 1, 1),
                "artem@mail.ru",
                "idartem",
                79854456543);
            correctProject.Contacts.Add(contact);

            return correctProject;
        }

        [Test(Description = "Позитивый тест загрузки в ProjectManager")]
        public void LoadFromFile_LoadCorrectData_FileLoadedCorrectly()
        {
            //Setup
            var expectedProject = GetCorrectProject();

            //Act
            var actualProject = ProjectManager.LoadFromFile(CorrectProjectFilename, CorrectProjectFolder);

            //Assert
            Assert.AreEqual(expectedProject.Contacts.Count, actualProject.Contacts.Count);
            Assert.Multiple(() =>
            {

                for (int i = 0; i < expectedProject.Contacts.Count; i++)
                {
                    var expected = expectedProject.Contacts[i];
                    var actual = actualProject.Contacts[i];
                    Assert.AreEqual(expected, actual);

                }
            });
        }

        [TestCase(Description = "Негативный тест загрузки", TestName = "Загрузка некорректного файла")]
        public void LoadFromFile_LoadUncorrectData_FileLoadUncorrectly()
        {
            //Act
            var actualProject = ProjectManager.LoadFromFile(UncorrectProjectFilename, CorrectProjectFolder);

            //Assert
            Assert.AreEqual(actualProject.Contacts.Count, 0);
        }

        [TestCase(Description = "Негативный тест загрузки пустого проекта",
            TestName = "Загрузка несуществующего файла")]
        public void LoadFromFile_LoadNullData_FileLoadNull()
        {
            //Act
            var actualProject = ProjectManager.LoadFromFile("Aadfsdfdsc", CorrectProjectFolder);

            //Assert
            Assert.AreEqual(actualProject.Contacts.Count, 0);
        }

        [Test(Description = "Позитивый тест сохранения в ProjectManager")]
        public void SaveToFile_SaveCorrectData_FileSavedCorrectly()
        {
            //Setup
            var sevedProject = GetCorrectProject();
            Directory.Delete(@"\Output");

            //Act
            ProjectManager.SaveToFile(sevedProject,"sevedFile.json",@"Output\");

            //Assert
            var actual = File.ReadAllText(@"Output\sevedFile.json");
            var expected = File.ReadAllText(CorrectProjectFolder + CorrectProjectFilename);

            Assert.AreEqual(expected, actual);
        }

    }
}
