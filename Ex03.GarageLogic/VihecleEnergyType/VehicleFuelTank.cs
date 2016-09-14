using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleFuelTank
    {

        private float m_CurrentAmountOfFuelLiters;
        private readonly float m_MaxTankCapacityLiters;
        private eFuelType m_FuelType;


        public VehicleFuelTank(float i_MaxTankCapacityLiters, eFuelType i_FuelType, float i_CurrentAmountOfFuelLiters)
        {
            m_MaxTankCapacityLiters = i_MaxTankCapacityLiters;
            m_FuelType = i_FuelType;
            m_CurrentAmountOfFuelLiters = i_CurrentAmountOfFuelLiters;
        }
        
        public enum eFuelType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }

        public void refuel(float i_AddedFuelAmountLiters, eFuelType i_FuelType)
        {
           //
        }

        public float CurrentAmountOfFuelLiters
        {
            get
            {
                return m_CurrentAmountOfFuelLiters;
            }
            set
            {
                m_CurrentAmountOfFuelLiters = value;
            }
        }

        public float MaxTankCapacityLiters
        {
            get
            {
                return m_MaxTankCapacityLiters;
            }
        }

        public eFuelType FuelType
        {
            get
            {
                return m_FuelType;
            }
            set
            {
                m_FuelType = value;
            }
        }


    }
}
