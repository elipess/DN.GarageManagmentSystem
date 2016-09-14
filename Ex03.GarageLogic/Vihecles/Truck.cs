using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public sealed class Truck : Vehicle
    {

        private const int k_TruckNumOfWheels = 16;
        private const int k_MaxWheelsAirPressure = 30;
        private bool m_ContainsDangerousSubstance;
        private float m_MaxAllowedCarryingWeight;
        private const float k_FuelTankCapacity = 130;
        private const VehicleFuelTank.eFuelType k_FuelType = VehicleFuelTank.eFuelType.Soler;
        private VehicleFuelTank m_FuelTank = new VehicleFuelTank(k_FuelTankCapacity, k_FuelType, 0);



        public Truck(string i_Model, string i_PlateNumber, int i_EngineCapacity,
                                 string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer,
                                 eCarColor i_CarColor, ePrivateCarNumOfDoors i_PrivateCarNumOfDoors)
            : base(i_Model, i_PlateNumber, i_EngineCapacity,
                   i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer,
                   i_CarColor, i_PrivateCarNumOfDoors)
        {
        }
        public int TruckNumOfWheels
        {
            get
            {
                return k_TruckNumOfWheels;
            }
        }

        public int MaxWheelsAirPressure
        {
            get
            {
                return k_MaxWheelsAirPressure;
            }
        }

        public bool ContainsDangerousSubstance
        {

            get
            {
                return m_ContainsDangerousSubstance;
            }
            set
            {
                m_ContainsDangerousSubstance = value;
            }
        }

        public float MaxAllowedCarryingWeight
        {
            get
            {
                return m_MaxAllowedCarryingWeight;
            }
            set
            {
                m_MaxAllowedCarryingWeight = value;
            }
        }
    }
}
