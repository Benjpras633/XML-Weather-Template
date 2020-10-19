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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;

            
            tempLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0) + "°C";

            
            conditionOutput.Text = Form1.days[0].condition;

            
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0) + "°";
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0) + "°";

            
            riseOutput.Text = Convert.ToDateTime(Form1.days[0].sunrise).ToString("h:mm tt");
            setOutput.Text = Convert.ToDateTime(Form1.days[0].sunset).ToString("h:mm tt");

            //humidity
            humidityOutput.Text = Form1.days[0].humidity + "%";

            dateLabel.Text = DateTime.Now.AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("dddd") + ", "
             + DateTime.Now.AddSeconds(Convert.ToInt32(Form1.days[0].timeZone) + 14400).ToString("MMM dd") + ", " + DateTime.Now.ToString("yyyy");

             dateLabel2.Text = DateTime.Now.AddDays(0).ToString("hh:mm tt");

            //if clear sky
            if (Form1.days[0].icon == "01d")
            {
                this.BackgroundImage = Properties.Resources.clearsky;
            }
            //if clear sky night
            else if (Form1.days[0].icon == "01n")
            {
                this.BackgroundImage = Properties.Resources.clearskynight;
            }
            //if few clouds
            else if (Form1.days[0].icon == "02d")
            {
                this.BackgroundImage = Properties.Resources.cloudy;
            }
            else if (Form1.days[0].icon == "02n")
            {
                this.BackgroundImage = Properties.Resources.cloudynight;
            }
            //if scattered clouds
            else if (Form1.days[0].icon == "03d")
            {
                this.BackgroundImage = Properties.Resources.sacattered;
            }
            else if (Form1.days[0].icon == "03n")
            {
                this.BackgroundImage = Properties.Resources.scatterednight;
            }          
            else if (Form1.days[0].icon == "04d")
            {
                this.BackgroundImage = Properties.Resources.cloudy;
            }
            //if rainy
            else if (Form1.days[0].icon == "10d" || Form1.days[0].icon == "10n" || Form1.days[0].icon == "09d" || Form1.days[0].icon == "09n")
            {
                this.BackgroundImage = Properties.Resources.rain;
            }
            //if thunderstrom
            else if (Form1.days[0].icon == "11d" || Form1.days[0].icon == "11n")
            {
                this.BackgroundImage = Properties.Resources.lightning;
            }
            //if snow
            else if (Form1.days[0].icon == "13d")
            {
                this.BackgroundImage = Properties.Resources.snowy;
            }
            else if (Form1.days[0].icon == "13n")
            {
                this.BackgroundImage = Properties.Resources.snowynight;
            }
            //if misty
            else if (Form1.days[0].icon == "50d")
            {
                this.BackgroundImage = Properties.Resources.misty;
            }
            else if (Form1.days[0].icon == "50n")
            {
                this.BackgroundImage = Properties.Resources.misty;
            }



        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }   
    }
}
