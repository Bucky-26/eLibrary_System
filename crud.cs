using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace eLibrary_System
{
    class crud
    {
        public static string connection = System.IO.File.ReadAllText(System.Environment.CurrentDirectory + @"/conString.txt");
    }
}
