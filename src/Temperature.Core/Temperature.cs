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
        if (!Enum.IsDefined(typeof(Scale), scale))
        {
            throw new ArgumentOutOfRangeException(nameof(scale), scale, "Invalid scale.");
        }

        Scale = scale;
    }

    public Scale Scale { get; }
}
