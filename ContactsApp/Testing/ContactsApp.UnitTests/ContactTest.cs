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

        [Test(Description = "���������� ���� �������/������� Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "�������";
            
            
            //Act
            _contact.Surname = expected;
            var actual = _contact.Surname;

            //Assert
            Assert.AreEqual(expected,actual, "������ Surname ���������� ��� ����������� ������������ �������");
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
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Surname = wrongSurname;
                },
                message);
        }

        [Test(Description = "���������� ���� �������/������� Name")]
        public void TestNameGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "����";
            

            //Act
            _contact.Name = expected;
            var actual = _contact.Name;

                //Assert
            Assert.AreEqual(expected, actual, "������ Name ���������� ��� ����������� ������������ ���");
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
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Name = wrongName;
                },
                message);
        }


        [Test(Description = "���������� ���� �������/������� Email")]
        public void TestEmailGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "ilya@mail.ru";
            

            //Act
            _contact.Email = expected;
            var actual = _contact.Email;

            //Assert
            Assert.AreEqual(expected, actual, "������ Email ���������� ��� ����������� ������������ Email");
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
            Contact _contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    //Act
                    _contact.Email = wrongEmail;
                },
                message);
        }

        [Test(Description = "���������� ���� �������/������� IdVk")]
        public void TestIdVkGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = "danilmordon2000";
            

            //Act
            _contact.IdVk = expected;
            var actual = _contact.IdVk;

            //Assert
            Assert.AreEqual(expected, actual, "������ IdVk ���������� ��� ����������� ������������ IdVk");
        }

        [TestCase("", "������ ��������� ����������, ���� IdVk - ������ ������",
            TestName = "���������� ������ ������ � �������� IdVk")]
        [TestCase("danilmordovin2000-danilmordovin2000-danilmordovin2000",
            "������ ��������� ����������, ���� IdVk ������� 15 ��������",
            TestName = "���������� ������������� IdVk ������ 15 ��������")]
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


        [Test(Description = "���������� ���� �������/������� DateBirth")]
        public void TestDateBirthGet_CorrectValue()
        {
            //Setup
            Contact _contact = new Contact();
            var expected = new DateTime(2000,1,1);

            //Act
            _contact.DateBirth = expected;
            var actual = _contact.DateBirth;

            //Assert
            Assert.AreEqual(expected, actual, "������ DateBirth ���������� ��� ����������� ������������ DateBirth");
        }

        [TestCase("1800,1,1", "������ ��������� ����������, ���� DateBirth - ������ 1900 ����",
            TestName = "���������� ������������� DateBirth ����� 1900 ����")]
        [TestCase("2022,1,1",
            "������ ��������� ����������, ���� DateBirth ������� ������� ����", 
            TestName = "���������� ������������� DateBirth ������� ������� ����")]
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