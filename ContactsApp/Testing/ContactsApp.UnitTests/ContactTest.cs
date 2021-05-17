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

        [Test(Description = "Позитивный тест геттера/сеттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "Соболев";
            
            
            //Act
            _contact.Surname = expected;
            var actual = _contact.Surname;

            //Assert
            Assert.AreEqual(expected,actual, "Геттер Surname возвращает или присваивает неправильную фамилию");
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
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Surname = wrongSurname;
                },
                message);
        }

        [Test(Description = "Позитивный тест геттера/сеттера Name")]
        public void TestNameGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "Илья";
            

            //Act
            _contact.Name = expected;
            var actual = _contact.Name;

                //Assert
            Assert.AreEqual(expected, actual, "Геттер Name возвращает или присваивает неправильное имя");
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
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Name = wrongName;
                },
                message);
        }


        [Test(Description = "Позитивный тест геттера/сеттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "ilya@mail.ru";
            

            //Act
            _contact.Email = expected;
            var actual = _contact.Email;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер Email возвращает или присваивает неправильный Email");
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
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Email = wrongEmail;
                },
                message);
        }

        [Test(Description = "Позитивный тест геттера/сеттера IdVk")]
        public void TestIdVkGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "danilmordon2000";
            

            //Act
            _contact.IdVk = expected;
            var actual = _contact.IdVk;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер IdVk возвращает или присваивает неправильный IdVk");
        }

        [TestCase("", "Должно возникать исключение, если IdVk - пустая строка",
            TestName = "Присвоение пустой строки в качестве IdVk")]
        [TestCase("danilmordovin2000-danilmordovin2000-danilmordovin2000",
            "Должно возникать исключение, если IdVk длиннее 15 символов",
            TestName = "Присвоение неправильного IdVk больше 15 символов")]
        public void TestIdVkSet_ArgumentException(string wrongIdVk, string message)
        {
            //Setup
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.IdVk = wrongIdVk;
                },
                message);
        }


        [Test(Description = "Позитивный тест геттера/сеттера DateBirth")]
        public void TestDateBirthGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = new DateTime(2000,1,1);

            //Act
            _contact.DateBirth = expected;
            var actual = _contact.DateBirth;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер DateBirth возвращает или присваивает неправильный DateBirth");
        }

        [TestCase("1800,1,1", "Должно возникать исключение, если DateBirth - меньше 1900 года",
            TestName = "Присвоение неправильного DateBirth ранее 1900 года")]
        [TestCase("2022,1,1",
            "Должно возникать исключение, если DateBirth позднее текущей даты", 
            TestName = "Присвоение неправильного DateBirth позднее текущей даты")]
        public void TestDateBirthSet_ArgumentException(DateTime wrongDateBirth, string message)
        {
            //Setup
            Contact _contact = new Contact();

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