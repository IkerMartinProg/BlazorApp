namespace BlazorApp.Data;

public class WeatherForecastService
{
    /*
        Array "Summaries": contiene los diferentes tipos de estado temporal.
    */
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        /* 
            Devuelve cinco filas de datos (Range).
            Los datos recogidos se asocian a la clase de definición "WeatherForecast".
            Los valores de "TemperatureC" y "Summary" se generan de manera random, 
            respetando el rango de valores establecido.
        */
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }
}
