namespace VirtualAbstract_VehicleTask
{
    class Bus:Vehicle
    {
        public int PassangerCount { get;}

        public Bus(int passangercount,string color,int year): base(year)
        {
            PassangerCount = passangercount;
            Color = color;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Bus: Passangercount: {PassangerCount} - Year: {Year} - Color: {Color}");
        }

    }




}
