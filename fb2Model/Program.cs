namespace fb2Console
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;
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

            var path = @"D:\Библиотека";
            var files = Directory.GetFiles(path, "*.fb2", SearchOption.AllDirectories);

            Console.WriteLine("Total files found: " + files.Length);

            ProcessParallel(files);
            Process(files);
            
            Console.ReadKey();
        }

        /// <summary>
        /// Processes the specified files.
        /// </summary>
        /// <param name="files">The files.</param>
        private static void Process(string[] files)
        {
            var counter = new Stopwatch();

            Console.WriteLine("Processing files in one thread.");

            counter.Start();

            foreach (var file in files)
            {
                ProcessFile(file);
            }

            counter.Stop();

            Console.WriteLine("Elapsed time to process all books:" + counter.Elapsed.ToString("g"));
            Console.WriteLine("Time per book" + new TimeSpan(counter.ElapsedTicks / files.Length).ToString("g"));
        }

        /// <summary>
        /// Processes the parallel.
        /// </summary>
        /// <param name="files">The files.</param>
        private static void ProcessParallel(string[] files)
        {
            var counter = new Stopwatch();

            Console.WriteLine("Processing files in parallel.");

            counter.Start();

            Parallel.ForEach(
                files,
                (file) =>
                    {
                        ProcessFile(file);
                    });

            counter.Stop();

            Console.WriteLine("Elapsed time to process all books:" + counter.Elapsed.ToString("g"));
            Console.WriteLine("Time per book" + new TimeSpan(counter.ElapsedTicks / files.Length).ToString("g"));
        }

        /// <summary>
        /// Processes the file.
        /// </summary>
        /// <param name="file">The file.</param>
        private static void ProcessFile(string file)
        {
            try
            {
                var book = Deserialize<FictionBook>(file);
                var titleInfo = book.description.titleinfo;
                //Console.WriteLine(titleInfo.booktitle);
                //Console.WriteLine("\t" + titleInfo.author[0].Items[0] + " " + titleInfo.author[0].Items[1]);
                //Console.WriteLine("\t" + titleInfo.date);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during reading: " + file);
            }
            finally
            {
                //Console.WriteLine();
            }
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
                Console.WriteLine("Oops. Selected file not found.");
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
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