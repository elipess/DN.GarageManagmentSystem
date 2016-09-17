using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleBattery
    {
        private float m_CurrentBatteryTimeRemainingHours;
        private readonly float m_MaxBatteryTimeHours;


        public VehicleBattery(float i_MaxBatteryTimeHours, float i_CurrentBatteryTimeRemainingHours)
        {
            m_MaxBatteryTimeHours = i_MaxBatteryTimeHours;
            m_CurrentBatteryTimeRemainingHours = i_CurrentBatteryTimeRemainingHours;
        }
        public void recharge(float i_AddedBatteryAmountminuts)   
        {
            if (i_AddedBatteryAmountminuts <= 0 || (m_CurrentBatteryTimeRemainingHours * 60) + i_AddedBatteryAmountminuts  > (m_MaxBatteryTimeHours * 60))
            {
                throw new ValueOutOfRangeException(new Exception("Wrong added amount"));
            }

            m_CurrentBatteryTimeRemainingHours = ((m_CurrentBatteryTimeRemainingHours * 60)  + i_AddedBatteryAmountminuts) / 60;
        }
       public float CurrentBatteryTimeRemainingHours
        {
            get
            {
                return m_CurrentBatteryTimeRemainingHours;
            }
            set
            {
                m_CurrentBatteryTimeRemainingHours = value;
            }
      
        }

       public float MaxBatteryTimeHours
       {
           get
           {
               return m_MaxBatteryTimeHours;
           }
       }

    }
}
