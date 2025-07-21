using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DotNetVerse.CSharp.Fundementals
{
    /*****************************************************************************************************
        Writer       : Kiran Kumar J
        Description  : Learn how to manage File operations in c# using Reading writing Appending to files
        Created Date : 21 - July - 2025
        Created By   : Kiran Kumar
        Changed Date : 21 - July - 2025
        Changed By   : Kiran Kumar
  *****************************************************************************************************/

    //| Create    | `File.Create`, `File.WriteAllText`   |
    //| Write     | `File.WriteAllText`, `StreamWriter`  |
    //| Append    | `File.AppendAllText`, `StreamWriter` |
    //| Read      | `File.ReadAllText`, `StreamReader`   |
    //| Delete    | `File.Delete`                        |
    //| Check     | `File.Exists`                        |

    internal class FilesManagement
    {
        string filePath = "C:\\DotNet\\JIRARecap\\DotNetVerse\\Data\\data.txt";
        internal void FilesManagementWithFileExample()
        {

            // Writing to a File:
            //string filePath = "sample.txt";
            File.WriteAllText(filePath, "This is the first line.\nThis is the second line.");

            //Appending to a File:
            File.AppendAllText(filePath, "\nThis is an appended line.");

            // Reading from a File:
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

        }

        internal void FilesManagementWithStreamReadAndWriter()
        {

            // Write with StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("First line using StreamWriter");
            }
            // Read with StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
