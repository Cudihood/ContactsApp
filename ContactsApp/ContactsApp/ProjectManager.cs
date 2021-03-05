using System;
using System.IO;
using Newtonsoft.Json;


namespace ContactsApp
{
    /// <summary>
    /// Реализует чтение и запись проекта в файл.
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// переменная хранящая путь к сохранению файла сериализации
        /// </summary>
        public static string DefaultFileName
        {
            get
            {
                var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var defaultFileName = appDataFolder + $@"\ContactsApp\contacts.json";
                return defaultFileName;
            }
        }

        /// <summary>
        /// Метод для сохранения информации
        /// </summary>
        public static void SaveToFile(Project project, string fileName)
        {
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            var folder = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод для загрузки информации по контактам
        /// </summary>
        public static Project LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new Project();
            }

            var project = new Project();
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(fileName))
            using (var reader = new JsonTextReader(sr))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
                if (project == null)
                {
                    return new Project();
                }
            }
            return project;
        }
    }
}
   
