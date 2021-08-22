using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class PetService
    {
        private static readonly string[] CareGivers = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Pet
            {
                Date = startDate.AddDays(index),
                Name = CareGivers[rng.Next(CareGivers.Length)]
            }).ToArray());
        }
    }
}