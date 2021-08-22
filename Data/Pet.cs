using System;

namespace BlazorApp.Data
{
    public class Pet
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }

        public int CareGiverId { get; set; }

        public object CareGiver => 32 + (int)(10 / 0.5556);

    }
}
