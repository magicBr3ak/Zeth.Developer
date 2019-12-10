using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Zeth.Developer.ViewModel.Application
{
    public static partial class Context
    {
        private static string APP_PATH = string.Empty;

        public static string MapPath(this string relativePath)
        {
            if (string.IsNullOrEmpty(APP_PATH))
            {
                APP_PATH = Assembly.GetExecutingAssembly().Location;
            }

            return System.IO.Path.Combine(APP_PATH, relativePath);
        }
        public static T Deserialize<T>(this string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }
        public static void Serialize<T>(this string filePath, T value)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var fileStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(fileStream, value);
            }
        }
    
    
    }
}
