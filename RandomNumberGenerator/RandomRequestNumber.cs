using System.Text;

namespace RandomNumberGenerator;

public static class RandomRequestNumber
{
    public static string Generate()
    {
        StringBuilder builder = new();
        Random random = new();
        for (int i = 0; i < 4; i++)
        {
            var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
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

        num = DateTime.Now.Millisecond;

        if (num % 2 == 0)
        {
            builder.Insert(0, DateTime.Now.Second);
        }
        else
        {
            builder.Append(DateTime.Now.Second);
        }

        return builder.ToString();
    }
}