using System;
using System.IO;

namespace FilePractice
{
    class ReadFromAFile
    {
        public void DataReading()
        { // Taking a new input stream that is C://Users/RRagini/source/repos/FilePractice.txt and opening it
            StreamReader obj = new StreamReader("C://Users/RRagini/source/repos/FilePractice.txt");
            Console.WriteLine("Content of the file");
            // This is use to specify from where to start reading input stream
            obj.BaseStream.Seek(0, SeekOrigin.Begin);
            // Reading line from input stream
            string str = obj.ReadLine();
            // Reading the whole file line by line
            while (str != null)
            {
                Console.WriteLine(str);
                str = obj.ReadLine();
            }
            Console.ReadLine();
            // Closing the stream
            obj.Close();
        }

        static void Main(string[] arg)
        {
            ReadFromAFile obj = new ReadFromAFile();
            obj.DataReading();
        }
    }
}
