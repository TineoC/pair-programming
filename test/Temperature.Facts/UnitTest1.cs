using NUnit.Framework;

namespace Temperature.Facts;

/*
    Temperature(5.48, TemperatureScale.Kelvin)
        Add(other : Temperature) : Temperature //Same scale as subject
        Substract(other : Temperature) : Temperature //Same scale as subject
        MultiplyBy(other : Temperature) : Temperature //Same scale as subject
        DivideBy(other : Temperature) : Temperature //Same scale as subject
        Scale : TemperatureScale
        ToFahrenheit() : Temperature
        ToCelsius() : ...
        ToKelvin() : ...
        ToString() : String // "5.4800F" 5.48C -5.48K
*/

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
