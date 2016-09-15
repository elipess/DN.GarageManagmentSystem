using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private string  m_vehicleOwner;
        private string  m_OwenerPhoneNumber;
        private eVehicleStatus m_VehicleStatus;
        private VehiclesHolder m_VehiclesHolder = new VehiclesHolder();
            
        public enum eVehicleStatus
        {
            Repairing,
            Fixed,
            Payed
        }

        public void addNewVehicleToGarage(Vehicle i_NewVehicle ,string m_vehicleOwner, string m_OwenerPhoneNumber)
        {
            //
        }
    }
}