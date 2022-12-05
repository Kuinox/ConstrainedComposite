
namespace Decor;


public readonly struct StateLessDecorated<TDecorated,TDecor1>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1> arg) => arg.Core;

}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2>(StateLessDecorated<TDecorated, TDecor1, TDecor2> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1>(StateLessDecorated<TDecorated, TDecor1, TDecor2> arg) => new(arg.Core);
}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2, TDecor3>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
    where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2, TDecor3>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor3>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => new(arg.Core);
}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
    where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
    where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2, TDecor3, TDecor4>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor3, TDecor4>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor4>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core);
}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
    where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
    where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
    where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core);
}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
    where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
    where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
    where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
    where TDecor6 : IStateLessDecor<TDecorated, TDecor6>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5, TDecor6>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5, TDecor6>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5, TDecor6>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor6>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core);
}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
    where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
    where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
    where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
    where TDecor6 : IStateLessDecor<TDecorated, TDecor6>
    where TDecor7 : IStateLessDecor<TDecorated, TDecor7>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5, TDecor6, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5, TDecor6, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor6, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core);
}

public readonly struct StateLessDecorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>
    where TDecor1 : IStateLessDecor<TDecorated, TDecor1>
    where TDecor2 : IStateLessDecor<TDecorated, TDecor2>
    where TDecor3 : IStateLessDecor<TDecorated, TDecor3>
    where TDecor4 : IStateLessDecor<TDecorated, TDecor4>
    where TDecor5 : IStateLessDecor<TDecorated, TDecor5>
    where TDecor6 : IStateLessDecor<TDecorated, TDecor6>
    where TDecor7 : IStateLessDecor<TDecorated, TDecor7>
    where TDecor8 : IStateLessDecor<TDecorated, TDecor8>
	
{
	internal StateLessDecorated(TDecorated core)
	{
		Core = core;
	}

	public TDecorated Core { get; }

    public static implicit operator TDecorated(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => arg.Core;

	public static implicit operator StateLessDecorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5, TDecor6, TDecor7, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor6, TDecor7, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor7, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor8>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
	public static implicit operator StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(StateLessDecorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core);
}
