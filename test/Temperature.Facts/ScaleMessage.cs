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

    - Pass Cases:

    1. Input: Celsius returns Celsius
    2. Input: Fahrenheit returns Fahrenheit
    3. Input: Kelvin returns Kelvin
*/

public class ScaleMessage
{
    [Test]
    public void Returns_Same_As_Constructor_Provided_Value([Values] Scale validScale) {
        Temperature temp = new(1.5F, validScale);

        Assert.That(temp.Scale, Is.EqualTo(validScale));
    }
}
