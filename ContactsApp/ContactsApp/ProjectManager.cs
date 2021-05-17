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
                var defaultFileName = appDataFolder + $@"\ContactsApp\";
                return defaultFileName;
            }
        }

        /// <summary>
        /// Метод для сохранения информации
        /// </summary>
        public static void SaveToFile(Project project, string fileName, string folder)
        {
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            if (!File.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(folder+fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод для загрузки информации по контактам
        /// </summary>
        public static Project LoadFromFile(string fileName, string folder)
        {
            try
            {

                if (!File.Exists(folder + fileName))
                {
                    return new Project();
                }

                var project = new Project();
                var serializer = new JsonSerializer();

                using (var sr = new StreamReader(folder + fileName))
                using (var reader = new JsonTextReader(sr))
                {
                    project = (Project) serializer.Deserialize<Project>(reader);
                    if (project == null)
                    {
                        return new Project();
                    }
                }

                return project;
            }
            catch(Exception)
            {
                return new Project();
            }
        }
    }
}
   
