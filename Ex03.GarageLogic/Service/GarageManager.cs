using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private readonly Dictionary<string, GarageVehicleRecord> r_VehiclesInGarage = new Dictionary<string, GarageVehicleRecord>();
        private eVehicleStatus m_VehicleStatus;

        public enum eVehicleStatus
        {
            Repairing,
            Fixed,
            Payed
        }

        public GarageVehicleRecord addNewVehicleToGarage(string i_vehicleOwner, string i_OwenerPhoneNumber, string i_PlateNumber, string i_VehicleType)
        {
            Vehicle i_NewVehicle = null;
            GarageVehicleRecord o_NewRec = null;
            if (!r_VehiclesInGarage.ContainsKey(i_PlateNumber))
            {
                string i_VehicleStatus = ((eVehicleStatus)eVehicleStatus.Repairing).ToString();
                try
                {
                    i_NewVehicle = VehiclesCreator.CreateNewVehicle(i_VehicleType , i_PlateNumber);

                    if(i_NewVehicle != null)
                    {
                        o_NewRec = new GarageVehicleRecord(i_vehicleOwner, i_OwenerPhoneNumber, i_VehicleStatus, i_NewVehicle);
                        r_VehiclesInGarage.Add(i_PlateNumber, o_NewRec);
                    }
                    else
                    {
                        o_NewRec = null;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                o_NewRec = null; 
            }
            return o_NewRec;
        }

        public bool CheckVehicleExistence(string i_PlateNumber)
        {
             bool o_IsExist = false;

             if (r_VehiclesInGarage.ContainsKey(i_PlateNumber))
             {
                 o_IsExist = true;
             }
             else
             {
                 o_IsExist = false;
             }
             return o_IsExist;
        }
           
        public string[] GetSupportedVehicleTypesNames()
        {
            string[] o_SupportedVehicleTypes = VehiclesCreator.GetAllVehicleTypes();
            return o_SupportedVehicleTypes;  
        }
        public bool ChangeStat(string i_plateNumber,string i_newStat) 
        {
            bool o_IsChanged = false;

            try
            {
                GarageVehicleRecord changeRec ; 
                r_VehiclesInGarage.TryGetValue(i_plateNumber, out changeRec);

                if(changeRec != null)
                {
                    changeRec.VehicleStatus = i_newStat;
                }
                o_IsChanged = true;
            }
            catch (KeyNotFoundException)
            {
                o_IsChanged = false;
            }
            return o_IsChanged;   
        }

        public string[] GetAvailableStatuses()
        {
            string[] o_VehicleTypes = null;
            int Length = Enum.GetNames(typeof(eVehicleStatus)).Length;

            for (int Curr = 0; Curr < Length; Curr++)
            {
                o_VehicleTypes[Curr] = ((eVehicleStatus)Curr).ToString();
            }
            return o_VehicleTypes;
        }

        public LinkedList<string> GetVehcilesPlatesByStat(string i_VehicleStatus)
        {
            LinkedList<string> strList = new LinkedList<string>();
            eVehicleStatus status;

            try
            {
                status = getStatusFromStr(i_VehicleStatus);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

            foreach (var vehcile in r_VehiclesInGarage)
            {
                if (vehcile.Value.VehicleStatus == status)
                {
                    strList.AddLast(vehcile.Key);
                }
            }

            return strList;
        }

        private eVehicleStatus getStatusFromStr(string i_VehicleStatus)
        {
            eVehicleStatus resEnum;

            try
            {
                resEnum = (eVehicleStatus)Enum.Parse(typeof(eVehicleStatus), i_VehicleStatus);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

            return resEnum;
        }

        public GarageVehicleRecord GetVehicleRecordByPlate(string i_plateNumber)
        {
            GarageVehicleRecord o_RecByPlate;
            try
            {
                r_VehiclesInGarage.TryGetValue(i_plateNumber, out o_RecByPlate);
            }
            catch (KeyNotFoundException)
            {
                o_RecByPlate = null;
            }
            return o_RecByPlate;   
        }

        public  bool CheckDicValidation(Vehicle i_Vehicle, Dictionary<string, string> i_Dic)
        {
            return i_Vehicle.ValidateDic(i_Dic);
        }
        public void FillDetailes(string i_plateNumber, Dictionary<string, string> i_Dic)
        {
            GarageVehicleRecord vehicleRecord = r_VehiclesInGarage[i_plateNumber];
            vehicleRecord.Vehicle.FillDetails(i_Dic);
        }
        public string[] GetSupportedVehicleFuelTypes()
        {
            string[] o_SupportedVehicleFuelTypes = VehicleFuelTank.GetAllVehicleFuelTypes();
            return o_SupportedVehicleFuelTypes;  
        }

        public bool FillInAirPresureToMax(string i_plateNumber)
        {
            GarageVehicleRecord rec = GetVehicleRecordByPlate(i_plateNumber);

            ////// WRITE CODE HERE  ELI

            return false;

        }
        public bool FillInFuel(string i_PlateNumber, string i_FuelType,float i_amountToEnfuel)
        {
            return false;
            ////// WRITE CODE HERE ELI
        }
        public bool ChargeElectricVehicle(string i_PlateNumber,float i_minutes)
        {
            return false;
            ////// WRITE CODE HERE ELI
        }


    }
}