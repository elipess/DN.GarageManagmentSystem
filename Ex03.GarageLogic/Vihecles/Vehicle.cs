using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class MandatoriesHolder<T>
    {
        private T m_Value;
        private string m_Description;

        public MandatoriesHolder(string i_Description)
        {
            m_Description = i_Description;
        }

        public override string ToString()
        {
            return m_Description;
        }
 
    
        public T Value
        {
            get
            {
                return m_Value;
            }

            set
            {
                m_Value = value;
            }
        }

        public string Description
        {
            get
            {
                return m_Description;
            }

            set
            {
                m_Description = value;
            }
        }
    }
    public abstract class Vehicle
    {
        protected MandatoriesHolder<string> m_Model = new MandatoriesHolder<string>("Model");
        protected string m_PlateNumber;
        protected float m_PercentOfRemainingEnergy;
        protected List<Wheel> m_Wheels;
        private string m_TypeName;      
        protected readonly int m_NumOfWheels;
        protected readonly int m_WheelAirPressure;


        public Vehicle(string i_Model, string i_PlateNumber,  
                       string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer) 
                               
        {
            m_Model.Value = i_Model;
            m_PlateNumber = i_PlateNumber;
            m_Wheels = new List<Wheel>();
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
    }
}
