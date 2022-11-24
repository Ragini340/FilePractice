using System;
using System.IO;

namespace FilePractice
{
    class WriteToAFile
    {
        public void Data()
        {
            //Creating a file at the below location
            StreamWriter obj = new StreamWriter("C://Users/RRagini/source/repos/FilePractice.txt");
            // Writing on the console screen
            Console.WriteLine("Enter the message to be written on the file");
            //Reading input from the user
            string str = Console.ReadLine();
            //Writing a line in buffer
            obj.WriteLine(str);
            //Writing in output stream
            obj.Flush();
            // To close the stream
            obj.Close();
        }
    
    static void Main(string[] args)
    {
        WriteToAFile obj = new WriteToAFile();
        obj.Data();
        Console.ReadKey();
    }
  }
}