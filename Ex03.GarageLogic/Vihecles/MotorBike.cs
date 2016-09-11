using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class MotorBike : Vehicle
    {
        protected const int k_MotorBikeNumOfWheels = 2;
        protected const int k_MaxWheelsAirPressure = 29;

        protected eLicenseType m_LicenseType;
        protected int m_EngineCapacity;
     
        public enum eLicenseType
        {
            A,
            A1,
            B1,
            B2 
        }

        public eLicenseType LicenseType
        {
            get
            {
                return m_LicenseType;
            }
            set
            {
                m_LicenseType = value;
            }
        }

        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
            set
            {
                m_EngineCapacity = value;
            }
        }

    }
}
