using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KokoulinIV.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double z = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    z = z + x / (Math.Cos(x) - Math.Sin(x));
                }
            }
            return Math.Round(z, 3);
        }
    }
}
