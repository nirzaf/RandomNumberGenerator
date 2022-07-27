using System.Text;
using static System.Convert;
using static System.DateTime;
using static System.Math;

namespace RandomNumberGenerator;

public static class RandomRequestNumber
{
    public static string Generate()
    {
        StringBuilder builder = new();
        Random random = new();
        for (int i = 0; i < 4; i++)
        {
            var ch = ToChar(ToInt32(Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }

        var num = random.Next(100, 1000);

        if (num % 2 == 0)
        {
            builder.Insert(0, num);
        }
        else
        {
            builder.Append(num);
        }

        num = Now.Millisecond;

        if (num % 2 == 0)
        {
            builder.Insert(0, Now.Second);
        }
        else
        {
            builder.Append(Now.Second);
        }

        return builder.ToString();
    }
}