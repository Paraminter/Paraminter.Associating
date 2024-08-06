namespace Paraminter.Associators.Commands;

using Paraminter.Associators.Models;
using Paraminter.Commands;

/// <summary>Represents a command to associate arguments with parameters.</summary>
/// <typeparam name="TData">The type representing the data used to associate arguments with parameters.</typeparam>
public interface IAssociateArgumentsCommand<out TData>
    : ICommand
    where TData : IAssociateArgumentsData
{
    /// <summary>The data used to associate arguments with parameters.</summary>
    public abstract TData Data { get; }
}
