namespace generics {
    class GasVehicle : Vehicle, IGasPowered {
        public GasVehicle(string Name, int Capacity, int FuelRate) {
            _name = Name;
            _sound = "Vroom!";
            _fuelCapacity = Capacity;
            _fuelMeasure = "gallons";
            _fuelRate = FuelRate;
        }
        public void BurnFuel(){
            Drive(this);
            Sound();
        }

    }
}