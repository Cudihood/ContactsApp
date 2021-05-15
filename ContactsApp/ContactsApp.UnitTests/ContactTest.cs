using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// ����� ������ ��� ������������ ������ Contact.
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        
        public void Setup()
        {
            _contact = new Contact();
        }

        [Test(Description = "���������� ���� ������� Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "�������";
            _contact.Surname = expected;
            
            //Act
            var actual = _contact.Surname;

            //Assert
            Assert.AreEqual(expected,actual, "������ Surname ���������� ������������ �������");
        }

        [Test(Description = "���������� ���� ������� Surname")]
        public void TestSurnameSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Surname = "�������";
            
            //Assert
            Assert.AreEqual("�������", _contact.Surname, "������ Surname ����������� ������������ �������");
        }

        [TestCase("�������!", "������ ��������� ����������, ���� ������� - ����� �� ���������� �������",
            TestName = "���������� ������������ ������� � ����������� ��������")]
        [TestCase("", "������ ��������� ����������, ���� ������� - ������ ������",
            TestName = "���������� ������ ������ � �������� �������")]
        [TestCase("�������-�������-�������-�������-�������-�������-�������-�������",
            "������ ��������� ����������, ���� ������� ������� 50 ��������",
            TestName = "���������� ������������ ������� ������ 50 ��������")]
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

        [Test(Description = "���������� ���� ������� Name")]
        public void TestNameSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Name = "����";
            
            //Assert
            Assert.AreEqual("����", _contact.Name, "������ Name ����������� ������������ ���");
        }

        [Test(Description = "���������� ���� ������� Name")]
        public void TestNameGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "����";
            _contact.Name = expected;

            //Act
            var actual = _contact.Name;

                //Assert
            Assert.AreEqual(expected, actual, "������ Name ���������� ������������ ���");
        }

        [TestCase("����!", "������ ��������� ����������, ���� ��� - ����� �� ���������� �������",
            TestName = "���������� ������������� ����� � ����������� ��������")]
        [TestCase("", "������ ��������� ����������, ���� ��� - ������ ������",
            TestName = "���������� ������ ������ � �������� �����")]
        [TestCase("����-����-����-����-����-����-����-����-����-����-����-����",
            "������ ��������� ����������, ���� ��� ������� 50 ��������",
            TestName = "���������� ������������� ����� ������ 50 ��������")]
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

        [Test(Description = "���������� ���� ������� Email")]
        public void TestEmailSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.Email = "ilya@mail.ru";

            //Assert
            Assert.AreEqual("ilya@mail.ru", _contact.Email, "������ Email ����������� ������������ Email");
        }

        [Test(Description = "���������� ���� ������� Name")]
        public void TestEmailGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "ilya@mail.ru";
            _contact.Email = expected;

            //Act
            var actual = _contact.Email;

            //Assert
            Assert.AreEqual(expected, actual, "������ Email ���������� ������������ Email");
        }

        [TestCase("ilyamail.ru", "������ ��������� ����������, ���� Email - �� ����� @",
            TestName = "���������� ������������� Email ��� @")]
        [TestCase("", "������ ��������� ����������, ���� Email - ������ ������",
            TestName = "���������� ������ ������ � �������� �����")]
        [TestCase("ilya@mail.ru-ilya@mail.ru-ilya@mail.ru-ilya@mail.ru-ilya@mail.ru-ilya@mail.ru",
            "������ ��������� ����������, ���� Email ������� 50 ��������",
            TestName = "���������� ������������� Email ������ 50 ��������")]
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

        [Test(Description = "���������� ���� ������� IdVk")]
        public void TestIdVkSet_CorrectValue()
        {
            //Setup
            Setup();
            _contact.IdVk = "danilmordovin2000";

            //Assert
            Assert.AreEqual("danilmordovin2000", _contact.IdVk, "������ IdVk ����������� ������������ IdVk");
        }

        [Test(Description = "���������� ���� ������� Name")]
        public void TestIdVkGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = "danilmordovin2000";
            _contact.IdVk = expected;

            //Act
            var actual = _contact.IdVk;

            //Assert
            Assert.AreEqual(expected, actual, "������ IdVk ���������� ������������ IdVk");
        }

        [TestCase("", "������ ��������� ����������, ���� IdVk - ������ ������",
            TestName = "���������� ������ ������ � �������� IdVk")]
        [TestCase("danilmordovin2000-danilmordovin2000-danilmordovin2000",
            "������ ��������� ����������, ���� IdVk ������� 15 ��������",
            TestName = "���������� ������������� IdVk ������ 15 ��������")]
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

        [Test(Description = "���������� ���� ������� DateBirth")]
        public void TestDateBirthSet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = new DateTime(2000, 10, 20);

            //Act
            _contact.DateBirth = expected;

            //Assert
            Assert.AreEqual(expected, _contact.DateBirth, "������ DateBirth ����������� ������������ DateBirth");
        }

        [Test(Description = "���������� ���� ������� DateBirth")]
        public void TestDateBirthGet_CorrectValue()
        {
            //Setup
            Setup();
            var expected = new DateTime(2000,1,1);
            _contact.DateBirth = expected;

            //Act
            var actual = _contact.DateBirth;

            //Assert
            Assert.AreEqual(expected, actual, "������ DateBirth ���������� ������������ DateBirth");
        }

        [TestCase("1800,1,1", "������ ��������� ����������, ���� DateBirth - ������ 1900 ����",
            TestName = "���������� ������������� DateBirth ����� 1900 ����")]
        [TestCase("2022,1,1",
            "������ ��������� ����������, ���� DateBirth ������� ������� ����", 
            TestName = "���������� ������������� DateBirth ������� ������� ����")]
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