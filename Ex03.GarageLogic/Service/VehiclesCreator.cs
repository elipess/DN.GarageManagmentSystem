using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public static class VehiclesCreator
    {
        public enum eVehicleType
        {
            FuiledMotorBike,
            ElectricMotorBike,
            FuiledPrivateCar,
            ElectricPrivateCar,
            Truck
        }

        public static string[] GetAllVehicleTypes()
        {
            string[] o_VehicleTypes = null;
            int Length = Enum.GetNames(typeof(eVehicleType)).Length;

            for (int Curr = 0; Curr < Length ; Curr++)
            {
                o_VehicleTypes[Curr] =  ((eVehicleType)Curr).ToString();  
            }
            return o_VehicleTypes;
        }

        public static Vehicle CreateNewVehicle(string i_NewVehicleType, string i_PlateNumber)
        {
            try
            {
                eVehicleType m_Type = (eVehicleType)Enum.Parse(typeof(eVehicleType), i_NewVehicleType);

                Vehicle ObjSelector = null;

                switch (m_Type)
                {
                    case eVehicleType.FuiledMotorBike:
                         ObjSelector = new FuledMotorBike(i_PlateNumber);
                        break;
                    case eVehicleType.ElectricMotorBike:
                        ObjSelector = new ElectricMotorBike(i_PlateNumber);
                        break;
                    case eVehicleType.FuiledPrivateCar:
                        ObjSelector = new FuledPrivateCar(i_PlateNumber);
                        break;
                    case eVehicleType.ElectricPrivateCar:
                        ObjSelector = new ElectricPrivateCar(i_PlateNumber);
                        break;
                    case eVehicleType.Truck:
                        ObjSelector = new Truck(i_PlateNumber);
                        break;
                    default:
                        ObjSelector = null;
                        break;
                }
                return ObjSelector; 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }
    }
}