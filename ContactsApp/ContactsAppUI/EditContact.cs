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
    public partial class EditContact : Form
    {
        private Contact _contact;

        public EditContact()
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
                if (_contact == null) return;
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
            _contact = new Contact(
                NameTextBox.Text, 
                SurnameTextBox.Text, 
                DateTimePicker.Value,
                EmailTextBox.Text, 
                IdTextBox.Text, 
                Convert.ToInt64(NumberTextBox.Text));
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _contact = null;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
