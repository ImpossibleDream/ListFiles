using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ListFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "C://Users/admin/DeskTop/Daily Report";
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {
                Console.WriteLine(file.FullName);
            }
            Console.ReadKey();
        }
    }
}
