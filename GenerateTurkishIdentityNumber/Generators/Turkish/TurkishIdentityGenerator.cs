using System.Text;

namespace GenerateTurkishIdentityNumber.Generators.Turkish;

public static class TurkishIdentityGenerator
{
    public static string Generate()
    {
        decimal[] r = new decimal[11];
        r[0] = randomDigit(1, 9);
        for (int i = 1; i < 9; i++)
        {
            r[i] = randomDigit(0, 9);
        }
        r[9] = ((r[0] + r[2] + r[4] + r[6] + r[8]) * 7 - (r[1] + r[3] + r[5] + r[7])) % 10;
        r[10] = (r[0] + r[1] + r[2] + r[3] + r[4] + r[5] + r[6] + r[7] + r[8] + r[9]) % 10;

        StringBuilder sb = new();
        for (int i = 0; i < r.Length; i++)
        {
            sb.Append(r[i].ToString());
        }

        return sb.ToString();
    }

    private static decimal randomDigit(decimal t, decimal r)
    {
        double rndm = new Random().NextDouble();
        return Math.Floor((decimal)rndm * (r - t + 1)) + t;
    }
}
