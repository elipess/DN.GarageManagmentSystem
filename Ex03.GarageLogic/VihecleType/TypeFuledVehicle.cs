using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class TypeFuledVehicle
    {

        private float m_CurrentAmountOfFuelLiters;
        private readonly float m_MaxTankCapacityLiters;
        private eFuelType m_FuelType;
        
        public enum eFuelType
        {
            Soler,
            Octane95,
            Octane96,
            Octane98
        }

        public void refuel(float i_AddedFuelAmountLiters, eFuelType i_FuelType)
        {
           //
        }


    }
}
