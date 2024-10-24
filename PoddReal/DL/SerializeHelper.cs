using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DL
{
    internal class SerializeHelper<T>
    {
        public void tillXml(List<T> list, String filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            serializer.Serialize(fileStream, list);
            fileStream.Close();
            Debug.WriteLine("test");
        }

        public List<T> laddaIn(String filePath)
        {
            List<T> lista = new List<T>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Filen finns inte: " + filePath);
                return lista; // Returnera en tom lista om filen inte finns
            }
            else
            {          
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            lista = (List<T>)serializer.Deserialize(fileStream);
            fileStream.Close();
            return lista;
            }

        }
    }
}
