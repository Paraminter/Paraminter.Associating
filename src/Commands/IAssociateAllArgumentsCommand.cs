namespace Paraminter.Commands;

using Paraminter.Cqs;
using Paraminter.Models;

/// <summary>Represents a command to associate all arguments with parameters.</summary>
/// <typeparam name="TData">The type representing the data used to associate arguments with parameters.</typeparam>
public interface IAssociateAllArgumentsCommand<out TData>
    : ICommand
    where TData : IAssociateAllArgumentsData
{
    /// <summary>The data used to associate arguments with parameters.</summary>
    public abstract TData Data { get; }
}
