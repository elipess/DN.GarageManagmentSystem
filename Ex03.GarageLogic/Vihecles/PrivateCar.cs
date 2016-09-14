using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class PrivateCar : Vehicle
    {
        protected const int k_CarNumOfWheels = 4;
        protected const int k_MaxWheelsAirPressure = 34;

        protected eCarColor m_CarColor;
        protected ePrivateCarNumOfDoors m_PrivateCarNumOfDoors;

        public PrivateCar(string i_Model, string i_PlateNumber, int i_EngineCapacity, 
                                 string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer,
                                 eCarColor i_CarColor, ePrivateCarNumOfDoors i_PrivateCarNumOfDoors)
                                 : base(i_Model, i_PlateNumber,
                                        i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer)
                                        
        {
            m_CarColor = i_CarColor;
            m_PrivateCarNumOfDoors = i_PrivateCarNumOfDoors;
        }
        public enum eCarColor
        {
            White,
            Black,
            Blue,
            Silver    
        }
        public enum ePrivateCarNumOfDoors
        {
            Two   = 2,
            Three = 3,
            Four  = 4,
            Five  = 5
        }


        public eCarColor CarColor
        {
            get 
            {
                return m_CarColor;
            }
            set
            {
                m_CarColor = value;
            }
        }

        public ePrivateCarNumOfDoors PrivateCarNumOfDoors
        {
            get
            {
                return m_PrivateCarNumOfDoors;
            }
            set
            {
                m_PrivateCarNumOfDoors = value;
            }
        }

        public int CarNumOfWheels
        {
            get
            {
                return k_CarNumOfWheels;
            }
        }

        public int MaxWheelsAirPressure
        {
            get
            {
                return k_MaxWheelsAirPressure;
            }
        }
    }

    
}
