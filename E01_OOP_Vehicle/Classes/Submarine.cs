using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    public class Submarine : Vehicle, ISubmarine
    {
        #region Properties
        public string PennantNumber { get; set; }
        public EnumSubmarineType Type { get; set; }
        public double CurrentDepth { get; set; }
        public double MaxDepth { get; set; }
        #endregion

        #region Methods
        public override void Create()
        {
            
        }

        public void Dive(double depth)
        {
            if (depth <= MaxDepth)
            {
                CurrentDepth = depth;
                Console.WriteLine($"Submarine is diving to {depth} meters.");
            }
            else
            {
                Console.WriteLine("Depth exceeds maximum limit.");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {PennantNumber}, Nome: {Type}");
        }

        public void Emerge()
        {
            CurrentDepth = 0;
            Console.WriteLine("Submarine has emerged.");
        }

        public override void Move()
        {
            Console.WriteLine("Submarine is moving underwater.");
        }

        public override void Stop()
        {
            Console.WriteLine("Submarine is stopping.");
        }
        #endregion
    }
}