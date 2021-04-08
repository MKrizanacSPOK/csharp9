using System;

namespace CSharp9
{
    public abstract record Event<T>(T Id, int Version);

    public record ParentAssigned(Guid Id, Guid ParentId, int Version) : Event<Guid>(Id, Version);
}