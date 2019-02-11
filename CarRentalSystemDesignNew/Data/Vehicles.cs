using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystemDesignNew
{
    // Created abstract class to define common features
    public abstract class Vehicles
    {
        private int VehicleId { get; set; }
        public string VehicleName { get; set; }
        protected int SeatingCapacity = 4;
        protected int SetTotalCount { get; set; }
        protected double BaseRate = 50;
        protected bool IsAvailable{ get; set; }
       
        private static int count = 10000;
        protected static int TotalVehicleCount = 0;

        //Constructor with 1 parameter
        public Vehicles(string VehicleName)
        {
            this.VehicleId = GenerateVehicleID();
            this.VehicleName = VehicleName;
            this.IsAvailable = true;
        }

   
        private static int GenerateVehicleID()
        {
            return count++;
        }

        // Returns Vehicle ID
        public int GetVehicleID()
        {
            return this.VehicleId;
        }

        public virtual double CalculateRates()
        {
            return this.BaseRate;
        }

        public virtual int GetSeatingCapacity()
        {
            return this.SeatingCapacity;
        }

        public void SetIsAvailable(bool IsAvailable)
        {
            this.IsAvailable = IsAvailable;
        }
        public bool GetIsAvailable()
        {
            return this.IsAvailable;
        }

        public virtual int GetVehicleCount()
        {
            return 0;
        }
        public int GetTotalVehicleCount()
        {
            return TotalVehicleCount;
        }
        public void SetTotalVehicleCount(int counter )
        {
            this.SetTotalCount = counter;
        }
        
    }

    #region Declaring Interfaces
    public interface IRadio
    {   
          Boolean HasRadio{ get; set; }
    }

    public interface IBluetooth
    {
          Boolean HasBluetooth { get; set; }
    }

    public interface IGPS
    {
          Boolean HasGPS { get; set; }

    }
    #endregion


    // Child Class inheriting from parent class Vehicles, implementing IRadio and IBluetooth interfaces
    public class MidSizeSUV : Vehicles, IRadio, IBluetooth
    {
        private static int MidSizeSUVCount { get; set; }
        public Boolean HasRadio { get; set; }
        public Boolean HasBluetooth { get; set; }

        // Constructor of child class which also inherits parent's class constructor
        public MidSizeSUV(string VehicleName)
            : base(VehicleName) 
        {
            // Since we are implementing interfaces, we need to set these methods values
            this.HasRadio = true;
            this.HasBluetooth = true;
            if (this.GetType().Name.Equals("MidSizeSUV")) 
            {
                IncreaseVehicleCout();
            }
            
        }
      

        private static void IncreaseVehicleCout()
        {
            MidSizeSUVCount++;
            TotalVehicleCount++;
        }

        //Overriding parent's class functions - this will have Midsize SUV rates
        public override double CalculateRates()
        {
            return this.BaseRate + 20; 
        }
        // Overriding parent's class functions - this will have Midsize SUV seating capacity
        public override int GetSeatingCapacity()
        {
            return this.SeatingCapacity + 2;
        }

        public override int GetVehicleCount()
        {
            return MidSizeSUVCount;
        }

    }

    // Child class SUV inherits from parent class MidSizeSUV
    public class SUV : MidSizeSUV, IGPS
    {
        private static int MidSizeSUVCount { get; set; }
       
        public Boolean HasGPS { get; set; }
        public SUV(string VehicleName)
            : base(VehicleName)
        {
            this.HasRadio = true;
            this.HasBluetooth = true;
            this.HasGPS = true;
            IncreaseVehicleCout();
        }

        private static void IncreaseVehicleCout()
        {
            MidSizeSUVCount++;
            TotalVehicleCount++;
            
        }
       
        public override double CalculateRates()
        {
            return this.BaseRate + 30;
        }
        public override int GetSeatingCapacity()
        {
            return this.SeatingCapacity + 2;
        }
        public override int GetVehicleCount()
        {
            return MidSizeSUVCount;
        }

    }

    public class Economy:Vehicles, IRadio
    {
        private static int EconomyCount { get; set; }
        public Boolean HasRadio { get; set; }
        public Economy(string VehicleName)
            : base(VehicleName) 
        {
            this.HasRadio = true;
            IncreaseVehicleCout();
        }     
        private static void IncreaseVehicleCout()
        {
            EconomyCount++;
            TotalVehicleCount++;
        }
        public override double CalculateRates()
        {
            return this.BaseRate + 10;
        }
        public override int GetVehicleCount()
        {
            return EconomyCount;
        }
    }


}
