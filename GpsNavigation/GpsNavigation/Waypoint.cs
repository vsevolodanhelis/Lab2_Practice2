namespace GpsNavigation;

public class Waypoint
{
    private readonly double _latitude;
    private readonly double _longitude;

    public string Name { get; }

    public Waypoint(string name, double latitude, double longitude)
    {
        Name = name;
        _latitude = latitude;
        _longitude = longitude;
    }

    public (double, double) GetCoordinates()
    {
        return (_latitude, _longitude);
    }

    public (double Latitude, double Longitude) Coordinates => (_latitude, _longitude);

    public void Deconstruct(out double latitude, out double longitude)
    {
        latitude = _latitude;
        longitude = _longitude;
    }
}