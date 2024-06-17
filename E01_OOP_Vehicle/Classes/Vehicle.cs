using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle
{
    public abstract class Vehicle : IVehicle
    {
        #region Properties
        public int Id { get; set; }
        public EnumMakeCar CarMake { get;  set; }
        public EnumModel Model { get;  set; }
        public int Year { get;  set; }
        #endregion

        #region Methods
        public abstract void Create();
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
        public virtual void Move()
        {
            Console.WriteLine("Vehicle is moving.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
        #endregion
    }

}
   



