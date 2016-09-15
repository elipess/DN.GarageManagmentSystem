using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehiclesHolder
    {
        private readonly Dictionary<string, Vehicle> r_VehiclesInGarage;
        public VehiclesHolder()
        {
            r_VehiclesInGarage = new Dictionary<string, Vehicle>();
        }

        public enum eVehicleType
        {
            FuiledMotorBike,
            ElectricMotorBike,
            FuiledPrivateCar,
            ElectricPrivateCar,
            Truck
        }

        public void CreateNewVehicle(Vehicle i_NewVehicle)
        {  
            eVehicleType  m_Type = (eVehicleType) Enum.Parse(typeof(eVehicleType),i_NewVehicle.GetType().Name);
    
            switch(m_Type)
            {
                case eVehicleType.FuiledMotorBike :
                    r_VehiclesInGarage.Add(i_NewVehicle.PlateNumber, i_NewVehicle as FuledMotorBike);
                    break;
                case eVehicleType.ElectricMotorBike :
                    r_VehiclesInGarage.Add(i_NewVehicle.PlateNumber, i_NewVehicle as ElectricMotorBike);
                    break;
                case eVehicleType.FuiledPrivateCar :
                    r_VehiclesInGarage.Add(i_NewVehicle.PlateNumber, i_NewVehicle as FuledPrivateCar);
                    break;
                case eVehicleType.ElectricPrivateCar :
                    r_VehiclesInGarage.Add(i_NewVehicle.PlateNumber, i_NewVehicle as ElectricPrivateCar);
                    break;
                case eVehicleType.Truck :
                    r_VehiclesInGarage.Add(i_NewVehicle.PlateNumber, i_NewVehicle as Truck);
                    break;
            }
        }
    }
}

