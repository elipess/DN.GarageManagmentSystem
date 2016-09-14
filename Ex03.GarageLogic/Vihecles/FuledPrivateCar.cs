using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuledPrivateCar : PrivateCar
    {
        private const float k_FuelTankCapacity = 43;
        private const VehicleFuelTank.eFuelType k_FuelType = VehicleFuelTank.eFuelType.Octan95;


        public FuledPrivateCar(string i_Model, string i_PlateNumber, int i_EngineCapacity,
                                 string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer,
                                 eCarColor i_CarColor, ePrivateCarNumOfDoors i_PrivateCarNumOfDoors)
            : base(i_Model, i_PlateNumber, i_EngineCapacity,
                   i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer,
                   i_CarColor, i_PrivateCarNumOfDoors)
        {
        }

        public float FuelTankCapacity
        {
            get
            {
                return k_FuelTankCapacity;
            }
        }

        public VehicleFuelTank.eFuelType FuelType
        {
            get
            {
                return k_FuelType;
            }
        }

    }      
}
