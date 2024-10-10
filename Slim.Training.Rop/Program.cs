Console.WriteLine("Hello, World!");

public class WeatherForecast
{
    public string? Location { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
}

public class Result<T> where T : class
{
    private Result(bool isSuccess, T value, string? error = null)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }
    
    public bool IsSuccess { get; }

    public T Value { get; }
    public string? Error { get; }
    
    public static Result<T> Success(T value)
    {
        return new Result<T>(true, value);
    }
    
    public static Result<T> Failure(string? error)
    {
        return new Result<T>(false, null, error);
    }
}

public class WeatherService
{
    public Result<WeatherForecast> GetWeatherForecast(string location)
    {
        return 
            Result<string>.Success(location)
            .Ensure(string.IsNullOrWhiteSpace, "Location is required")
            .Ensure(l => l.Length == 3, "Location is not valid")
            .Ensure(l => l == "USA", "not in usa")
            .Bind(GetWeatherResult);
    }

    private static Result<WeatherForecast> GetWeatherResult(string location)
    {
        var weatherForecast = new WeatherForecast
        {
            Location = location,
            Date = DateTime.Now,
            TemperatureC = 20,
        };

        return Result<WeatherForecast>.Success(weatherForecast);
    }
}

public static class ResultExtensions
{
    public static Result<TOutput> Bind<TInput, TOutput>(this Result<TInput> input, Func<TInput, Result<TOutput>> func)
        where TInput : class
        where TOutput : class
    {
        return input.IsSuccess 
            ? func(input.Value) 
            : Result<TOutput>.Failure(input.Error);
    }
    
    public static Result<TInput> Ensure<TInput>(this Result<TInput> input, Func<TInput, bool> predicate, string errorMessage)
        where TInput : class
    {
        return input.IsSuccess 
            ? predicate(input.Value) 
                ? input
                : Result<TInput>.Failure(errorMessage) 
            : Result<TInput>.Failure(input.Error);
    }
}

public class WeatherMap(WeatherService weatherService)
{
    public void GetWeatherForecast(string location)
    {
        var weatherForecast = weatherService.GetWeatherForecast(location)
            .Bind(DoSomethingWithWeatherForcast);

        //print weather forecast
    }

    private Result<string> DoSomethingWithWeatherForcast(WeatherForecast weatherForecast)
    {
        return Result<string>.Success($"Weather forecast for {weatherForecast.Location} on {weatherForecast.Date} is {weatherForecast.TemperatureC}C");
    }
}