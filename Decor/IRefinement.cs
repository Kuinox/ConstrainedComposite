namespace RefinedComposite;
public interface IRefinement<TRaw, TSelf> where TSelf : IRefinement<TRaw, TSelf>
{
    /// <summary>
    /// Test if the <paramref name="raw"/> object match the refinement.
    /// </summary>
    /// <param name="raw">The object to test.</param>
    /// <returns><see langword="true"/> if the object match the refinement, <see langword="false"/> otherwise.</returns>
    static abstract bool TryRefine(TRaw raw);
}
