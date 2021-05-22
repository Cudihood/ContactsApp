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

        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact();

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

            try
            {
                _contact.DateBirth = DateTimePicker.Value;
                _contact.Name = NameTextBox.Text;
                _contact.Surname = SurnameTextBox.Text;
                _contact.Email = EmailTextBox.Text;
                _contact.IdVk = IdTextBox.Text;
                _contact.Number.Number = Convert.ToInt64(NumberTextBox.Text);

            }
            catch (ArgumentException exception)
            {
                MessageBox.Show($"{exception.Message}", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Строка должна содержать только цифры.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
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
            try
            {
                _contact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = Color.White;
            }
            catch 
            {
                SurnameTextBox.BackColor = Color.LightPink;
                
            }
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Имя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch 
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Номер телефона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                _contact.Number.Number = Convert.ToInt64(NumberTextBox.Text);
                NumberTextBox.BackColor = Color.White;
            }
            catch 
            {
                NumberTextBox.BackColor = Color.LightPink;
            }
            
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле Email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
            }
            catch
            {
                EmailTextBox.BackColor = Color.LightPink;
            }
            
        }

        /// <summary>
        /// Проверка на ввод корректных значений в поле ID Вконтакте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IdVk = IdTextBox.Text;
                IdTextBox.BackColor = Color.White;
            }
            catch 
            {
                IdTextBox.BackColor = Color.LightPink;
            }
            
        }
    }
}
