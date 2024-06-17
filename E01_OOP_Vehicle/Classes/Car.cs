using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    public class Car : Vehicle, ICar
    {
        #region Properties
        public EnumCarColor Color { get; set; }
        public EnumNumberOfDoors NumberOfDoors { get; set; }
        public double CurrentSpeed { get; set; }
        public double MaxSpeed { get; set; }
        #endregion

        #region Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Nome: {CarMake}");
        }
        public override void Create()
        {
        }

        public override void Move()
        {
            Move(50); // Default speed
        }

        public void Move(double speed)
        {
            if (speed <= MaxSpeed)
            {
                CurrentSpeed = speed;
                Console.WriteLine($"Car is moving at {speed} km/h.");
            }
            else
            {
                Console.WriteLine("Speed exceeds maximum limit.");
            }
        }

        public void Park()
        {
            CurrentSpeed = 0;
            Console.WriteLine("Car is parked.");
        }

        public void Honk()
        {
            Console.WriteLine("Car is honking.");
        }

        public void IncreaseSpeed(double amount)
        {
            if (CurrentSpeed + amount <= MaxSpeed)
            {
                CurrentSpeed += amount;
                Console.WriteLine($"Car speed increased to {CurrentSpeed} km/h.");
            }
            else
            {
                Console.WriteLine("Speed increase exceeds maximum limit.");
            }
        }

        public void DecreaseSpeed(double amount)
        {
            if (CurrentSpeed - amount >= 0)
            {
                CurrentSpeed -= amount;
                Console.WriteLine($"Car speed decreased to {CurrentSpeed} km/h.");
            }
            else
            {
                Console.WriteLine("Speed decrease cannot go below 0.");
            }
        }
       
        #endregion
    }

}