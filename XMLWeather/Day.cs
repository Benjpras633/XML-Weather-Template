using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime,updateTime, condition, location, tempHigh, tempLow,
            windSpeed, windDirection, humidity, sunrise, sunset, icon, timeZone;

        public Day()
        {
            date = currentTemp = currentTime = updateTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = humidity = sunrise = sunset = icon = timeZone = "";
        }
    }
}
