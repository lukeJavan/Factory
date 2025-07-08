using Factory.ConcreteImp.Sea;
using Factory.ConcreteImp.Road;
using Factory.Abstractions.Factory;

namespace tests;

public class CreateFromFactory
{
    [Fact]
    public void CreateSeaLogistics_ReturnsValidBoatObject()
    {
        // Arrange
        var factory = new SeaLogistics();

        // Act
        var seaLogistics = factory.CreateTransport();

        // Assert
        Assert.NotNull(seaLogistics);
        Assert.IsType<Boat>(seaLogistics);
    }

    [Fact]
    public void CreateSeaLogistics_DeliverMethodExecutes()
    {
        // Arrange
        var factory = new SeaLogistics();
        var seaLogistics = factory.CreateTransport();

        // Act
        seaLogistics.Deliver();

        // Assert
        // Here we can check if the Deliver method executed without exceptions.
        // Since Deliver does not return a value, we cannot assert on its output.
        Assert.True(true); // Placeholder assertion to indicate the method executed.
    }

    [Fact]
    public void CreateRoadLogistics_ReturnsValidTruckObject()
    {
        // Arrange
        var factory = new RoadLogistics();

        // Act
        var roadLogistics = factory.CreateTransport();

        // Assert
        Assert.NotNull(roadLogistics);
        Assert.IsType<Truck>(roadLogistics);
    }

    [Fact]
    public void CreateRoadLogistics_DeliverMethodExecutes()
    {
        // Arrange
        var factory = new RoadLogistics();
        var roadLogistics = factory.CreateTransport();

        // Act
        roadLogistics.Deliver();

        // Assert
        // Here we can check if the Deliver method executed without exceptions.
        // Since Deliver does not return a value, we cannot assert on its output.
        Assert.True(true); // Placeholder assertion to indicate the method executed.
    }
}