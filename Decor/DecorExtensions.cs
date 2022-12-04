
namespace Decor;

/// <summary>
/// This class hold extensions methods that allow to decorate objects.
/// </summary>
public static class DecorExtensions
{
    /// <summary>
    /// Apply a decorator on an object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1>? Extend<TDecorated, TDecor1>( TDecorated arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
	{
		var decorated = new Decorated<TDecorated, TDecor1>(arg, out bool res);
		if(!res) return null;
		return decorated;
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1, TDecor2>? Extend<TDecorated, TDecor1, TDecor2>( Decorated<TDecorated,TDecor1> arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
        where TDecor2 : IDecor<TDecorated, TDecor2>
	{
		var decorated = new Decorated<TDecorated, TDecor1, TDecor2>(arg.Core, arg.Decor1, out bool res);
		if(!res) return null;
		return decorated;
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <typeparam name="TDecor3">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1, TDecor2, TDecor3>? Extend<TDecorated, TDecor1, TDecor2, TDecor3>( Decorated<TDecorated,TDecor1,TDecor2> arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
        where TDecor2 : IDecor<TDecorated, TDecor2>
        where TDecor3 : IDecor<TDecorated, TDecor3>
	{
		var decorated = new Decorated<TDecorated, TDecor1, TDecor2, TDecor3>(arg.Core, arg.Decor1, arg.Decor2, out bool res);
		if(!res) return null;
		return decorated;
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <typeparam name="TDecor3">A decorator.</typeparam>
    /// <typeparam name="TDecor4">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>( Decorated<TDecorated,TDecor1,TDecor2,TDecor3> arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
        where TDecor2 : IDecor<TDecorated, TDecor2>
        where TDecor3 : IDecor<TDecorated, TDecor3>
        where TDecor4 : IDecor<TDecorated, TDecor4>
	{
		var decorated = new Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, out bool res);
		if(!res) return null;
		return decorated;
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <typeparam name="TDecor3">A decorator.</typeparam>
    /// <typeparam name="TDecor4">A decorator.</typeparam>
    /// <typeparam name="TDecor5">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>( Decorated<TDecorated,TDecor1,TDecor2,TDecor3,TDecor4> arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
        where TDecor2 : IDecor<TDecorated, TDecor2>
        where TDecor3 : IDecor<TDecorated, TDecor3>
        where TDecor4 : IDecor<TDecorated, TDecor4>
        where TDecor5 : IDecor<TDecorated, TDecor5>
	{
		var decorated = new Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, out bool res);
		if(!res) return null;
		return decorated;
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <typeparam name="TDecor3">A decorator.</typeparam>
    /// <typeparam name="TDecor4">A decorator.</typeparam>
    /// <typeparam name="TDecor5">A decorator.</typeparam>
    /// <typeparam name="TDecor6">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>( Decorated<TDecorated,TDecor1,TDecor2,TDecor3,TDecor4,TDecor5> arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
        where TDecor2 : IDecor<TDecorated, TDecor2>
        where TDecor3 : IDecor<TDecorated, TDecor3>
        where TDecor4 : IDecor<TDecorated, TDecor4>
        where TDecor5 : IDecor<TDecorated, TDecor5>
        where TDecor6 : IDecor<TDecorated, TDecor6>
	{
		var decorated = new Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, out bool res);
		if(!res) return null;
		return decorated;
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <typeparam name="TDecor3">A decorator.</typeparam>
    /// <typeparam name="TDecor4">A decorator.</typeparam>
    /// <typeparam name="TDecor5">A decorator.</typeparam>
    /// <typeparam name="TDecor6">A decorator.</typeparam>
    /// <typeparam name="TDecor7">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>( Decorated<TDecorated,TDecor1,TDecor2,TDecor3,TDecor4,TDecor5,TDecor6> arg )
        where TDecor1 : IDecor<TDecorated, TDecor1>
        where TDecor2 : IDecor<TDecorated, TDecor2>
        where TDecor3 : IDecor<TDecorated, TDecor3>
        where TDecor4 : IDecor<TDecorated, TDecor4>
        where TDecor5 : IDecor<TDecorated, TDecor5>
        where TDecor6 : IDecor<TDecorated, TDecor6>
        where TDecor7 : IDecor<TDecorated, TDecor7>
	{
		var decorated = new Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, out bool res);
		if(!res) return null;
		return decorated;
	}
}