﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day d = new Day();
                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");
                reader.ReadToFollowing("symbol");
                d.icon = reader.GetAttribute("var");
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                //TODO: if day object not null add to the days list
                days.Add(d);
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("timezone");
            days[0].timeZone = reader.ReadString();

            //determine sunrise and sunset times
            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise");
            days[0].sunset = reader.GetAttribute("set");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");             

            //determine weather condition
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");

            //find appropriate icon
            days[0].icon = reader.GetAttribute("icon");

        }
    }
}
