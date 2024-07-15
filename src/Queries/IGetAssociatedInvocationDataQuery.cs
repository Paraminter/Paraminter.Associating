namespace Paraminter.Associators.Queries;

using Paraminter.Queries;

/// <summary>Represents a query for associations between data about the arguments and the parameters of an invocation, given unassociated invocation data.</summary>
/// <typeparam name="TUnassociatedInvocationData">The type representing the unassociated invocation data.</typeparam>
public interface IGetAssociatedInvocationDataQuery<out TUnassociatedInvocationData>
    : IQuery
{
    /// <summary>The unassociated invocation data.</summary>
    public abstract TUnassociatedInvocationData UnassociatedInvocationData { get; }
}
