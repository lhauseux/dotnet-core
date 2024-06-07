using LH.Core.Utilities;

namespace LH.Core;

public abstract class EntityBase : IEquatable<EntityBase>
{
    public Guid Id { get; private set; }

    protected EntityBase()
    {

    }

    protected EntityBase(Guid id)
    {
        Ensure.NotEmpty(id, "Identifier is required", nameof(id));

        Id = id;
    }

    public static bool operator ==(EntityBase a, EntityBase b)
    {
        if (a is null && b is null)
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(EntityBase a, EntityBase b) => !(a == b);

    public bool Equals(EntityBase? other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other) || Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        if (obj is not EntityBase other)
        {
            return false;
        }

        if (Id == Guid.Empty || other.Id == Guid.Empty)
        {
            return false;
        }

        return Id == other.Id;
    }

    public override int GetHashCode() => Id.GetHashCode() * 41;
}