﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KokoulinIV.Sprint3.Task7.V12.Lib
{
    public class DataService : ISprint3Task7V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (int)(stopValue - startValue)+1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for(int x = startValue; x <= stopValue; x++) 
            {

                if (3 * x + 0.5 == 0)
                {
                    continue;
                }
                else
                {
                    y =Math.Round(( Math.Sin(x) + 2 / (3 * x + 0.5) - 2 * Math.Cos(x) * 2 * x),2);
                    valueArray[count] = y;
                    count++;
                }

            }
            return valueArray;
        }
    }
}