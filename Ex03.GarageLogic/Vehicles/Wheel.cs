using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{   
    public class Wheel
    {

        private string m_WheelManufacturer;
        private float m_CurrentAirPressure;
        private float m_MaxWheelAirPressureByManufacturer;


        public Wheel(string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer)
        {
            m_WheelManufacturer = i_WheelManufacturer;
            m_CurrentAirPressure = i_CurrentAirPressure;
            m_MaxWheelAirPressureByManufacturer = i_MaxWheelAirPressureByManufacturer;
        }
        public void InflateWheel(float i_HowMuchAirToFill)
        {
            ////// WRITE CODE HERE  eli

        }


        public string WheelManufacturer
        {
            get
            {
                return m_WheelManufacturer;
            }
            set
            {
                m_WheelManufacturer = value;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }
            set
            {
                m_CurrentAirPressure = value;
            }
        }

        public float MaxWheelAirPressureByManufacturer
        {
            get
            {
                return m_MaxWheelAirPressureByManufacturer;
            }
            set
            {
                m_MaxWheelAirPressureByManufacturer = value; 
            }
        }



    }
}
