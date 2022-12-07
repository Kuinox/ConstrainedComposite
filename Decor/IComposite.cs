using System.Diagnostics.CodeAnalysis;

namespace RefinedComposite;

/// <summary>
/// Implementation of this object allow to add Composite of a certain type to an object.
/// </summary>
/// <typeparam name="TCore">The object to be used as the core of the composition.</typeparam>
/// <typeparam name="TSelf">This type.</typeparam>
public interface IComposite<TCore, TSelf> where TSelf : IComposite<TCore, TSelf>
{
    /// <summary>
    /// Build the composition for <paramref name="core"/>. A return value indicate wether the composition could be built or not.
    /// <see cref=""/>
    /// </summary>
    /// <param name="core">The object to use as the core of the composition.</param>
    /// <param name="composite">The built <see cref="IComposite{TCore, TSelf}"/>, not <see langword="null"/> when this method return <see langword="true"/>.</param>
    /// <returns><see langword="true"/> if the <see cref="IComposite{TCore, TSelf}">composite</see> has been built, <see langword="false"/> otherwise.</returns>
    static abstract bool TryCompose(in TCore core, [MaybeNullWhen(false)] out TSelf composite);
}