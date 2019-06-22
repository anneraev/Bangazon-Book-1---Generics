using System;
using System.Collections.Generic;

namespace generics
{
    class BatteryStation : Station, IStation<IElectricPowered>
    {
        public BatteryStation(){
            this._capacity = 4;
        }
        public List<IElectricPowered> List {get;}
        public bool IsSpaceOpen(){
            return _capacity > List.Count;
        }
        public void Refuel(){
            Refuel(List);
        }
        public void Enter(IVehicle Vehicle){
            if (Vehicle is IElectricPowered) {
            List.Add((IElectricPowered)Vehicle);
            } else {
                Console.WriteLine("This station only serves electric vehicles. Please find a gas station.");
            }
        }
    }
}