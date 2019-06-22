using System.Collections.Generic;
using System;

namespace generics {
    class Station {

        public int Capacity {get {
            return this._capacity;
        }}
        protected int _capacity{get; set;}

        public void Refuel<X>(List<X> List) where X: IVehicle{
            List.ForEach(vehicle => {
                Console.WriteLine($"{vehicle.Name} has been refueled {vehicle.FuelCapacity - vehicle.Fuel} {vehicle.FuelMeasure}.");
                vehicle.Fuel = vehicle.FuelCapacity;
            });
        }

    }
}