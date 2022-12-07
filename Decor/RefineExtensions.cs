
namespace RefinedComposite;

/// <summary>
/// This class hold extensions methods that allow to refine objects.
/// </summary>
public static class RefineExtensions
{
    /// <summary>
    /// Refine an object type.
    /// </summary>
    /// <typeparam name="TRefined">The unrefined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1>? Extend<TRefined, T1>( this TRefined arg )
        where T1 : IRefinement<TRefined, T1>
	{
		if(!T1.TryRefine(arg)) return null;
		return new Refined<TRefined, T1>(arg);
	}
    /// <summary>
	/// Apply an additional refinement on this refined object.
    /// </summary>
    /// <typeparam name="TRefined">The refined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <typeparam name="T2">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1, T2>? Extend<TRefined, T1, T2>( this Refined<TRefined,T1> arg )
        where T1 : IRefinement<TRefined, T1>
        where T2 : IRefinement<TRefined, T2>
	{
		if(!T2.TryRefine(arg)) return null;
		return new Refined<TRefined, T1, T2>(arg.Core);
	}
    /// <summary>
	/// Apply an additional refinement on this refined object.
    /// </summary>
    /// <typeparam name="TRefined">The refined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <typeparam name="T2">A refinement.</typeparam>
    /// <typeparam name="T3">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1, T2, T3>? Extend<TRefined, T1, T2, T3>( this Refined<TRefined,T1,T2> arg )
        where T1 : IRefinement<TRefined, T1>
        where T2 : IRefinement<TRefined, T2>
        where T3 : IRefinement<TRefined, T3>
	{
		if(!T3.TryRefine(arg)) return null;
		return new Refined<TRefined, T1, T2, T3>(arg.Core);
	}
    /// <summary>
	/// Apply an additional refinement on this refined object.
    /// </summary>
    /// <typeparam name="TRefined">The refined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <typeparam name="T2">A refinement.</typeparam>
    /// <typeparam name="T3">A refinement.</typeparam>
    /// <typeparam name="T4">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1, T2, T3, T4>? Extend<TRefined, T1, T2, T3, T4>( this Refined<TRefined,T1,T2,T3> arg )
        where T1 : IRefinement<TRefined, T1>
        where T2 : IRefinement<TRefined, T2>
        where T3 : IRefinement<TRefined, T3>
        where T4 : IRefinement<TRefined, T4>
	{
		if(!T4.TryRefine(arg)) return null;
		return new Refined<TRefined, T1, T2, T3, T4>(arg.Core);
	}
    /// <summary>
	/// Apply an additional refinement on this refined object.
    /// </summary>
    /// <typeparam name="TRefined">The refined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <typeparam name="T2">A refinement.</typeparam>
    /// <typeparam name="T3">A refinement.</typeparam>
    /// <typeparam name="T4">A refinement.</typeparam>
    /// <typeparam name="T5">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1, T2, T3, T4, T5>? Extend<TRefined, T1, T2, T3, T4, T5>( this Refined<TRefined,T1,T2,T3,T4> arg )
        where T1 : IRefinement<TRefined, T1>
        where T2 : IRefinement<TRefined, T2>
        where T3 : IRefinement<TRefined, T3>
        where T4 : IRefinement<TRefined, T4>
        where T5 : IRefinement<TRefined, T5>
	{
		if(!T5.TryRefine(arg)) return null;
		return new Refined<TRefined, T1, T2, T3, T4, T5>(arg.Core);
	}
    /// <summary>
	/// Apply an additional refinement on this refined object.
    /// </summary>
    /// <typeparam name="TRefined">The refined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <typeparam name="T2">A refinement.</typeparam>
    /// <typeparam name="T3">A refinement.</typeparam>
    /// <typeparam name="T4">A refinement.</typeparam>
    /// <typeparam name="T5">A refinement.</typeparam>
    /// <typeparam name="T6">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1, T2, T3, T4, T5, T6>? Extend<TRefined, T1, T2, T3, T4, T5, T6>( this Refined<TRefined,T1,T2,T3,T4,T5> arg )
        where T1 : IRefinement<TRefined, T1>
        where T2 : IRefinement<TRefined, T2>
        where T3 : IRefinement<TRefined, T3>
        where T4 : IRefinement<TRefined, T4>
        where T5 : IRefinement<TRefined, T5>
        where T6 : IRefinement<TRefined, T6>
	{
		if(!T6.TryRefine(arg)) return null;
		return new Refined<TRefined, T1, T2, T3, T4, T5, T6>(arg.Core);
	}
    /// <summary>
	/// Apply an additional refinement on this refined object.
    /// </summary>
    /// <typeparam name="TRefined">The refined object.</typeparam>
    /// <typeparam name="T1">A refinement.</typeparam>
    /// <typeparam name="T2">A refinement.</typeparam>
    /// <typeparam name="T3">A refinement.</typeparam>
    /// <typeparam name="T4">A refinement.</typeparam>
    /// <typeparam name="T5">A refinement.</typeparam>
    /// <typeparam name="T6">A refinement.</typeparam>
    /// <typeparam name="T7">A refinement.</typeparam>
    /// <param name="arg">The object to refine.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's refinement together.</returns>
	public static Refined<TRefined, T1, T2, T3, T4, T5, T6, T7>? Extend<TRefined, T1, T2, T3, T4, T5, T6, T7>( this Refined<TRefined,T1,T2,T3,T4,T5,T6> arg )
        where T1 : IRefinement<TRefined, T1>
        where T2 : IRefinement<TRefined, T2>
        where T3 : IRefinement<TRefined, T3>
        where T4 : IRefinement<TRefined, T4>
        where T5 : IRefinement<TRefined, T5>
        where T6 : IRefinement<TRefined, T6>
        where T7 : IRefinement<TRefined, T7>
	{
		if(!T7.TryRefine(arg)) return null;
		return new Refined<TRefined, T1, T2, T3, T4, T5, T6, T7>(arg.Core);
	}
}