﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KokoulinIV.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            for (int i=startValue; i<=stopValue; i++)
            {
                
                p = p*(1 / Math.Pow((Math.Cos(5) + 1), 2));

            }
            return Math.Round(p,3);
        }
    }
}
