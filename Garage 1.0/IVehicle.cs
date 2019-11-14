namespace Garage_1._0
{
    interface IVehicle
    {
        string Color { get; }
        string Fabricant { get; }
        int NumberOfWheels { get; }
        int ProductionYear { get; }
        string RegNumber { get; }
    }
}