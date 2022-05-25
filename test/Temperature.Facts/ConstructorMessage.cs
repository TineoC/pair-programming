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

        - Fail Cases:

        2. Input: Temperature(0.322, 3) Output: Throw Exception("Invalid Scale")

        - Pass Cases:

        1. Input: Temperature(10, 0) Output: "responds with Temperature class created".

        2. Input: Temperature(50, 1) Output: "responds with Temperature class created"

        3. Input: Temperature(-3, 2) Output: "responds with Temperature class created"
*/



public class ConstructorMessage
{
    [TestCase(-1)]
    [TestCase(3)]
    public void With_Scale_Minus_One_Throws_ArgumentOutOfRangeException()
    {
        Assert.That(() => new Temperature(32, (Scale)(-1)), Throws.InstanceOf<ArgumentOutOfRangeException>());

        Assert.That(() => new Temperature(0.322F, (Scale)(3)), Throws.InstanceOf<ArgumentOutOfRangeException>());
    }

}
