using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleManager
    {
        List<Vehicle> m_Vehicles = new List<Vehicle>();

        public enum eVehicleType
        {
            FuiledMotorBike,
            ElectricMotorBike,
            FuiledPrivateCar,
            ElectricPrivateCar,
            Truck
        }
    }
}

