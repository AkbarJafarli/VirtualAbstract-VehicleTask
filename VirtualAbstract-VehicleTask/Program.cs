using VirtualAbstract_VehicleTask;

Vehicle[] vehicles = new Vehicle[]
{
    new Car("Range Rover","Vogue",360,"Black",2023),
    new Bus(20,"White",2014)
};
foreach (var vehicle in vehicles)
{
    vehicle.ShowInfo();
}
