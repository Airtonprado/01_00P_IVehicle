using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal interface ICar:IVehicle
    {
        #region Properties
        EnumCarColor Color { get; set; }
        EnumNumberOfDoors NumberOfDoors { get; set; }
        #endregion

        #region Methods
        void DisplayInfo();
        void Move(double speed);
        void Park();
        void Honk();
        void IncreaseSpeed(double amount);
        void DecreaseSpeed(double amount);
        #endregion
    }
}
