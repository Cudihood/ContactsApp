using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;


namespace ContactsAppUI
{
    class Program
    {
        static void Main()
        {

            Contact contact = new Contact("asd", "sfsd", DateTime.Now, "sadasdasf",
                "sdadad", 79609721441);
            
           
            Console.WriteLine($"Имя: {contact.Name}  Фамилия: {contact.Surname}  Дата рождения: {contact.DateBirth}  " +
                                  $"E-mail: {contact.Email}  ID VK: {contact.IdVk}  Номер телефона: {contact.Number}");
           

            Project data = new Project();
            data.Contacts.Add(contact);
            ProjectManager.SaveToFile(project: data, ProjectManager.DefaultFileName);

            System.Threading.Thread.Sleep(10000);
        }
    }
}
