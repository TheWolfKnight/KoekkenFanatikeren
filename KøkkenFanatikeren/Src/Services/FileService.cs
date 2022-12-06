/*
    Skrevet af: Philip Knudsen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace KøkkenFanatikeren.Src.Services
{
    public class FileService
    {
        public string Path { get; private set; }

        /// <summary>
        /// Creates a file at the desired destionation
        /// </summary>
        /// <param name="path"> The path for the file to be Writen/Read to </param>
        public FileService(string path) => Path = path;


        /// <summary>
        /// Enumerates over a files lines, and yields them to caller
        /// </summary>
        /// <returns> An IEnumerable of strings, containing the lines of the file </returns>
        public IEnumerable<string> ReadFileLineByLine(string path)
        {
            if (!File.Exists(path)) {
                yield break;
            }

            // Creates a StreamReader to open the file
            using ( StreamReader reader = new StreamReader(path) )
            {
                // creates a variable named line, to store each line in the file
                string line = null;

                // loops over the lines in the file, and yield them to the caller
                while ( (line = reader.ReadLine()) != null )
                {
                    yield return line;
                }
            }
        }


        /// <summary>
        /// Writes a block of text to the file path
        /// </summary>
        /// <param name="content"> The text to be writen in the file </param>
        public void WriteFile(string content)
        {
            File.WriteAllText(Path, content);
        }


        /// <summary>
        /// Writes a block of text to the file path
        /// </summary>
        /// <param name="content"> An array of text to be writen in the file </param>
        public void WriteFile(IEnumerable<string> content)
        {
            File.WriteAllLines(Path, content);
        }


        /// <summary>
        /// Adds text to the back of the file defined in Paht
        /// </summary>
        /// <param name="content"> The content to be written to the file </param>
        public void AppendFile(string content)
        {
            File.AppendAllText(Path, content);
        }

        public void AppendFile(string content)
        {
            File.AppendAllText(Path, content);
        }


    }
}
