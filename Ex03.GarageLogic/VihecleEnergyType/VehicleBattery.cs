using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleBattery
    {
        private float m_CurrentBatteryTimeRemainingHours;
        private readonly float m_MaxBatteryTimeHours;


        public VehicleBattery(float i_MaxBatteryTimeHours )
        {
            m_MaxBatteryTimeHours = i_MaxBatteryTimeHours;
        }
        public void recharge(float i_AddedBatteryAmountHours)   
        {
            /////
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
