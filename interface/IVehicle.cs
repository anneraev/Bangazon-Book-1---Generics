using System.Collections.Generic;

namespace generics {
    interface IVehicle {
        string Name{get;}
        string FuelMeasure{get;}
        int Fuel{get; set;}
        int FuelCapacity {get;}
        int FuelRate{get;}
        void Drive<T>(T FuelType) where T: IVehicle;
    }
}