using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = GetWeather();
            if (result.Result == null)
            {
                await DisplayAlert("警报", result.Reason, "确定");
                return;
            }
            BindingContext = result.Result.RealTime;
            listBox_Future.ItemsSource = result.Result.Future;
            image_Info.Source = $"id_{result.Result.RealTime.Wid}.gif";
        }
        public WeatherResult GetWeather()
        {
            var city = this.txt_City.Text.Trim();
            string key = "44c38f50a4d7c7e9601abc0cd7f50be0";
            string url = @"http://apis.juhe.cn/simpleWeather/query?city=" + city + "&key=" + key;
            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest; ;
            webRequest.Method = "GET";
            webRequest.ContentType = "text/html";
            using (StreamReader sr = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                string str = sr.ReadToEnd();
                var result = JsonConvert.DeserializeObject<WeatherResult>(str);
                return result;
            }
        }
    }

}
