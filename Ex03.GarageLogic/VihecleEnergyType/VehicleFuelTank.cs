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


    }
}
