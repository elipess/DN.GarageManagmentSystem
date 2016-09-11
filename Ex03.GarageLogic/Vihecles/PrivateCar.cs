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
    }

    
}
