using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E01_OOP_Vehicle
{
    internal interface ISubmarine : IVehicle
    {
        #region Properties
        string PennantNumber { get; set; }
        EnumSubmarineType Type { get; set; }
        double CurrentDepth { get; set; }
        double MaxDepth { get; set; }
        #endregion

        #region Methods
        void DisplayInfo();
        void Dive(double depth);
        void Emerge();
        #endregion
    }
}
