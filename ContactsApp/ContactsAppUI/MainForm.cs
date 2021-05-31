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
            CurrentContacts.Clear();
            foreach (var contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
                CurrentContacts.Add(contact);
            }
        }

        /// <summary>
        /// Список актуальных контактов
        /// </summary>
        private List<Contact> CurrentContacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile("Contacts.json",_defaultFileName);
            FindContacts();
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
            var result = editContact.ShowDialog();

            if (result != DialogResult.OK) 
            {
                return;
            }
            _project.Contacts.Add(editContact.Contact);
            ContactsListBox.Items.Add(editContact.Contact.Surname);
            CurrentContacts.Add(editContact.Contact);
            FindContacts();
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
                Contact = (Contact)CurrentContacts[selectedIndex].Clone()
            };

            var result = editContact.ShowDialog();
            if (result != DialogResult.OK) 
            {
                return;
            }

            int count = ContactsListBox.Items.Count;
            var updateContact = editContact.Contact;
            var selectedContact = CurrentContacts[selectedIndex];
            ContactsListBox.Items.RemoveAt(selectedIndex);
            _project.Contacts.Remove(selectedContact);
            CurrentContacts.RemoveAt(selectedIndex);
            _project.Contacts.Insert(selectedIndex, updateContact);
            var contact = updateContact.Surname;
            ContactsListBox.Items.Insert(selectedIndex, contact);
            CurrentContacts.Insert(selectedIndex, updateContact);
            FindContacts();
            if (ContactsListBox.Items.Count == 0) 
            {
                return;
            }
            if (count != ContactsListBox.Items.Count)
            {
                selectedIndex = 0;
            }
            ContactsListBox.SelectedIndex = selectedIndex;
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
            var selectedContact = CurrentContacts[selectedIndex];
            DialogResult result = MessageBox.Show("Вы хотите удалить контакт " +
                                                  CurrentContacts[selectedIndex].Surname + "?",
                "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _project.Contacts.Remove(selectedContact);
                ContactsListBox.Items.RemoveAt(selectedIndex);
                CurrentContacts.RemoveAt(selectedIndex);
                ContactsListBox.SelectedIndex = selectedIndex - 1;
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
            var contact = CurrentContacts[ContactsListBox.SelectedIndex];
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
        /// Метод поиска контактов
        /// </summary>
        private void FindContacts()
        {
            SortedContacts();
            if (FindTextBox.Text == null)
            {
                return;
            }
            else
            {
                ContactsListBox.Items.Clear();
                CurrentContacts.Clear();
                foreach (var contact in _project.Contacts)
                {
                    if (contact.Surname.Contains(FindTextBox.Text))
                    {
                        ContactsListBox.Items.Add(contact.Surname);
                        CurrentContacts.Add(contact);
                    }
                }
            }
        }

        /// <summary>
        /// Поиск контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            FindContacts();
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
