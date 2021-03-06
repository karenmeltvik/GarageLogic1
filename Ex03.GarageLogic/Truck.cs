﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_IsCooled;
        private float m_CargoVolume;
        public float CargoVolume { get; set; }

        public Truck(string i_ModelName, string i_LicenseNumber, string i_OwnerName,
                     string i_OwnerPhoneNumber, List<Wheel> i_wheels, bool i_IsCooled, float i_CargoVolume, EnergySystem i_energySystem)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber, i_wheels, i_energySystem)
        {
            m_IsCooled = i_IsCooled;
            m_CargoVolume = i_CargoVolume;
            EnergySystem = new FuelBase(EnergySystem.MaxAmountOfEnergy, eFuelType.Solar); // set somehow
        }

        public override string ToString()
        {
            StringBuilder infoOfTruck = new StringBuilder();
            infoOfTruck.AppendLine("Type of vehicle : Truck");
            infoOfTruck.AppendLine("Truck i cooled? : " + m_IsCooled);
            infoOfTruck.AppendLine("The volume of the cargo is: " + m_CargoVolume);
            return infoOfTruck.ToString();
        }
    }
}
