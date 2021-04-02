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
    public partial class MainForm : Form
    { 
        /// <summary>
        /// Переменная хранящая все контакты.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Переменная хранящая путь к файлу.
        /// </summary>
        private string _defaultFileName = ProjectManager.DefaultFileName;

        /// <summary>
        /// Вывод на экран отсортированый список.
        /// </summary>
        private void SortedContacts()
        {
            _project.SortedContacts();
            ContactsListBox.Items.Clear();
            foreach (var contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile("Contacts.json",_defaultFileName);
            _project.SortedContacts();
            SortedContacts();
            BirthdayContact();
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ContactForm editContact = new ContactForm();
            editContact.ShowDialog();

            if (editContact.Contact == null)
            {
                return;
            }
            _project.Contacts.Add(editContact.Contact);
            ContactsListBox.Items.Add(editContact.Contact.Surname);
            SortedContacts();
        }

        /// <summary>
        /// Метод редактирования контакта.
        /// </summary>
        private void EditContact()
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                return;
            }

            var selectedIndex = ContactsListBox.SelectedIndex;
            var editContact = new ContactForm
            {
                Contact = _project.Contacts[selectedIndex]
            };

            editContact.ShowDialog();
            if (editContact.Contact == null)
            {
                return;
            }

            var updateContact = editContact.Contact;

            ContactsListBox.Items.RemoveAt(selectedIndex);
            _project.Contacts.RemoveAt(selectedIndex);
            _project.Contacts.Insert(selectedIndex, updateContact);
            var contact = updateContact.Surname;
            ContactsListBox.Items.Insert(selectedIndex, contact);
            SortedContacts();
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
            if (ContactsListBox.Items.Count <= 0)
            {
                return;
            }

            var selectedIndex = ContactsListBox.SelectedIndex;
            DialogResult result = MessageBox.Show("Вы хотите удалить контакт " +
                                                  _project.Contacts[selectedIndex].Surname + "?",
                "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
            if (ContactsListBox.SelectedIndex == -1)
            {
                return;
            }

            var contact = _project.Contacts[ContactsListBox.SelectedIndex];
            NameTextBox.Text = contact.Name;
            SurnameTextBox.Text = contact.Surname;
            DateTimePicker1.Value = contact.DateBirth;
            EmailTextBox.Text = contact.Email;
            NumberTextBox.Text = contact.Number.Number.ToString();
            IdTextBox.Text = contact.IdVk;
            
            
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

        /// <summary>
        /// Поиск контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactsListBox.Items.Clear();

            if (FindTextBox.Text == null)
            {
                SortedContacts();
                return;
            }
            else
            {
                foreach (var contact in _project.Contacts)
                {

                    if (contact.Surname.Contains(FindTextBox.Text))
                    {
                        ContactsListBox.Items.Add(contact.Surname);
                    }
                }
            }
            
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contacts_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Вы действительно хотите выйти из программы?",
                "Завершение программы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ProjectManager.SaveToFile(_project, "Contacts.json", _defaultFileName);
            }
        }

        /// <summary>
        /// Выводит сообщение о имениниках.
        /// </summary>
        private void BirthdayContact()
        {
            var birthdayContact = _project.SearchBirthdayContact(DateTime.Now);
            if (birthdayContact.Count != 0)
            {
                BirthdayPanel.Visible = true;
                foreach (var contact in birthdayContact)
                {
                    if (contact != birthdayContact.Last())
                    {
                        BirthdayTextBox.Text += contact.Surname + ", ";
                    }
                    else
                    {
                        BirthdayTextBox.Text += contact.Surname;
                    }
                }
            }
            else
            {
                BirthdayPanel.Visible = false;
            }
            
                
            
        }
    }
}
