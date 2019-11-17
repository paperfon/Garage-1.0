namespace Garage_1._0
{
    interface IVehicle
    {
        string RegNumber { get; }
        string Fabricant { get; }
        uint NumberOfWheels { get; }
        string Color { get; }
        uint ProductionYear { get; }
    }
}