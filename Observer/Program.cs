//Padrão Observer 
//Seguindo Macorati 

using Observer;

internal class Program
{
    private static void Main(string[] args)
    {
        WeatherData weather = new WeatherData();
        CurrentConditionsDisplay current = new CurrentConditionsDisplay(weather);

        weather.SetMeasurements(10, 10, 10);
        weather.SetMeasurements(5, 5, 5);
    }
}