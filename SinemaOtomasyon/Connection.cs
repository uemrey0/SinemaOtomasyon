using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SinemaOtomasyon
{
    class Connection
    {
        public static string connString = System.IO.File.ReadAllText(@"C:\connection.txt");
    }
}
