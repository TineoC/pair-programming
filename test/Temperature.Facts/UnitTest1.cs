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

        Test Cases:

        - Fail Cases:

        1. Input: Temperature(32, -1) Output: Throw ArgumentOutOfRangeException()

        2. Input: Temperature(0.322, 3) Output: Throw Exception("Invalid Scale")

        - Pass Cases:

        1. Input: Temperature(10, 0) Output: "responds with Temperature class created".

        2. Input: Temperature(50, 1) Output: "responds with Temperature class created"

        3. Input: Temperature(-3, 2) Output: "responds with Temperature class created"
*/



public class Tests
{
    [Test]
    // With Scale -1 Throws Argument
    public void WithScaleMinusOneThrowsArgumentOutOfRangeException()
    {
        // With scale -1 throws Argum
        // Assert.Pass(Temperature(32, -1));
    }
}
