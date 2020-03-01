using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperStation.GameServer
{
    class Program
    {
        #if DEBUG
        private const string Title = "HyperStation Server (DEBUG)";
        #else
        private const string Title = "HyperStation Server (RELEASE)";
        #endif

        static void Main(string[] args)
        {
            Console.Title = Title;
            Console.WriteLine("Starting Auth Server");
            Console.ReadKey();

        }
    }
}
