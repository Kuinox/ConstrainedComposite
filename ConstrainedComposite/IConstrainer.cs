namespace ConstrainedComposite;
public interface IConstrainer<TRaw>
{
    /// <summary>
    /// Test if the <paramref name="raw"/> object match the constraint.
    /// </summary>
    /// <param name="raw">The object to test.</param>
    /// <returns><see langword="true"/> if the object match the constraint, <see langword="false"/> otherwise.</returns>
    static abstract bool TryConstrain(TRaw raw);
}
