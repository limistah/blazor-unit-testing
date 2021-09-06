using System;

namespace BlazorApp.Data
{
    public class CareGiver
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Pet Pet { get; set; }

    }
}
