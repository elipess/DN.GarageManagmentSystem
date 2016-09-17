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

        public MotorBike(string i_PlateNumber) : base(i_PlateNumber)
        {
        }
        public MotorBike(string i_Model, string i_PlateNumber, int i_EngineCapacity,
                                 string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer,
                                 MotorBike.eLicenseType i_LicenseType)
                                 : base(i_Model, i_PlateNumber,
                                        i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer, k_MotorBikeNumOfWheels)
                                        
        {
            m_EngineCapacity = i_EngineCapacity;
            m_LicenseType = i_LicenseType;
            initDic();
        }

        private void initDic()
        {
            Demands["Engine capacity"] = null;
        }

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

        public int MotorBikeNumOfWheels
        {
            get
            {
                return k_MotorBikeNumOfWheels;
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
