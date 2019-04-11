using System;

namespace EFPractice
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}