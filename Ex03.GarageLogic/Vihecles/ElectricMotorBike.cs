using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricMotorBike : MotorBike
    {
        private const float k_MaxBatteryWorkingTimeHours = 3.6f;

        private VehicleBattery m_Battery = new VehicleBattery(k_MaxBatteryWorkingTimeHours, 0);

        public ElectricMotorBike(string i_Model, string i_PlateNumber, int i_EngineCapacity,
                                 string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer,
                                 eLicenseType i_LicenseType) 
                                 : base(i_Model, i_PlateNumber, i_EngineCapacity,
                                        i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer,
                                        i_LicenseType)
                               
        {
        }
        
        public float MaxBatteryWorkingTime
        {
            get
            {
                return k_MaxBatteryWorkingTimeHours;
            }
        }
    

    }



}
