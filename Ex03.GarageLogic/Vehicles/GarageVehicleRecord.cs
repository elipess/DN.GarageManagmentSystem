using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
using static Ex03.GarageLogic.GarageManager;

namespace Ex03.GarageLogic
{
    public class GarageVehicleRecord
    {
        private string m_VehicleOwnerName;
        private string m_OwenerPhoneNumber; 
        private eVehicleStatus m_VehicleStatus; // type changed by eylon from string to eVehicleStatus
        private Vehicle m_Vehicle;

        public GarageVehicleRecord()
        {
        }

        public GarageVehicleRecord(string i_VehicleOwner, string i_OwenerPhoneNumber, string i_VehicleStatus,Vehicle i_Vehicle)
        {
            m_VehicleOwnerName = i_VehicleOwner;
            m_OwenerPhoneNumber = i_OwenerPhoneNumber;
            VehicleStatus = i_VehicleStatus;
            Vehicle = i_Vehicle;
        }

        #region Accessors
        public string VehicleOwnerName
        {
            get
            {
                return m_VehicleOwnerName;
            }
            set
            {
                m_VehicleOwnerName = value;
            }
        }

        public string OwenerPhoneNumber
        {
            get
            {
                return m_OwenerPhoneNumber;
            }
            set
            {
                m_OwenerPhoneNumber = value;
            }
        }
        

        public Vehicle Vehicle
        {
            get
            {
                return Vehicle1;
            }

            set
            {
                Vehicle1 = value;
            }
        }

        public eVehicleStatus VehicleStatus
        {
            get
            {
                return m_VehicleStatus;
            }

            set
            {
                m_VehicleStatus = value;
            }
        }

        public Vehicle Vehicle1
        {
            get
            {
                return m_Vehicle;
            }

            set
            {
                m_Vehicle = value;
            }
        }
        #endregion
    }
}
