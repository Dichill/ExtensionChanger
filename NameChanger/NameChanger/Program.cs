using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameChanger
{
    class Program
    {

        static void Main(string[] args)
        {
            string cExtension;
            string rExtension;

            Console.WriteLine("Example: .jdyi | Make sure to include the dot!");
            Console.WriteLine("Current File Extension: ");
            cExtension = Console.ReadLine();
            

            Console.WriteLine("Replace with (Default is blank): ");
            rExtension = Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo("./");
            FileInfo[] infos = dir.GetFiles();

            foreach (FileInfo f in infos)
            {
                File.Move(f.FullName, f.FullName.Replace(cExtension, rExtension));
                Console.WriteLine("Files Found " + infos);
            }

        }
    }
}
