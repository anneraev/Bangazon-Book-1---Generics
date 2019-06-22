using System;

namespace generics {
    class Vehicle : IVehicle {
        protected string _name;
        public string Name{get{return _name;}}
        protected string _sound;
        protected string _fuelMeasure;
        protected int _fuelCapacity;
        protected int _fuelRate;
        public string FuelMeasure{get{
            return _fuelMeasure;
        }}
        public int Fuel{get; set;}
        public int FuelCapacity {get{return _fuelCapacity;}}
        public int FuelRate{get{return _fuelRate;}}
        public void Drive<T>(T Vehicle) where T: IVehicle{
            Vehicle.Fuel -= Vehicle.FuelRate;
        }
        public string Sound(){
            return _sound;
        }
        public void RequestEntry<T>(IStation<T> Station, IVehicle Vehicle) {
            if (Station.IsSpaceOpen()){
                Station.Enter(Vehicle);
            } else {
                Console.WriteLine("This station is full. Find another one.");
            }
        }
    }
}