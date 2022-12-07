
namespace ConstrainedComposite;

/// <summary>
/// This class hold extensions methods that allow to constraint objects.
/// </summary>
public static class ConstrainExtensions
{
    /// <summary>
    /// Constraint an object type.
    /// </summary>
    /// <typeparam name="TConstrained">The unConstrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1>? Constrain<TConstrained, T1>( this TConstrained arg )
        where T1 : IConstrainer<TConstrained>
	{
		if(!T1.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1>(arg);
	}
    /// <summary>
	/// Apply an additional constraint on this constrained object.
    /// </summary>
    /// <typeparam name="TConstrained">The Constrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <typeparam name="T2">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1, T2>? Constrain<TConstrained, T1, T2>( this Constrained<TConstrained,T1> arg )
        where T1 : IConstrainer<TConstrained>
        where T2 : IConstrainer<TConstrained>
	{
		if(!T2.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1, T2>(arg.Core);
	}
    /// <summary>
	/// Apply an additional constraint on this constrained object.
    /// </summary>
    /// <typeparam name="TConstrained">The Constrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <typeparam name="T2">A constraint.</typeparam>
    /// <typeparam name="T3">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1, T2, T3>? Constrain<TConstrained, T1, T2, T3>( this Constrained<TConstrained,T1,T2> arg )
        where T1 : IConstrainer<TConstrained>
        where T2 : IConstrainer<TConstrained>
        where T3 : IConstrainer<TConstrained>
	{
		if(!T3.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1, T2, T3>(arg.Core);
	}
    /// <summary>
	/// Apply an additional constraint on this constrained object.
    /// </summary>
    /// <typeparam name="TConstrained">The Constrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <typeparam name="T2">A constraint.</typeparam>
    /// <typeparam name="T3">A constraint.</typeparam>
    /// <typeparam name="T4">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1, T2, T3, T4>? Constrain<TConstrained, T1, T2, T3, T4>( this Constrained<TConstrained,T1,T2,T3> arg )
        where T1 : IConstrainer<TConstrained>
        where T2 : IConstrainer<TConstrained>
        where T3 : IConstrainer<TConstrained>
        where T4 : IConstrainer<TConstrained>
	{
		if(!T4.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1, T2, T3, T4>(arg.Core);
	}
    /// <summary>
	/// Apply an additional constraint on this constrained object.
    /// </summary>
    /// <typeparam name="TConstrained">The Constrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <typeparam name="T2">A constraint.</typeparam>
    /// <typeparam name="T3">A constraint.</typeparam>
    /// <typeparam name="T4">A constraint.</typeparam>
    /// <typeparam name="T5">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1, T2, T3, T4, T5>? Constrain<TConstrained, T1, T2, T3, T4, T5>( this Constrained<TConstrained,T1,T2,T3,T4> arg )
        where T1 : IConstrainer<TConstrained>
        where T2 : IConstrainer<TConstrained>
        where T3 : IConstrainer<TConstrained>
        where T4 : IConstrainer<TConstrained>
        where T5 : IConstrainer<TConstrained>
	{
		if(!T5.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1, T2, T3, T4, T5>(arg.Core);
	}
    /// <summary>
	/// Apply an additional constraint on this constrained object.
    /// </summary>
    /// <typeparam name="TConstrained">The Constrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <typeparam name="T2">A constraint.</typeparam>
    /// <typeparam name="T3">A constraint.</typeparam>
    /// <typeparam name="T4">A constraint.</typeparam>
    /// <typeparam name="T5">A constraint.</typeparam>
    /// <typeparam name="T6">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1, T2, T3, T4, T5, T6>? Constrain<TConstrained, T1, T2, T3, T4, T5, T6>( this Constrained<TConstrained,T1,T2,T3,T4,T5> arg )
        where T1 : IConstrainer<TConstrained>
        where T2 : IConstrainer<TConstrained>
        where T3 : IConstrainer<TConstrained>
        where T4 : IConstrainer<TConstrained>
        where T5 : IConstrainer<TConstrained>
        where T6 : IConstrainer<TConstrained>
	{
		if(!T6.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1, T2, T3, T4, T5, T6>(arg.Core);
	}
    /// <summary>
	/// Apply an additional constraint on this constrained object.
    /// </summary>
    /// <typeparam name="TConstrained">The Constrained object.</typeparam>
    /// <typeparam name="T1">A constraint.</typeparam>
    /// <typeparam name="T2">A constraint.</typeparam>
    /// <typeparam name="T3">A constraint.</typeparam>
    /// <typeparam name="T4">A constraint.</typeparam>
    /// <typeparam name="T5">A constraint.</typeparam>
    /// <typeparam name="T6">A constraint.</typeparam>
    /// <typeparam name="T7">A constraint.</typeparam>
    /// <param name="arg">The object to constraint.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's constraint together.</returns>
	public static Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7>? Constrain<TConstrained, T1, T2, T3, T4, T5, T6, T7>( this Constrained<TConstrained,T1,T2,T3,T4,T5,T6> arg )
        where T1 : IConstrainer<TConstrained>
        where T2 : IConstrainer<TConstrained>
        where T3 : IConstrainer<TConstrained>
        where T4 : IConstrainer<TConstrained>
        where T5 : IConstrainer<TConstrained>
        where T6 : IConstrainer<TConstrained>
        where T7 : IConstrainer<TConstrained>
	{
		if(!T7.TryConstrain(arg)) return null;
		return new Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7>(arg.Core);
	}
}