using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatopia.FlatopiaEngine
{
    public class Log
    {
        public static void Normal(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[Message] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"[INFO] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
