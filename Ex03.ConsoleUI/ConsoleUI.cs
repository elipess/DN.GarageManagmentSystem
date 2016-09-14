using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
using System.Reflection;

namespace Ex03.ConsoleUI
{
    class ConsoleUI
    {
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
            string[] actions = new string[]
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

        private static int getChoise(int maxValue)
        {
            int choise;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choise))
                {
                    if (choise > 1 && choise < maxValue)
                    {
                        break;
                    }
                }
            }

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

        private void insertNewCar()
        {
            int i = 0;
            List<Vehicle> vehicels = getAndPrintVehiclesList();
            int choise = getChoise(vehicels.Count);
            Vehicle vehicle = vehicels[choise];
            MemberInfo[] membersInfo = vehicle.GetType().GetMembers();
            string[] data = new string[membersInfo.Length];
            foreach (MemberInfo member in membersInfo)
            {
                if (member.GetType() == typeof(MandatoriesHolder<object>))
                {
                    Console.WriteLine("{0}: ", member.ToString());
                    data[i++] = Console.ReadLine();//improve!
                }
            }

            m_GarageMgr.AddNewVehicle(vehicle, data);
        }

        private List<Vehicle> getAndPrintVehiclesList()
        {
            int i = 0;

            Console.Clear();
            Console.WriteLine(
@"Hello, let's add a new car!

Please Choose the vehicle type: 
");
            List<Vehicle> vehicels = m_GarageMgr.GetVehicleList();
            foreach (Vehicle vehicle in vehicels)
            {
                Console.WriteLine("{0}: {1}.", i++, vehicle.TypeName);
            }

            return vehicels;
        }
    }
}
