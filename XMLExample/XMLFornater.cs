using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLExample
{
    internal static class XMLFornater
    {
        public static void SaveAsXMLFormat(Type type, object obj, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            using (FileStream ms = new(fileName, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(ms, obj);

                Console.WriteLine("=> Saved XML");
            }
        }

        public static T LoadFromXMLFormat<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream ms = new(fileName, FileMode.Open, FileAccess.Read))
            {
                T obj = (T)serializer.Deserialize(ms);

                Console.WriteLine("=> Saved XML");
                return obj;
            }
        }
    }
}
