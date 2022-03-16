using System;
using System.IO;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Append(number);
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathWithFileName = Path.Combine(filePath, "log.txt");
            bool exists = Directory.Exists(filePath);
            if (!exists)
                Directory.CreateDirectory(filePath);
            using (StreamWriter stream = File.AppendText(pathWithFileName))
            {
                stream.Write(sb.ToString());
            }
            sb.Clear();
            string values = File.ReadAllText(pathWithFileName).ToString();
            Console.WriteLine("Number in log.txt: {0}", values);
        }
    }
}
