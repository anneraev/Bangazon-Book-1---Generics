using System;
using System.Collections.Generic;

namespace generics
{
    class GasStation : Station, IStation<IGasPowered>
    {
        public List<IGasPowered> List {get;}
        public bool IsSpaceOpen(){
            return _capacity > List.Count;
        }
        public void Refuel(){
            Refuel(List);
        }
        public void Enter(IVehicle Vehicle){
            if (Vehicle is IGasPowered) {
            List.Add((IGasPowered)Vehicle);
            } else {
                Console.WriteLine("This station only serves gas-powered vehicles. Please find a battery station.");
            }
        }

    }
}