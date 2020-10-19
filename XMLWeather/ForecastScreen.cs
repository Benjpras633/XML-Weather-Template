using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            cityOutput.Text = Form1.days[0].location;

            day2Label.Text = DateTime.Now.AddDays(1).ToString("dddd");
            day3Label.Text = DateTime.Now.AddDays(2).ToString("dddd");
            day4Label.Text = DateTime.Now.AddDays(3).ToString("dddd");
            day5Label.Text = DateTime.Now.AddDays(4).ToString("dddd");
            day6Label.Text = DateTime.Now.AddDays(5).ToString("dddd");
            day7Label.Text = DateTime.Now.AddDays(6).ToString("dddd");

            

            //max temps for each day
            maxOutput1.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0) + "°";
            maxOutput2.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh), 0) + "°";
            maxOutput3.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh), 0) + "°";
            maxOutput4.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh), 0) + "°";
            maxOutput5.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh), 0) + "°";
            maxOutput6.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh), 0) + "°";
            maxOutput7.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh), 0) + "°";

            //min temps for each day
            minOutput1.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0) + "°";
            minOutput2.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow), 0) + "°";
            minOutput3.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow), 0) + "°";
            minOutput4.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow), 0) + "°";
            minOutput5.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow), 0) + "°";
            minOutput6.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow), 0) + "°";
            minOutput7.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow), 0) + "°";
            //if clear sky
            if (Form1.days[0].icon == "01d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[0].icon == "01n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[0].icon == "02d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[0].icon == "02n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[0].icon == "03d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[0].icon == "03n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[0].icon == "04d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[0].icon == "09d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[0].icon == "09n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[0].icon == "10d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[0].icon == "10n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[0].icon == "11d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[0].icon == "11n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[0].icon == "13d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[0].icon == "13n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[0].icon == "50d")
            {
                pictureBox1.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[0].icon == "50n")
            {
                pictureBox1.BackgroundImage = Properties.Resources._50n;
            } 
            
            //if clear skye
            if (Form1.days[1].icon == "01d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[1].icon == "01n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[1].icon == "02d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[1].icon == "02n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[1].icon == "03d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[1].icon == "03n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[1].icon == "04d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[1].icon == "09d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[1].icon == "09n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[1].icon == "10d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[1].icon == "10n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[1].icon == "11d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[1].icon == "11n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[1].icon == "13d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[1].icon == "13n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[1].icon == "50d")
            {
                pictureBox2.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[1].icon == "50n")
            {
                pictureBox2.BackgroundImage = Properties.Resources._50n;
            }

            if (Form1.days[2].icon == "01d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[2].icon == "01n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[2].icon == "02d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[2].icon == "02n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[2].icon == "03d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[2].icon == "03n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[2].icon == "04d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[2].icon == "09d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[2].icon == "09n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[2].icon == "10d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[2].icon == "10n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[2].icon == "11d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[2].icon == "11n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[2].icon == "13d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[2].icon == "13n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[2].icon == "50d")
            {
                pictureBox3.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[2].icon == "50n")
            {
                pictureBox3.BackgroundImage = Properties.Resources._50n;
            }

            if (Form1.days[3].icon == "01d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[3].icon == "01n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[3].icon == "02d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[3].icon == "02n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[3].icon == "03d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[3].icon == "03n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[3].icon == "04d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[3].icon == "09d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[3].icon == "09n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[3].icon == "10d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[3].icon == "10n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[3].icon == "11d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[3].icon == "11n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[3].icon == "13d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[3].icon == "13n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[3].icon == "50d")
            {
                pictureBox4.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[3].icon == "50n")
            {
                pictureBox4.BackgroundImage = Properties.Resources._50n;
            }

            if (Form1.days[4].icon == "01d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[4].icon == "01n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[4].icon == "02d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[4].icon == "02n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[4].icon == "03d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[4].icon == "03n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[4].icon == "04d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[4].icon == "09d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[4].icon == "09n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[4].icon == "10d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[4].icon == "10n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[4].icon == "11d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[4].icon == "11n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[4].icon == "13d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[4].icon == "13n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[4].icon == "50d")
            {
                pictureBox5.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[4].icon == "50n")
            {
                pictureBox5.BackgroundImage = Properties.Resources._50n;
            }


            if (Form1.days[5].icon == "01d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[5].icon == "01n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[5].icon == "02d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[5].icon == "02n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[5].icon == "03d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[5].icon == "03n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[5].icon == "04d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[5].icon == "09d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[5].icon == "09n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[5].icon == "10d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[5].icon == "10n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[5].icon == "11d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[5].icon == "11n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[5].icon == "13d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[5].icon == "13n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[5].icon == "50d")
            {
                pictureBox6.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[5].icon == "50n")
            {
                pictureBox6.BackgroundImage = Properties.Resources._50n;
            }

            if (Form1.days[6].icon == "01d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._01d;
            }
            //if clear sky night
            else if (Form1.days[6].icon == "01n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._01n;
            }
            //if few clouds
            else if (Form1.days[6].icon == "02d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._02d;
            }
            else if (Form1.days[6].icon == "02n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._02n;
            }
            //if scattered clouds
            else if (Form1.days[6].icon == "03d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._03d;
            }
            else if (Form1.days[6].icon == "03n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._03n;
            }
            else if (Form1.days[6].icon == "04d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._04d;
            }
            //if rainy
            else if (Form1.days[6].icon == "09d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._09d;
            }
            else if (Form1.days[6].icon == "09n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._09n;
            }
            else if (Form1.days[6].icon == "10d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._10d;
            }
            else if (Form1.days[6].icon == "10n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._10n;
            }
            //if thunderstrom
            else if (Form1.days[6].icon == "11d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._11d;
            }
            else if (Form1.days[6].icon == "11n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._11n;
            }
            //if snow
            else if (Form1.days[6].icon == "13d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._13d;
            }
            else if (Form1.days[6].icon == "13n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._13n;
            }
            //if misty
            else if (Form1.days[6].icon == "50d")
            {
                pictureBox7.BackgroundImage = Properties.Resources._50d;
            }
            else if (Form1.days[6].icon == "50n")
            {
                pictureBox7.BackgroundImage = Properties.Resources._50n;
            }









        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
