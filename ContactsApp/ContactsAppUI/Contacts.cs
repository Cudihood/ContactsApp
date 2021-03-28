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
    public partial class Contacts : Form
    { 
        /// <summary>
        /// Переменная хранящая все контакты.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Переменная хранящая путь к файлу.
        /// </summary>
        private string defaultFileName = ProjectManager.DefaultFileName;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Contacts()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile("Contacts.json",defaultFileName);
            foreach (var contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Вы действительно хотите выйти из программы?",
                "Завершение программы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Открывает окно "О программе".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Вызывает метод радактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
           AddContact();
        }

        /// <summary>
        /// Вызывает метод редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Метод добавления контакта.
        /// </summary>
        private void AddContact()
        {
            EditContact editContact = new EditContact();
            editContact.ShowDialog();

            if(editContact.Contact==null)return;
            _project.Contacts.Add(editContact.Contact);
            ContactsListBox.Items.Add(editContact.Contact.Surname);
        }

        /// <summary>
        /// Метод редактирования контакта.
        /// </summary>
        private void EditContact()
        {
            if (_project.Contacts.Count == 0) return;
            if (ContactsListBox.SelectedIndex == -1) return;
            var selectedIndex = ContactsListBox.SelectedIndex;
            var editContact = new EditContact
            {
                Contact = _project.Contacts[selectedIndex]
            };
            editContact.ShowDialog();
            var updateContact = editContact.Contact;

            ContactsListBox.Items.RemoveAt(selectedIndex);
            _project.Contacts.RemoveAt(selectedIndex);
            _project.Contacts.Insert(selectedIndex, updateContact);
            var contact = updateContact.Surname;
            ContactsListBox.Items.Insert(selectedIndex, contact);
        }

        /// <summary>
        /// Вызывает метод редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Вызывает метод редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Метод удаления контакта.
        /// </summary>
        private void DeleteContact()
        {
            if (ContactsListBox.Items.Count <= 0) return;

            var selectedIndex = ContactsListBox.SelectedIndex;
            DialogResult result = MessageBox.Show("Вы хотите удалить контакт " +
                                                  _project.Contacts[selectedIndex].Surname + "?",
                "Verification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(selectedIndex);
                ContactsListBox.Items.RemoveAt(selectedIndex);
            }
        }

        /// <summary>
        /// Выводит данные о контакте на экран.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;

            if (ContactsListBox.Items.Count>0)
            {
                NameTextBox.Text = _project.Contacts[ContactsListBox.SelectedIndex].Name;
                SurnameTextBox.Text = _project.Contacts[ContactsListBox.SelectedIndex].Surname;
                DateTimePicker1.Value = _project.Contacts[ContactsListBox.SelectedIndex].DateBirth;
                EmailTextBox.Text = _project.Contacts[ContactsListBox.SelectedIndex].Email;
                NumberTextBox.Text = _project.Contacts[ContactsListBox.SelectedIndex].Number.Number.ToString();
                IdTextBox.Text = _project.Contacts[ContactsListBox.SelectedIndex].IdVk;
            }
            
        }

        /// <summary>
        /// Вызывает метод удаления контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        /// Вызывает метод удаления контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        
        private void Contacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_project,"Contacts.json", defaultFileName);
        }
    }
}
