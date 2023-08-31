namespace Observer;

public class WeatherData : ISubject
{

    private List<IObserver> Observers;
    private float Temperature;
    private float Humidity;
    private float Pressure; 

    public WeatherData() { 
        Observers  = new List<IObserver>(); 
    }
    public void notifyObservers()
    {
        Observers.ForEach(o => o.Update(Temperature, Humidity, Pressure));
    }
    public void registerObserver(IObserver o)
    {
        Observers.Add(o);
    }
    public void unregisterObserver(IObserver o)
    {
        Observers.Remove(o);
    }
    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        notifyObservers();
    }

}
