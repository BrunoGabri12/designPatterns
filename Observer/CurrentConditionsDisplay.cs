using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer;

internal class CurrentConditionsDisplay : IObserver
{

    float Temp;
    float Humidity; 
    ISubject WeatherData;

    public CurrentConditionsDisplay(ISubject wD)
    {
         this.WeatherData = wD;
         WeatherData.registerObserver(this); 
    }

    public void Update(float temp, float humidity, float pressure)
    {
        Temp = temp;
        Humidity = humidity;

        Console.WriteLine("Isso foi um observer que mandou = "+temp + " " + humidity);
    }


}
