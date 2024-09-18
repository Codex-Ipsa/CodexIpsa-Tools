using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodexIpsa_Tools
{
    internal class Program
    {
        public static String version = "0.1.0-wip";
        static void Main(string[] args)
        {
            Console.Title = version;
            Console.WriteLine(version);
            Console.WriteLine();
            Console.WriteLine("1) Generate VersionJsons from Mojang");
            Console.WriteLine("2) Convert MinecraftEdu builds");
            //Console.Write("> ");

            //String selection = Console.ReadLine();
            EduTool.start("");
        }
    }
}
