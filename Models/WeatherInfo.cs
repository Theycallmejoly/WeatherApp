public class WeatherInfo
{
    public MainInfo Main { get; set; }
    public List<Weather> Weather { get; set; }
    public string Name { get; set; }
}

public class MainInfo
{
    public double Temp { get; set; }
    public int Humidity { get; set; }
}

public class Weather
{
    public string Description { get; set; }
}
