namespace VirtualAbstract_VehicleTask
{
    class Car : Vehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public int MaxSpeed { get; }

        public Car(string brand,string model,int maxspeed,string color,int year): base (year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxspeed;
            Color = color;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model} - Year: {Year} - Color: {Color} - Maxspeed: { MaxSpeed}");
        }


    }
}
