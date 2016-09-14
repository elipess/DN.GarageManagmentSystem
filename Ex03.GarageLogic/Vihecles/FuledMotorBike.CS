using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuledMotorBike : MotorBike
    {
        private const float k_FuelTankCapacity = 7.5F;
        private const VehicleFuelTank.eFuelType k_FuelType = VehicleFuelTank.eFuelType.Octan98;
        private VehicleFuelTank m_FuelTank = new VehicleFuelTank(k_FuelTankCapacity, k_FuelType);



        public FuledMotorBike(string i_Model, string i_PlateNumber, int i_EngineCapacity,
                                 string i_WheelManufacturer, float i_CurrentAirPressure, float i_MaxWheelAirPressureByManufacturer,
                                 eLicenseType i_LicenseType) 
                                 : base(i_Model, i_PlateNumber, i_EngineCapacity,
                                        i_WheelManufacturer, i_CurrentAirPressure, i_MaxWheelAirPressureByManufacturer,
                                        i_LicenseType)
                               
        {
        }
    }
}
