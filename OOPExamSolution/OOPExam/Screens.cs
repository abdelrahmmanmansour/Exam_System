using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public static class Screens
    {
        static void ExaminationSystem()
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("  ______                 _       _   _       _   _       _____           _                  ");
            Console.WriteLine(" |  ____|               (_)     | | (_)     | \\ | |     / ____|         | |                 ");
            Console.WriteLine(" | |__   _ __ ___   __ _ _ _ __ | |_ _  __ _|  \\| | ___| (___  _   _ ___| |_ ___ _ __ ___   ");
            Console.WriteLine(" |  __| | '_ ` _ \\ / _` | | '_ \\| __| |/ _` | . ` |/ _ \\\\___ \\| | | / __| __/ _ \\ '_ ` _ \\  ");
            Console.WriteLine(" | |____| | | | | | (_| | | | | | |_| | (_| | |\\  |  __/____) | |_| \\__ \\ ||  __/ | | | | | ");
            Console.WriteLine(" |______|_| |_| |_|\\__,_|_|_| |_|\\__|_|\\__, |_| \\_|\\___|_____/ \\__, |___/\\__\\___|_| |_| |_| ");
            Console.WriteLine("                                          __/ |                 __/ |                      ");
            Console.WriteLine("                                         |___/                 |___/                       ");
            Console.WriteLine("===========================================================================================");
        }
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine(" __        __   _                            _          ");
            Console.WriteLine(" \\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___    ");
            Console.WriteLine("  \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\ ");
            Console.WriteLine("   \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |   ");
            Console.WriteLine("    \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/ ");
            Console.WriteLine("=======================================================");

            ExaminationSystem();

            // Sleep for 3 seconds
            Thread.Sleep(4000);

            // Reset console color and clear screen
            Console.ResetColor();
            Console.Clear();
        }
    }
}
