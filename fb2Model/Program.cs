namespace fb2Console
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using fb2.Model;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var book =
                Deserialize<FictionBook>(
                    @"C:\Users\fenri_000\Desktop\Игры\ФБ\Kamenistyiyi_A._Rayibesposhadnyiyi1._Rayi_Besposhadnyiyi.fb2");
            Console.WriteLine(book.description.titleinfo.booktitle);
            Console.ReadKey();
        }

        /// <summary>
        /// The deserialize.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
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
        }
    }
}