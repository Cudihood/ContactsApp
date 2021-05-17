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

        [Test(Description = "Позитивный тест геттер/сеттера Number")]
        public void TestNumberGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = 79609721441;
            

            //Act
            _contact.Number.Number = expected;
            var actual = _contact.Number.Number;

            //Assert
            Assert.AreEqual(expected,actual, "Геттер Number возвращает или присваивает неправильный номер");
        }

        [TestCase(70342, "Должно возникать исключение если номер - содержит меньше 11 цифр",
            TestName = "Присвоение неправильного номера содержащего меньще 11 цифр")]
        [TestCase(89609721441, "Должно возникать исключение если номер - начинается не с 7",
            TestName = "Присвоение неправильного номера начинающегося не с 7")]
        [TestCase(796097214413, "Должно возникать исключение если номер - содержит больше 11 цифр",
            TestName = "Присвоение неправильного номера содержащего больше 11 цифр")]
        [TestCase(null, "Должно возникать исключение если номер - пустая строка",
            TestName = "Присвоение пустой строки в качестве номера")]
        public void TestNumberSet_ArgumentException(long wrongNumber, string message)
        {
            //Setup
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Number.Number = wrongNumber;
                },
                message);
        }


    }
}
