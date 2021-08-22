using System;

namespace BlazorApp.Data
{
    public class CareGiver
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int PetId { get; set; }

        public object Pet => 32 + (int)(TemperatureC / 0.5556);

    }
}
