using FluentAssertions;
using GpsNavigation;

namespace GpsNavigationTests;

public class WaypointTests
{
    [Fact]
    public void Waypoint_can_be_created()
    {
        var waypoint = new Waypoint("Home", 51.507222, -0.1275);

        waypoint.Name.Should().Be("Home");
        waypoint.GetCoordinates().Should().Be((51.507222, -0.1275));
    }

    [Fact]
    public void Waypoint_coordinates_can_be_accessed_as_tuple()
    {
        var waypoint = new Waypoint("Home", 51.507222, -0.1275);
        var coordinates = waypoint.Coordinates;

        coordinates.Latitude.Should().Be(51.507222);
        coordinates.Longitude.Should().Be(-0.1275);
    }

    [Fact]
    public void Waypoint_can_be_deconstructed()
    {
        var waypoint = new Waypoint("Home", 51.507222, -0.1275);
        var (latitude, longitude) = waypoint;

        latitude.Should().Be(51.507222);
        longitude.Should().Be(-0.1275);
    }
}
