using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_OOP_Vehicle
{
    internal class MenuHandler
    {
        public static void ShowMainMenu()
        {
            Utility.WriteTitle("Menu Vehicles", "\n");
            Utility.WriteMessage("Choose a vehicle type:", "\n");
            Utility.WriteMessage("1. Car", "\n");
            Utility.WriteMessage("2. Submarine", "\n");
            Utility.WriteMessage("3. Airplane", "\n");
            Utility.WriteMessage("Enter your choice:", "\n");
        }

        public static void HandleCar()
        {
            #region Car
            Car myCar = new Car();

            Console.WriteLine("Enter Car details:");
            Console.Write("Id: ");
            myCar.Id = int.Parse(Console.ReadLine());
            Console.Write("Car Make (BMW/Mercedes): ");
            myCar.CarMake = (EnumMakeCar)Enum.Parse(typeof(EnumMakeCar), Console.ReadLine(), true);
            Console.Write("Model (Sedan/Hatch/SUV): ");
            myCar.Model = (EnumModel)Enum.Parse(typeof(EnumModel), Console.ReadLine(), true);
            Console.Write("Year: ");
            myCar.Year = int.Parse(Console.ReadLine());
            Console.Write("Color (Red/Blue/Green/Yellow/Black): ");
            myCar.Color = (EnumCarColor)Enum.Parse(typeof(EnumCarColor), Console.ReadLine(), true);
            Console.Write("Number of Doors (Two/Four/Five): ");
            myCar.NumberOfDoors = (EnumNumberOfDoors)Enum.Parse(typeof(EnumNumberOfDoors), Console.ReadLine(), true);
            Console.Write("Max Speed (km/h): ");
            myCar.MaxSpeed = double.Parse(Console.ReadLine());

            myCar.Create();
            myCar.Start();
            myCar.Move();
            myCar.IncreaseSpeed(50);
            myCar.DecreaseSpeed(30);
            myCar.Honk();
            myCar.Park();
            myCar.Stop();
            #endregion
        }

        public static void HandleSubmarine()
        {
            #region Submarine Example
            Submarine mySubmarine = new Submarine();
            Utility.WriteMessage("Enter Submarine details:", "\n");
            Console.Write("Id: ");
            mySubmarine.Id = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            mySubmarine.Year = int.Parse(Console.ReadLine());
            Console.Write("Pennant Number: ");
            mySubmarine.PennantNumber = Console.ReadLine();
            Console.Write("Type (Nuclear/Pesquisa/Atomico): ");
            mySubmarine.Type = (EnumSubmarineType)Enum.Parse(typeof(EnumSubmarineType), Console.ReadLine(), true);
            Console.Write("Max Depth (m): ");
            mySubmarine.MaxDepth = double.Parse(Console.ReadLine());

            mySubmarine.Create();
            mySubmarine.Start();
            mySubmarine.Move();
            mySubmarine.Dive(300);
            mySubmarine.Emerge();
            mySubmarine.Stop();
            #endregion
        }

        public static void HandleAirplane()
        {
            Airplane myAirplane = new Airplane();
            Console.WriteLine("\nEnter Airplane details:");
            Console.Write("Id: ");
            myAirplane.Id = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            myAirplane.Year = int.Parse(Console.ReadLine());
            Console.Write("Plane Registration: ");
            myAirplane.PlaneRegistration = Console.ReadLine();

            // Mostrando os tipos de avião disponíveis
            Console.WriteLine("Type Options:");
            foreach (EnumPlaneType type in Enum.GetValues(typeof(EnumPlaneType)))
            {
                Console.WriteLine($"{(int)type}. {type}");
            }

            Console.Write("Select the type of airplane: ");
            EnumPlaneType selectedType;
            if (!Enum.TryParse(Console.ReadLine(), out selectedType))
            {
                Console.WriteLine("Invalid input. Defaulting to Boing.");
                selectedType = EnumPlaneType.Boing; // Se a entrada for inválida, define o tipo como Boing por padrão
            }
            myAirplane.Type = selectedType;

         
            // Continuar com as operações do avião
            myAirplane.Create();
            myAirplane.Start();
            myAirplane.TakeOff();
            myAirplane.Move();
            myAirplane.Land();
            myAirplane.Stop();
        }
    }
}