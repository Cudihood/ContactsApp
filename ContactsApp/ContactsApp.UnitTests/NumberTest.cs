using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс тестов для тестирования класса номер.
    /// </summary>
    [TestFixture]
    public class NumberTest
    {
        private Contact _contact;

        public void Setup()
        {
            _contact = new Contact();
        }

        [Test(Description = "Позитивный тест геттер Nomber")]
        public void TestNomberGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = 77777777777;
            _contact.Number.Number = expected;

            //Act
            var actual = _contact.Number.Number;

            //Assert
            Assert.AreEqual(expected,actual,"Геттер Nomber возвращает неправильный номер");
        }

        [Test(Description = "Позитивный тест сеттер Nomber")]
        public void TestNomberSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Number.Number = 77777777777;

            //Assert
            Assert.AreEqual(77777777777, _contact.Number.Number, "Геттер Nomber возвращает неправильный номер");
        }

        [TestCase(70342, "Должно возникать исключение если номер - содержит меньше 11 цифр",
            TestName = "Присвоение неправильного номера содержащего меньще 11 цифр")]
        [TestCase(89609721441, "Должно возникать исключение если номер - начинается не с 7",
            TestName = "Присвоение неправильного номера начинающегося не с 7")]
        [TestCase(796097214413, "Должно возникать исключение если номер - содержит больше 11 цифр",
            TestName = "Присвоение неправильного номера содержащего больше 11 цифр")]
        [TestCase(null, "Должно возникать исключение если номер - пустая строка",
            TestName = "Присвоение пустой строки в качестве номера")]
        public void TestNomberSet_ArgumentException(long wrongNomber, string message)
        {
            //Setup
            Setup();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Number.Number = wrongNomber;
                },
                message);
        }


    }
}
