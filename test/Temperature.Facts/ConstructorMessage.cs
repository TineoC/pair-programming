using NUnit.Framework;
using System;
using Temp.Core;
namespace Temp.Facts;

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

    Test Cases:
    
    - Fai

*/



public class ConstructorMessage
{
    [TestCase(-1)]
    [TestCase(3)]
    public void With_Invalid_Scale_Throws_ArgumentOutOfRangeException(Scale invalidScale)
        => Assert.That(() => new Temperature(32, invalidScale), Throws.InstanceOf<ArgumentOutOfRangeException>());

    [Test]
    public void With_Valid_Scale_Throws_Nothing([Values] Scale invalidScale)
        => Assert.That(() => new Temperature(32, invalidScale), Throws.Nothing);
}
