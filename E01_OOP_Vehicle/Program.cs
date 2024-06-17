using D00_Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            try
            {
                while (true)
                {
                   
                    MenuHandler.ShowMainMenu(); // Exibe o menu principal
                    int choice = int.Parse(Console.ReadLine()); // Lê a escolha do usuário

                    // Chama o método correspondente com base na escolha do usuário
                    switch (choice)
                    {
                        case 1:
                            MenuHandler.HandleCar();
                            break;
                        case 2:
                            MenuHandler.HandleSubmarine();
                            break;
                        case 3:
                            MenuHandler.HandleAirplane();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear(); // Limpa o console para exibir o menu novamente
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Utility.TerminateConsole();
            }
        }
    }
}