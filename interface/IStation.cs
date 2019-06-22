using System.Collections.Generic;

namespace generics {
    interface IStation<T> {
        List<T> List{get;}
        bool IsSpaceOpen();
        void Refuel<X>(List<X> List) where X: IVehicle;

        void Enter(IVehicle Vehicle);
    }
}