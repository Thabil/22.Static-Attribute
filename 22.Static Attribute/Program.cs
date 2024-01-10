using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static attribute is a shows all that is shared by the objects of that class
            //its an attribute on the class itself not on the individual members of the class, it is about the class
            Songs holiday = new Songs("Holiday", "Green Day", 200);
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
