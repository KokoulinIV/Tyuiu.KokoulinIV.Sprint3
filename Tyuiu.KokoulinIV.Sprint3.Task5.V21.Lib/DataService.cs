using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KokoulinIV.Sprint3.Task5.V21.Lib
{
    public class DataService : ISprint3Task5V21
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double z = 0;
            for (int y = startValue1; y <=stopValue1;y++)
            {
                for (int c = startValue2;  c <= stopValue2; c++)
                {
                    z = z + (x * x * x * Math.Cos(c)) + 2;
                }
            }
            return Math.Round(z,3);
        }
    }
}
