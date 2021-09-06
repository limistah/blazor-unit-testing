using System;

namespace BlazorApp.Data
{
    public class Pet
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public CareGiver CareGiver { get; set; }

    }
}
