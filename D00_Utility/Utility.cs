using System;
using System.Text;

namespace D00_Utility
{

    public class Utility
    {

        public static void SetUnicodeConsole()
        {

            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");                        
            Console.OutputEncoding = Encoding.UTF8;
            
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

        }
        
        public static void WriteTitle(string title, string beginTitle = "", string endTitle = "")
        {

            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine($"{beginTitle}{new string('-', 60)}");
            
            Console.WriteLine(title.ToUpper());

            Console.WriteLine($"{new string('-', 60)}{endTitle}");

            Console.ForegroundColor = ConsoleColor.White;
            
        }

        public static void WriteMessage(string message, string beginMessage = "", string endMessage = "")
        {

            Console.Write($"{beginMessage}{message}{endMessage}");

        }

        public static void PauseConsole()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n\n\n\nPrime qualquer tecla para continuares.");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            Console.Clear();

        }

        public static void TerminateConsole()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\n\n\n\nPrime qualquer tecla para terminares.");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            Console.Clear();

        }        

    }

}
