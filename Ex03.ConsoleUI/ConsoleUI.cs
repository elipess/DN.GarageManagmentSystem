using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
using System.Reflection;

namespace Ex03.ConsoleUI
{
    class ConsoleUI
    {
        private const string k_ExitSign = "q";


        internal enum eChoise
        {
            InsertCar = 1,
            DisplayRegisteredLN,
            ChangeStat,
            FillAir,
            FuelTank,
            Charge,
            DisplayCarDetails
        }
        private GarageManager m_GarageMgr;

        public ConsoleUI(GarageManager i_GarageMgr)
        {
            m_GarageMgr = i_GarageMgr;
        }
       
        internal void MainMenu()
        {
            int choise;
            eChoise EChoise;
            string[] actions = new string[] //move to txt file
            {
                "1. Insert a new car",
                "2. Display the license numbers of the registered vehicles",
                "3. Change a vehicl's status",
                "4. Fill the wheels airs in a vehicle",
                "5. Fuel a vehicle",
                "6. Charge a electric vehicle",
                "7. Display full details of a specific vehicle"
            };

            Console.Clear();
            Console.WriteLine(
@"Hello, welcome to Itzik's garage!
What Would you like to do?
");
            foreach (string str in actions)
            {
                Console.WriteLine(str);
            }

            choise = getChoise(actions.Length);

            EChoise = (eChoise)choise;
            performAction(EChoise);
        }

        private static int getChoise(int i_MaxValue)
        {
            int choise = 0;
            do
            {
                try
                {
                    choise = Int32.Parse(Console.ReadLine());
                    if (!(choise > 0 && choise < i_MaxValue))
                    {
                        Console.WriteLine("Choise is not Supported, Please try again: ");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (choise > 0 && choise < i_MaxValue);

            return choise;
        }

        private void performAction(eChoise i_Choise)
        {
            switch (i_Choise)
            {
                case eChoise.InsertCar:
                    insertNewCar();
                    break;
                case eChoise.DisplayRegisteredLN:
                    displayRegisteredLN();
                    break;
                case eChoise.ChangeStat:
                    changeVehicleStat();
                    break;
                case eChoise.FillAir:
                    FillAir();
                    break;
                case eChoise.FuelTank:
                    FuelTank();
                    break;
                case eChoise.Charge:
                    charge();
                    break;
                case eChoise.DisplayCarDetails:
                    displayCarDetailes();
                    break;
                default:
                    break;
            }
        }

        private void changeVehicleStat()
        {
            Console.WriteLine("Please enter plate number:");
            string plate = Console.ReadLine();
            if (!m_GarageMgr.CheckVehicleExistence(plate))
            {
                /// no such car
                Console.WriteLine("No such car!");
            }
            else
            {
                Console.WriteLine("what is the new status?");
                string[] availableStatuses = m_GarageMgr.GetAvailableStatuses();
                printNumeredArray(availableStatuses);
                string newStat = Console.ReadLine();
                try
                {
                    m_GarageMgr.ChangeStat(plate, newStat);
                }
                catch (ValueOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                } 
            }
        }

        private void displayRegisteredLN()
        {
            string[] availableStatuses = m_GarageMgr.GetAvailableStatuses();
            Console.WriteLine("Please enter the status number that you want to see: ");
            printNumeredArray(availableStatuses);
            string status = Console.ReadLine();

            while (true)
            {
                try
                {
                    LinkedList<string> plates = m_GarageMgr.GetVehcilesPlatesByStat(availableStatuses[int.Parse(status)]);
                    displayStrList(plates);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
            }
        }

        private void displayStrList(LinkedList<string> i_StrList)
        {
            foreach (string str in i_StrList)
            {
                Console.WriteLine(str);
            }
        }

        private void displayStrArr(string[] status)
        {
            int i = 1;
            foreach (string Plate in status)
            {
                Console.WriteLine("{0}: {1}.", i++, Plate);
            }
        }

        private void displayCarDetailes()
        {
            Console.WriteLine("Please enter car plate: ");
            string plate = Console.ReadLine(); //TODO validate input
            GarageVehicleRecord record = m_GarageMgr.GetVehicleRecordByPlate(plate);
            displayVehicleDetailes(record);
        }

        private void insertNewCar()
        {
            Console.Clear();
            Console.WriteLine(@"Hello, let's add a new car!");
            Console.WriteLine("Please insert your plate number: ");
            string plate = Console.ReadLine();

            if (m_GarageMgr.CheckVehicleExistence(plate))
            {
                Console.WriteLine("Your vehicle is already registered.");
                m_GarageMgr.ChangeStat(plate, "Repairing"); 
            }
            else
            {
                Console.WriteLine("Please enter your name: ");
                string vehicleOwnerName = Console.ReadLine();
                Console.WriteLine("Please enter your phone number: ");
                string OwnerPhoneNumber = Console.ReadLine();
                string[] typesNames = m_GarageMgr.GetSupportedVehicleTypesNames();
                printNumeredArray(typesNames); 
                Console.WriteLine("Please Choose the vehicle type: ");
                int choise = getChoise(typesNames.Length);
                GarageVehicleRecord record = m_GarageMgr.addNewVehicleToGarage(vehicleOwnerName, OwnerPhoneNumber, plate, typesNames[choise - 1]);
                /// new car
                Dictionary<string, string> dic = getSpecificDemands(record.Vehicle);
                m_GarageMgr.FillDetailes(plate, dic);
            }
        }

        private Dictionary<string, string> getSpecificDemands(Vehicle i_Vehicle)
        {
            Dictionary<string, string> o_DemandsDic = i_Vehicle.CloneDemandsDic();
            while (true)
            {
                foreach (var key in o_DemandsDic.Keys)
                {
                    Console.Write("{0}: ", key);
                    o_DemandsDic[key] = Console.ReadLine();
                    if (o_DemandsDic[key] == k_ExitSign)
                    {
                        throw new Exception("Exit");
                    }
                }

                if (!m_GarageMgr.CheckDicValidation(i_Vehicle, o_DemandsDic))
                {
                    Console.WriteLine("It's appear that some of the detailes weren't good, please type again.");
                    continue;
                }
                else
                {
                    return o_DemandsDic;
                }
            }
        }

        private void printNumeredArray(string[] i_TypesNames)
        {
            int i = 1;
            foreach (string Type in i_TypesNames)
             {
                 Console.WriteLine("{0}: {1}.", i++, Type);
             }
        }

        private void displayVehicleDetailes(GarageVehicleRecord i_Record)
        {
            foreach (var detailPair in i_Record.Vehicle.Details)
            {
                Console.WriteLine("{0}: {1}", detailPair.Key, detailPair.Value);
            }
        }
  
        private void FillAir()
        {
            Console.Clear();
            Console.WriteLine("Please enter car plate: ");
            string plate = Console.ReadLine();
            if (!m_GarageMgr.CheckVehicleExistence(plate))
            {
                /// no such car
                Console.WriteLine("No such car!");
            }
            else
            {
                bool isFillToMax = m_GarageMgr.FillInAirPresureToMax(plate);
                if (isFillToMax == true)
                {
                    Console.WriteLine("Air Presure was filled to Max for car with plate number {0} .", plate);

                }
                else
                {
                    Console.WriteLine("Cant fill int to MAX .");
                }
            }
        }
        private void FuelTank()
        {
            Console.Clear();
            Console.WriteLine("Please enter car plate: ");
            string plate = Console.ReadLine(); //TODO validate input
            if (!m_GarageMgr.CheckVehicleExistence(plate))
            {
                /// no such car
                Console.WriteLine("No such car!");
            }
            else
            {
                string[] fuelTypes = m_GarageMgr.GetSupportedVehicleFuelTypes();
                printNumeredArray(fuelTypes); 
                Console.WriteLine("Choose Fuel you want to fiil in .");
                string fuelType = Console.ReadLine();
                Console.WriteLine("Please insert the amount of fuel to fill in .");
                float amount;
                while(true)
                {
                  try
                  {
                     amount = Single.Parse(Console.ReadLine());
                  }
                  catch (FormatException)
                  {
                     Console.WriteLine("Inserted value is not in a valid format.");
                  }
                }
                bool isFilledToMax = m_GarageMgr.FillInFuel(plate, fuelType, amount);
                if (isFilledToMax == true)
                {
                    Console.WriteLine("Vehicle with plate number {0} was enfuled with {1} liters of {2}.", plate, amount, fuelType);

                }
                else
                {
                    Console.WriteLine("Could not enduel the vehicle, please try different amount.");
                }
            }
        }

        private void charge()
        {
            {
                Console.Clear();
                Console.WriteLine("Please enter car plate: ");
                string plate = Console.ReadLine(); //TODO validate input
                if (!m_GarageMgr.CheckVehicleExistence(plate))
                {
                    /// no such car
                    Console.WriteLine("No such car!");
                }
                else
                {
                    Console.WriteLine("Please insert number of minutes you want to add to vehicle battery .");
                    float minutes;
                    while (true)
                    {
                        try
                        {
                            minutes = Single.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Inserted value is not in a valid format.");
                        }
                    }
                    bool isCharged = m_GarageMgr.ChargeElectricVehicle(plate, minutes);
                    if (isCharged == true)
                    {
                        Console.WriteLine("Vehicle with plate number {0} was charged with  {1} minutes", plate, minutes);

                    }
                    else
                    {
                        Console.WriteLine("Could not charge the vehicle, please try different value.");
                    }
                }
            }
        }

    
//        private List<Vehicle> getAndPrintVehiclesList()
//        {
//            int i = 1;

//            Console.Clear();
//            Console.WriteLine(
//@"Hello, let's add a new car!
//
//Please Choose the vehicle type: 
//");
//            List<Vehicle> vehicels = m_GarageMgr.GetVehicleList();
//            foreach (Vehicle vehicle in vehicels)
//            {
//                Console.WriteLine("{0}: {1}.", i++, vehicle.TypeName);
//            }

//            return vehicels;
//        }

///       public object VehicleOwnerName { get; set; }
    }
}