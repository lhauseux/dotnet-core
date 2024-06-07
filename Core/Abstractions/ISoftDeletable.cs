namespace LH.Core.Abstractions;

public interface ISoftDeletable
{
    DateTime? DeletedAt { get; set; }
    string? DeletedBy { get; set; }
}