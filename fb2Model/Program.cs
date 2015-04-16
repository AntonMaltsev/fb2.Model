namespace fb2Console
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices.ComTypes;
    using System.Xml;
    using System.Xml.Serialization;

    using fb2.Model;

    class Program
    {
        static void Main(string[] args)
        {
            var book = Deserialize<FictionBook>(@"C:\Users\fenri_000\Desktop\Игры\ФБ\Kamenistyiyi_A._Rayibesposhadnyiyi1._Rayi_Besposhadnyiyi.fb2");
            Console.WriteLine(book.description.titleinfo.booktitle.Value);
            Console.ReadKey();
        }

        public static T Deserialize<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Shit happened. Selected file not found.");
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var settings = new XmlReaderSettings
                                   {
                                       CheckCharacters = true,
                                       IgnoreComments = true,
                                       IgnoreWhitespace = true
                                   };
                using (var reader = XmlReader.Create(stream, settings))
                {
                    var result = (T)xmlSerializer.Deserialize(reader);
                    return result;
                }
            }

            return default(T);
        }
    }
}
