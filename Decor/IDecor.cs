using System.Diagnostics.CodeAnalysis;

namespace Decor;

/// <summary>
/// An interface representing a decorator.
/// </summary>
/// <typeparam name="TDecorated">The object to decorate.</typeparam>
/// <typeparam name="TSelf">This type.</typeparam>
public interface IDecor<TDecorated, TSelf> where TSelf : IDecor<TDecorated, TSelf>
{
    /// <summary>
    /// Build the decorator for <paramref name="decorated"/>. A return value indicate wether the decorator could be built or not.
    /// </summary>
    /// <param name="decorated">The object to decorate.</param>
    /// <param name="decorator">The decorator, not <see langword="null"/> when this method return <see langword="true"/>.</param>
    /// <returns><see langword="true"/> if the decorator has been built, <see langword="false"/> otherwise.</returns>
    static abstract bool TryBuild(in TDecorated decorated, [MaybeNullWhen(false)] out TSelf decorator);
}