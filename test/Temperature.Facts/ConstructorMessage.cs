using System;
using NUnit.Framework;
using Temp.Core;
namespace Temp.Facts;

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
