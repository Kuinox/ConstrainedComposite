
namespace Decor;

/// <summary>
/// This class hold extensions methods that allow to decorate objects.
/// </summary>
public static class StatelessDecorExtensions
{
    /// <summary>
    /// Apply a decorator on an object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static StateLessDecorated<TDecorated, TDecor1>? Extend<TDecorated, TDecor1>( this TDecorated arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
	{
		if(!TDecor1.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1>(arg);
	}
    /// <summary>
	/// Apply an additional decorator on this decorated object.
    /// </summary>
    /// <typeparam name="TDecorated">The decorated object.</typeparam>
    /// <typeparam name="TDecor1">A decorator.</typeparam>
    /// <typeparam name="TDecor2">A decorator.</typeparam>
    /// <param name="arg">The object to decorate.</param>
    /// <returns> A datastructure that hold <paramref name="arg"/> and it's decorators together.</returns>
	public static StateLessDecorated<TDecorated, TDecor1, TDecor2>? Extend<TDecorated, TDecor1, TDecor2>( this StateLessDecorated<TDecorated,TDecor1> arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
        where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
	{
		if(!TDecor2.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1, TDecor2>(arg.Core);
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
	public static StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3>? Extend<TDecorated, TDecor1, TDecor2, TDecor3>( this StateLessDecorated<TDecorated,TDecor1,TDecor2> arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
        where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
        where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
	{
		if(!TDecor3.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3>(arg.Core);
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
	public static StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>( this StateLessDecorated<TDecorated,TDecor1,TDecor2,TDecor3> arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
        where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
        where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
        where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
	{
		if(!TDecor4.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>(arg.Core);
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
	public static StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>( this StateLessDecorated<TDecorated,TDecor1,TDecor2,TDecor3,TDecor4> arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
        where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
        where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
        where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
        where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
	{
		if(!TDecor5.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>(arg.Core);
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
	public static StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>( this StateLessDecorated<TDecorated,TDecor1,TDecor2,TDecor3,TDecor4,TDecor5> arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
        where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
        where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
        where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
        where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
        where TDecor6 : IStateLessDecor<TDecorated, TDecor6>
	{
		if(!TDecor6.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>(arg.Core);
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
	public static StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>? Extend<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>( this StateLessDecorated<TDecorated,TDecor1,TDecor2,TDecor3,TDecor4,TDecor5,TDecor6> arg )
        where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
        where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
        where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
        where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
        where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
        where TDecor6 : IStateLessDecor<TDecorated, TDecor6>
        where TDecor7 : IStateLessDecor<TDecorated, TDecor7>
	{
		if(!TDecor7.IsValid(arg)) return null;
		return new StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(arg.Core);
	}
}