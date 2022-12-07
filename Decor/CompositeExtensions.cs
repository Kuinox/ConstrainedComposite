
namespace RefinedComposite;

/// <summary>
/// This class hold extensions methods that allow to create anonymous composite objects.
/// </summary>
public static class CompositeExtensions
{
    /// <summary>
    /// Construct an anonymous composite object.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1>? Extend<TCore, TComposite1>( this TCore arg )
        where TComposite1 : IComposite<TCore, TComposite1>
	{
		var composition = new Composition<TCore, TComposite1>(arg, out bool res);
		if(!res) return null;
		return composition;
	}
    /// <summary>
	/// Add another composite on this anonymous composite.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <typeparam name="TComposite2">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1, TComposite2>? Extend<TCore, TComposite1, TComposite2>( this Composition<TCore,TComposite1> arg )
        where TComposite1 : IComposite<TCore, TComposite1>
        where TComposite2 : IComposite<TCore, TComposite2>
	{
		var composition = new Composition<TCore, TComposite1, TComposite2>(arg.Core, arg.Composite1, out bool res);
		if(!res) return null;
		return composition;
	}
    /// <summary>
	/// Add another composite on this anonymous composite.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <typeparam name="TComposite2">A composite.</typeparam>
    /// <typeparam name="TComposite3">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1, TComposite2, TComposite3>? Extend<TCore, TComposite1, TComposite2, TComposite3>( this Composition<TCore,TComposite1,TComposite2> arg )
        where TComposite1 : IComposite<TCore, TComposite1>
        where TComposite2 : IComposite<TCore, TComposite2>
        where TComposite3 : IComposite<TCore, TComposite3>
	{
		var composition = new Composition<TCore, TComposite1, TComposite2, TComposite3>(arg.Core, arg.Composite1, arg.Composite2, out bool res);
		if(!res) return null;
		return composition;
	}
    /// <summary>
	/// Add another composite on this anonymous composite.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <typeparam name="TComposite2">A composite.</typeparam>
    /// <typeparam name="TComposite3">A composite.</typeparam>
    /// <typeparam name="TComposite4">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4>? Extend<TCore, TComposite1, TComposite2, TComposite3, TComposite4>( this Composition<TCore,TComposite1,TComposite2,TComposite3> arg )
        where TComposite1 : IComposite<TCore, TComposite1>
        where TComposite2 : IComposite<TCore, TComposite2>
        where TComposite3 : IComposite<TCore, TComposite3>
        where TComposite4 : IComposite<TCore, TComposite4>
	{
		var composition = new Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4>(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, out bool res);
		if(!res) return null;
		return composition;
	}
    /// <summary>
	/// Add another composite on this anonymous composite.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <typeparam name="TComposite2">A composite.</typeparam>
    /// <typeparam name="TComposite3">A composite.</typeparam>
    /// <typeparam name="TComposite4">A composite.</typeparam>
    /// <typeparam name="TComposite5">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5>? Extend<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5>( this Composition<TCore,TComposite1,TComposite2,TComposite3,TComposite4> arg )
        where TComposite1 : IComposite<TCore, TComposite1>
        where TComposite2 : IComposite<TCore, TComposite2>
        where TComposite3 : IComposite<TCore, TComposite3>
        where TComposite4 : IComposite<TCore, TComposite4>
        where TComposite5 : IComposite<TCore, TComposite5>
	{
		var composition = new Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5>(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, out bool res);
		if(!res) return null;
		return composition;
	}
    /// <summary>
	/// Add another composite on this anonymous composite.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <typeparam name="TComposite2">A composite.</typeparam>
    /// <typeparam name="TComposite3">A composite.</typeparam>
    /// <typeparam name="TComposite4">A composite.</typeparam>
    /// <typeparam name="TComposite5">A composite.</typeparam>
    /// <typeparam name="TComposite6">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6>? Extend<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6>( this Composition<TCore,TComposite1,TComposite2,TComposite3,TComposite4,TComposite5> arg )
        where TComposite1 : IComposite<TCore, TComposite1>
        where TComposite2 : IComposite<TCore, TComposite2>
        where TComposite3 : IComposite<TCore, TComposite3>
        where TComposite4 : IComposite<TCore, TComposite4>
        where TComposite5 : IComposite<TCore, TComposite5>
        where TComposite6 : IComposite<TCore, TComposite6>
	{
		var composition = new Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6>(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, out bool res);
		if(!res) return null;
		return composition;
	}
    /// <summary>
	/// Add another composite on this anonymous composite.
    /// </summary>
    /// <typeparam name="TCore">The core object.</typeparam>
    /// <typeparam name="TComposite1">A composite.</typeparam>
    /// <typeparam name="TComposite2">A composite.</typeparam>
    /// <typeparam name="TComposite3">A composite.</typeparam>
    /// <typeparam name="TComposite4">A composite.</typeparam>
    /// <typeparam name="TComposite5">A composite.</typeparam>
    /// <typeparam name="TComposite6">A composite.</typeparam>
    /// <typeparam name="TComposite7">A composite.</typeparam>
    /// <param name="arg">The object to use as the core of the anonymous composite.</param>
    /// <returns> A datastructure that hold the core, <paramref name="arg"/> and it's composite together.</returns>
	public static Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>? Extend<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>( this Composition<TCore,TComposite1,TComposite2,TComposite3,TComposite4,TComposite5,TComposite6> arg )
        where TComposite1 : IComposite<TCore, TComposite1>
        where TComposite2 : IComposite<TCore, TComposite2>
        where TComposite3 : IComposite<TCore, TComposite3>
        where TComposite4 : IComposite<TCore, TComposite4>
        where TComposite5 : IComposite<TCore, TComposite5>
        where TComposite6 : IComposite<TCore, TComposite6>
        where TComposite7 : IComposite<TCore, TComposite7>
	{
		var composition = new Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, out bool res);
		if(!res) return null;
		return composition;
	}
}