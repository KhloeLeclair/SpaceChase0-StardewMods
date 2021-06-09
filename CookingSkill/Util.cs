using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CookingSkill
{
    internal class Util
    {
        // http://stackoverflow.com/a/22456034
        public static string serialize<T>(T obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(stream, obj);

                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }
    }
}
