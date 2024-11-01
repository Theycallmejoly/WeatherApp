using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; 

public class WeatherController : Controller
{
    private readonly string _apiKey = "a39a365c2f51a9b1dca28bc2189b69d2"; 

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string city)
    {
        var weatherInfo = await GetWeatherData(city);
        return View(weatherInfo);
    }

    private async Task<WeatherInfo> GetWeatherData(string city)
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric");
            var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(response);
            return weatherInfo;
        }
    }
}
