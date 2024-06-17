using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal interface IAirplane : IVehicle
    {
        #region Properties
        string PlaneRegistration { get; set; }
        EnumPlaneType Type { get; set; }
        double CurrentAltitude { get; set; }
        double MaxAltitude { get; set; }
        #endregion

        #region Methods
        void DisplayInfo();
        void TakeOff();
        void Land();
        #endregion
    }

}
