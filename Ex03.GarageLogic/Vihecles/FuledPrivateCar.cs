using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuledPrivateCar : PrivateCar
    {
        private const float k_FuelTankCapacity = 43;
        private const VehicleFuelTank.eFuelType k_FuelType = VehicleFuelTank.eFuelType.Octan95;
    }
}
