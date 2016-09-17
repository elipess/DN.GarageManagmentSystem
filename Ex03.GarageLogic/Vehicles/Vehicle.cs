using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    
    public abstract class Vehicle
    {
        protected string m_TypeName;
        protected string m_Manufactor;
        protected string m_PlateNumber;
        protected float m_PercentOfRemainingEnergy;
        protected Wheel[] m_Wheels;
        protected readonly int m_NumOfWheels;
        protected readonly int m_WheelAirPressure;
        private Dictionary<string, string> m_Details = new Dictionary<string, string>();

        public Vehicle(string i_PlateNumber)
        {
            m_PlateNumber = i_PlateNumber;
        }

        public Vehicle(string i_Manufactor, string i_PlateNumber,
                            string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer, int i_NumOfWheels)
        {
            m_Manufactor = i_Manufactor;
            m_PlateNumber = i_PlateNumber;
            m_Wheels = new Wheel[i_NumOfWheels];
            createVehicleWheels(i_NumOfWheels, i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer);
        }

        private void createVehicleWheels(int i_NumOfWheels, string i_WheelsManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer)
        {
            for (int currentWheel = 0; currentWheel < i_NumOfWheels; currentWheel++)
            {
                m_Wheels[currentWheel] = new Wheel(i_WheelsManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer);
            }
        }

        public abstract bool FillDetails(Dictionary<string, string> i_Dic); //Eylon

        public Dictionary<string, string> CloneDemandsDic()
        {
            Dictionary<string, string> resDic = new Dictionary<string, string>(Details.Count);

            foreach (var pair in Details)
            {
                resDic[pair.Key] = pair.Value;
            }

            return resDic;
        }

        internal abstract bool ValidateDic(Dictionary<string, string> i_Dic); // Eylon implement foreach vehcile

        #region Accessors
        protected Dictionary<string, string> Demands
        {
            get
            {
                return Details;
            }

            set
            {
                Details = value;
            }
        }
        public string PlateNumber
        {
            get
            {
                return m_PlateNumber;
            }
            set
            {
                m_PlateNumber = value;
            }
        }

        public float PercentOfRemainingEnergy
        {
            get
            {
                return m_PercentOfRemainingEnergy;
            }
            set
            {
                m_PercentOfRemainingEnergy = value;
            }
        }

        public int NumOfWheels
        {
            get
            {
                return m_NumOfWheels;
            }
        }

        public string TypeName
        {
            get
            {
                return m_TypeName;
            }

            set
            {
                m_TypeName = value;
            }
        }

        public Dictionary<string, string> Details
        {
            get
            {
                return m_Details;
            }

            set
            {
                m_Details = value;
            }
        }

        #endregion

    }
}
