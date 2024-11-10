﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OvsepyanAA.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7

    {
        public string FindMonthName(int startYear, int n)
        {
            string res;
            switch (n % 12 + 1)
            {
                case 1:
                    res = "январь";
                    break;
                case 2:
                    res = "февраль";
                    break;
                case 3:
                    res = "март";
                    break;
                case 4:
                    res = "апрель";
                    break;
                case 5:
                    res = "май";
                    break;
                case 6:
                    res = "июнь";
                    break;
                case 7:
                    res = "июль";
                    break;
                case 8:
                    res = "август";
                    break;
                case 9:
                    res = "сентябрь";
                    break;
                case 10:
                    res = "октябрь";
                    break;
                case 11:
                    res = "ноябрь";
                    break;
                case 12:
                    res = "декабрь";
                    break;
                default:
                    throw new ArgumentException($"Проверьте число месяцев ({n})");
            }
            return res;
        }

        string ISprint2Task5V7.FindMonthName(int startYear, int n)
        {
            throw new NotImplementedException();
        }
    }
}