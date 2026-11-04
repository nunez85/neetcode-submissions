public interface IVehicle {
    string getType();
}

public class Car : IVehicle {
    public string getType() {
        return "Car";
    }
}

public class Truck : IVehicle {
    public string getType() {
        return "Truck";
    }
}

public class Bike : IVehicle {
    public string getType() {
        return "Bike";
    }
}

public abstract class VehicleFactory {
    public abstract IVehicle createVehicle();
}

public class CarFactory : VehicleFactory {
    public override IVehicle createVehicle() {
        return new Car();
    }
}

public class TruckFactory : VehicleFactory {
    public override IVehicle createVehicle() {
        return new Truck();
    }
}

public class BikeFactory : VehicleFactory {
    public override IVehicle createVehicle() {
        return new Bike();
    }
}
