using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace BookingClone.API.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IDistributedCache _distributedCache;

    public WeatherForecastController(IDistributedCache distributedCache)
        => _distributedCache = distributedCache;

    /// <summary>
    /// Gets Random forecasts
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get()
    {
        var key = HttpContext.Request.Path.Value;
        var cachedResult = await GetCachedResponseAsync(key);

        if (cachedResult is not null)
        {
            var x = JsonSerializer.Deserialize<List<WeatherForecast>>(cachedResult);
            return Ok(x);
        }

        var res = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();

        await CacheResponseAsync(key, res, TimeSpan.FromSeconds(50));
        return Ok(res);
    }

    async Task CacheResponseAsync(string cacheKey, object response, TimeSpan timeToLive)
    {
        if (response is null)
            return;

        var serializedResponse = JsonSerializer.Serialize(response);
        await _distributedCache.SetStringAsync(cacheKey, serializedResponse, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = timeToLive,
        });
    }

    async Task<string?> GetCachedResponseAsync(string cacheKey)
    {
        return await _distributedCache.GetStringAsync(cacheKey);
    }
}
