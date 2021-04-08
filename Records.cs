using System;

namespace CSharp9
{
    public record Entity
    {
        public int Id { get; init; }
    }

    public record Product : Entity
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
