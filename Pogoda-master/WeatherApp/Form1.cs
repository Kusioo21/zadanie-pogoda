using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Pogoda
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private readonly HttpClient client;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient { BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,precipitation") };
            InitializeTimer();
            WeatherData();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 900000 // 15 minut
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            WeatherData();
        }

        private async void WeatherData()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                JObject weatherData = JObject.Parse(result);

                UpdateWeatherDisplay(weatherData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d podczas pobierania danych: {ex.Message}");
            }
        }

        private void UpdateWeatherDisplay(JObject weatherData)
        {
            var currentWeather = weatherData["current"];
            var temperature = currentWeather["temperature_2m"];
            var humidity = currentWeather["relative_humidity_2m"];
            var precipitation = currentWeather["precipitation"];

            LabelTemperature.Text = $"Temperatura: {temperature} °C";
            Humidity.Text = $"Wilgotnoœæ: {humidity} %";
            Precipitation.Text = $"Opady: {precipitation} mm";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Precipitation_Click(object sender, EventArgs e)
        {

        }

        private void Humidity_Click(object sender, EventArgs e)
        {

        }

        private void LabelTemperature_Click(object sender, EventArgs e)
        {

        }
    }
}
