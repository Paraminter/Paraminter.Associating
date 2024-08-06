namespace Paraminter.Associators.Commands;

using Paraminter.Associators.Models;
using Paraminter.Commands;

/// <summary>Represents a command to record an association between an argument and a parameter.</summary>
/// <typeparam name="TParameter">The type representing the parameters.</typeparam>
/// <typeparam name="TArgumentData">The type representing data about the arguments.</typeparam>
public interface IRecordArgumentAssociationCommand<out TParameter, out TArgumentData>
    : ICommand
    where TParameter : IParameter
    where TArgumentData : IArgumentData
{
    /// <summary>The parameter.</summary>
    public abstract TParameter Parameter { get; }

    /// <summary>Data about the argument.</summary>
    public abstract TArgumentData ArgumentData { get; }
}
