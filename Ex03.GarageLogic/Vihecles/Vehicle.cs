using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected string m_Model;
        protected string m_PlateNumber;
        protected float m_PercentOfRemainingEnergy;
        protected List<Wheel> m_Wheels;      
        protected readonly int m_NumOfWheels;
        protected readonly int m_WheelAirPressure;


        public Vehicle(string i_Model, string i_PlateNumber,  
                       string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer) 
                               
        {
            m_Model = i_Model;
            m_PlateNumber = i_PlateNumber;
            m_Wheels = new List<Wheel>();
        }
        
        public string Model
        {
            get
            {
                return m_Model;
            }
            set
            {
                m_Model = value;
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
                return int m_NumOfWheels;
            }
        }



    }
}
