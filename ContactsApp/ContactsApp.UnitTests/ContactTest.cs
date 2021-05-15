using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс тестов для тестирования класса Contact.
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        
        public void Setup()
        {
            _contact = new Contact();
        }

        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "Соболев";
            _contact.Surname = expected;
            
            //Act
            var actual = _contact.Surname;

            //Assert
            Assert.AreEqual(expected,actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест сеттера Surname")]
        public void TestSurnameSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Surname = "Соболев";
            
            //Assert
            Assert.AreEqual("Соболев", _contact.Surname, "Сеттер Surname присваивает неправильную фамилию");
        }

        [TestCase("Соболев!", "Должно возникать исключение, если фамилия - имеет не корректные символы",
            TestName = "Присвоение неправильной фамилии с содержанием символов")]
        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Соболев-Соболев-Соболев-Соболев-Соболев-Соболев-Соболев-Соболев",
            "Должно возникать исключение, если фамилия длиннее 50 символов",
            TestName = "Присвоение неправильной фамилии больше 50 символов")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Surname = wrongSurname;
                },
                message);
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void TestNameSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Name = "Илья";
            
            //Assert
            Assert.AreEqual("Илья", _contact.Name, "Сеттер Name присваивает неправильное имя");
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "Илья";
            _contact.Name = expected;

            //Act
            var actual = _contact.Name;

                //Assert
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        [TestCase("Илья!", "Должно возникать исключение, если Имя - имеет не корректные символы",
            TestName = "Присвоение неправильного Имени с содержанием символов")]
        [TestCase("", "Должно возникать исключение, если Имя - пустая строка",
            TestName = "Присвоение пустой строки в качестве Имени")]
        [TestCase("Илья-Илья-Илья-Илья-Илья-Илья-Илья-Илья-Илья-Илья-Илья-Илья",
            "Должно возникать исключение, если Имя длиннее 50 символов",
            TestName = "Присвоение неправильного Имени больше 50 символов")]
        public void TestNameSet_ArgumentException(string wrongName, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Name = wrongName;
                },
                message);
        }

        [Test(Description = "Позитивный тест сеттера Email")]
        public void TestEmailSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Email = "ilya@mail.ru";

            //Assert
            Assert.AreEqual("ilya@mail.ru", _contact.Email, "Сеттер Email присваивает неправильный Email");
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void TestEmailGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "ilya@mail.ru";
            _contact.Email = expected;

            //Act
            var actual = _contact.Email;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный Email");
        }

        [TestCase("ilyamail.ru", "Должно возникать исключение, если Email - не имеет @",
            TestName = "Присвоение неправильного Email без @")]
        [TestCase("", "Должно возникать исключение, если Email - пустая строка",
            TestName = "Присвоение пустой строки в качестве Имени")]
        [TestCase("ilya@mail.ru-ilya@mail.ru-ilya@mail.ru-ilya@mail.ru-ilya@mail.ru-ilya@mail.ru",
            "Должно возникать исключение, если Email длиннее 50 символов",
            TestName = "Присвоение неправильного Email больше 50 символов")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Email = wrongEmail;
                },
                message);
        }

        [Test(Description = "Позитивный тест сеттера IdVk")]
        public void TestIdVkSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.IdVk = "danilmordovin2000";

            //Assert
            Assert.AreEqual("danilmordovin2000", _contact.IdVk, "Сеттер IdVk присваивает неправильный IdVk");
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void TestIdVkGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "danilmordovin2000";
            _contact.IdVk = expected;

            //Act
            var actual = _contact.IdVk;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер IdVk возвращает неправильный IdVk");
        }

        [TestCase("", "Должно возникать исключение, если IdVk - пустая строка",
            TestName = "Присвоение пустой строки в качестве IdVk")]
        [TestCase("danilmordovin2000-danilmordovin2000-danilmordovin2000",
            "Должно возникать исключение, если IdVk длиннее 15 символов",
            TestName = "Присвоение неправильного IdVk больше 15 символов")]
        public void TestIdVkSet_ArgumentException(string wrongIdVk, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.IdVk = wrongIdVk;
                },
                message);
        }

        [Test(Description = "Позитивный тест сеттера DateBirth")]
        public void TestDateBirthSet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = new DateTime(2000, 10, 20);

            //Act
            _contact.DateBirth = expected;

            //Assert
            Assert.AreEqual(expected, _contact.DateBirth, "Сеттер DateBirth присваивает неправильный DateBirth");
        }

        [Test(Description = "Позитивный тест геттера DateBirth")]
        public void TestDateBirthGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = new DateTime(2000,1,1);
            _contact.DateBirth = expected;

            //Act
            var actual = _contact.DateBirth;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер DateBirth возвращает неправильный DateBirth");
        }

        [TestCase("1800,1,1", "Должно возникать исключение, если DateBirth - меньше 1900 года",
            TestName = "Присвоение неправильного DateBirth ранее 1900 года")]
        [TestCase("2022,1,1",
            "Должно возникать исключение, если DateBirth позднее текущей даты", 
            TestName = "Присвоение неправильного DateBirth позднее текущей даты")]
        public void TestDateBirthSet_ArgumentException(DateTime wrongDateBirth, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.DateBirth = wrongDateBirth;
                },
                message);
        }

    }

}