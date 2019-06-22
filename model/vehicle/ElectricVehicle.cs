namespace generics {
    class ElectricVehicle : Vehicle, IElectricPowered {
        public ElectricVehicle(string Name, int Capacity, int FuelRate) {
            _name = Name;
            _sound = "Whrrrrr...";
            _fuelCapacity = Capacity;
            _fuelMeasure = "kilowatts";
            _fuelRate = FuelRate;
        }
        public void UseElectricity(){
            Drive(this);
            Sound();
        }
    }
}