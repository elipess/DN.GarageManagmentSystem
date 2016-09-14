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
        private const float k_GasTankCapacity = 130;
        private const VehicleFuelTank.eFuelType k_FuelType = VehicleFuelTank.eFuelType.Soler;
       
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
