using Triplex.Validations;

namespace Temp.Core;

/// <summary> askfj;lkafj ;lakdsj;ls </summary>
public class Temperature
{
    /// <summary>
    /// asfl;ksajf;ls af
    /// </summary>
    /// <param name="measure"></param>
    /// <param name="scale"></param>
    public Temperature(float measure, Scale scale)
    {
        Scale = Arguments.ValidEnumerationMember(scale, nameof(scale));
    }

    public Scale? Scale { get; }
}
