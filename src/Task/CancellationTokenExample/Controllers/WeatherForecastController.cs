using Microsoft.AspNetCore.Mvc;

namespace CancellationTokenExample.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("longrunningtask")]
    public async Task<IActionResult> LongRunningTask(CancellationToken cancellationToken)
    {
        try
        {
            int iterations = 20;

            for (int i = 0; i < iterations; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                _logger.LogInformation($"Iteration {i + 1} of {iterations} completed.");
            }

            return Ok("Long-running task completed successfully.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Download cancelled.");
            return Ok("Long-running task cancelled successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Response.StatusCode = 500;
            return Ok("Inernal error.");
        }
    }
}
