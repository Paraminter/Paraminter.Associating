namespace Paraminter.Associators.Queries;

using Paraminter.Queries;

/// <summary>Represents a query for associated arguments.</summary>
/// <typeparam name="TData">The type representing the data used to associate arguments.</typeparam>
public interface IAssociateArgumentsQuery<out TData>
    : IQuery
{
    /// <summary>The data used to associate arguments.</summary>
    public abstract TData Data { get; }
}
