using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    internal interface IVehicle
    {
        #region Properties
        int Id { get; }
        EnumMakeCar CarMake { get; }
        EnumModel Model { get;  }


        int Year { get; }
        #endregion
        #region Methods
        void Create();
        void Start();
        void Move();
        void Stop();
        #endregion
    }
}
