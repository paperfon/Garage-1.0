namespace Garage_1._0
{
    interface IVehicle
    {
        string RegNumber { get; }
        string Fabricant { get; }
        int NumberOfWheels { get; }
        string Color { get; }
        int ProductionYear { get; }
    }
}