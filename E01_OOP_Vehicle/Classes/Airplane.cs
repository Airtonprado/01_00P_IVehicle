using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    public class Airplane : Vehicle, IAirplane
    {
        public string PlaneRegistration { get; set; }
        public EnumPlaneType Type { get; set; }
        public double CurrentAltitude { get; set; }
        public double MaxAltitude { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Nome: {Type}");
        }

        public override void Create()
        {

            Console.WriteLine("Creating an airplane...");
            Console.WriteLine("Choose an airplane type:");
            foreach (EnumPlaneType type in Enum.GetValues(typeof(EnumPlaneType)))
            {
                Console.WriteLine($"{(int)type}. {type}");
            }
            Console.Write("Enter your choice: ");
            Type = (EnumPlaneType)Enum.Parse(typeof(EnumPlaneType), Console.ReadLine());

            Console.Write("Enter Plane Registration: ");
            PlaneRegistration = Console.ReadLine();

            Console.Write("Enter Max Altitude (m): ");
            MaxAltitude = double.Parse(Console.ReadLine());

            Console.WriteLine("Airplane created successfully!");
        }

        public void TakeOff()
        {
            CurrentAltitude = MaxAltitude / 2; // Example logic
            Console.WriteLine($"Airplane is taking off and reached {CurrentAltitude} meters.");
        }

        public void Land()
        {
            CurrentAltitude = 0;
            Console.WriteLine("Airplane has landed.");
        }


    }

}