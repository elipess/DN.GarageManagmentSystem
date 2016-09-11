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



    }
}
