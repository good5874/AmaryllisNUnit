using ApiWeatherTests.Enum;
using System;

namespace ApiWeatherTests.Extension
{
    public static class DateTimeExtension
    {
        public static SeasonsEnum GetSeason(this DateTime dateTime)
        {
            return dateTime.Month switch
            {
                1 => SeasonsEnum.Winter,
                2 => SeasonsEnum.Winter,
                3 => SeasonsEnum.Spring,
                4 => SeasonsEnum.Spring,
                5 => SeasonsEnum.Spring,
                6 => SeasonsEnum.Summer,
                7 => SeasonsEnum.Summer,
                8 => SeasonsEnum.Summer,
                9 => SeasonsEnum.Autumn,
                10 => SeasonsEnum.Autumn,
                11 => SeasonsEnum.Autumn,
                12 => SeasonsEnum.Winter,
                _ => throw new Exception("err season")
            };
        }

        public static string GetDateYearsAgo(this DateTime dateTime, int years)
        {
            var date5YearsAgo = dateTime.AddYears(-years);
            return date5YearsAgo.ToString("yyyy.MM.dd").Replace('.', '/');
        }
    }
}
