using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Переменная класса контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Переменная хранящая некорректные символы для Имени и Фамилии.
        /// </summary>
        string _invalidСharacter = @"0123456789!№%:,.;()_+=-@#$%^&*\|/?<>§±~][`";


        public ContactForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Возвращает и задает конакта.
        /// </summary>
        public Contact Contact
        {
            get { return _contact;}

            set
            {
                _contact = value;
                if (_contact == null)
                {
                    return;
                }
                SurnameTextBox.Text = Contact.Surname;
                    NameTextBox.Text = Contact.Name;
                    NumberTextBox.Text = Contact.Number.Number.ToString();
                    DateTimePicker.Value = Contact.DateBirth;
                    IdTextBox.Text = Contact.IdVk;
                    EmailTextBox.Text = Contact.Email;
            }
        }
        
        /// <summary>
        /// Добовляет или изменяет данные у пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Okbutton_Click(object sender, EventArgs e)
        {
            _contact = new Contact();
            _contact.Name = NameTextBox.Text;
            _contact.Surname = SurnameTextBox.Text;
            _contact.DateBirth = DateTimePicker.Value;
            _contact.Email = EmailTextBox.Text;
            _contact.IdVk = IdTextBox.Text;
            _contact.Number.Number = Convert.ToInt64(NumberTextBox.Text);
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Отменить и закрыть окно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RevokeButton_Click(object sender, EventArgs e)
        {
            _contact = null;
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Фамилия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text.Length > 50)
            {
                SurnameTextBox.BackColor = Color.Red;
                return;
            }
            else
            {
                SurnameTextBox.BackColor = Color.White;
            }

            bool check = false;
            for (int i = 0; i < SurnameTextBox.Text.Length; i++)
            {
                foreach (var symbol in _invalidСharacter)
                {
                    if (SurnameTextBox.Text[i] == symbol)
                    {
                        SurnameTextBox.BackColor = Color.Red;
                        check = true;
                    }
                }
            }

            if (check != true)
            {
                SurnameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Имя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 50)
            {
                NameTextBox.BackColor = Color.Red;
                return;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }

            bool check = false;
            for (int i = 0; i < NameTextBox.Text.Length; i++)
            {
                foreach (var symbol in _invalidСharacter)
                {
                    if (NameTextBox.Text[i] == symbol)
                    {
                        NameTextBox.BackColor = Color.Red;
                        check = true;
                    }
                }
            }

            if (check != true)
            {
                NameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Номер телефона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NumberTextBox.Text == String.Empty)
            {
                NumberTextBox.BackColor = Color.White;
                return;
            }
            if (NumberTextBox.Text[0] != '7' || NumberTextBox.Text.Length != 11)
            {
                NumberTextBox.BackColor = Color.Red;
            }
            else
            {
                for (int i = 0; i < NumberTextBox.Text.Length; i++)
                {
                    if (!Char.IsDigit(NumberTextBox.Text[i]))
                    {
                        NumberTextBox.BackColor = Color.Red;
                        return;
                    }
                }
                NumberTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Length > 50 || !EmailTextBox.Text.Contains("@"))
            {
                EmailTextBox.BackColor = Color.Red;
            }
            else
            {
                EmailTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле ID Вконтакте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Length > 15)
            {
                IdTextBox.BackColor = Color.Red;
            }
            else
            {
                IdTextBox.BackColor = Color.White;
            }
        }
    }
}
