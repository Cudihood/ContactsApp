using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;

namespace NoteAppUI
{
    class Program
    {
        static void Main()
        {
            Contact contact = new Contact("asd","sfsd",DateTime.Now, "sadasdasf",
                "sdadad",79609721441);
            contact.GetInfo();

            Project date = new Project();
            ProjectManager.SaveToFile(project: date, fileName: "savefile");

            System.Threading.Thread.Sleep(10000);


        }



    }
    
}
