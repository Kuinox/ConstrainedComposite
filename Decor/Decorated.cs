
namespace Decor;


public readonly struct Decorated<TDecorated,TDecor1>
    where TDecor1 : IDecor<TDecorated, TDecor1>
	
{
	internal Decorated(TDecorated core, out bool success)
	{
		Core = core;

		success = TDecor1.TryBuild(in core, out var temp );
		Decor1 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1)
	{
		Core = core;
        Decor1 = decor1;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1> arg) => arg.Core;

}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, out bool success)
	{
		Core = core;
        Decor1 = decor1;
		success = TDecor2.TryBuild(in core, out var temp );
		Decor2 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2>(Decorated<TDecorated, TDecor1, TDecor2> arg) => new(arg.Core, arg.Decor2);
	public static implicit operator Decorated<TDecorated, TDecor1>(Decorated<TDecorated, TDecor1, TDecor2> arg) => new(arg.Core, arg.Decor1);
}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2, TDecor3>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
    where TDecor3 : IDecor<TDecorated, TDecor3>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, out bool success)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
		success = TDecor3.TryBuild(in core, out var temp );
		Decor3 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    public TDecor3 Decor3 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2, TDecor3>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => new(arg.Core, arg.Decor2, arg.Decor3);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor3>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => new(arg.Core, arg.Decor1, arg.Decor3);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3> arg) => new(arg.Core, arg.Decor1, arg.Decor2);
}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
    where TDecor3 : IDecor<TDecorated, TDecor3>
    where TDecor4 : IDecor<TDecorated, TDecor4>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, out bool success)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
		success = TDecor4.TryBuild(in core, out var temp );
		Decor4 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    public TDecor3 Decor3 { get; }
    public TDecor4 Decor4 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2, TDecor3, TDecor4>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core, arg.Decor2, arg.Decor3, arg.Decor4);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor3, TDecor4>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core, arg.Decor1, arg.Decor3, arg.Decor4);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor4>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor4);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3);
}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
    where TDecor3 : IDecor<TDecorated, TDecor3>
    where TDecor4 : IDecor<TDecorated, TDecor4>
    where TDecor5 : IDecor<TDecorated, TDecor5>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, out bool success)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
		success = TDecor5.TryBuild(in core, out var temp );
		Decor5 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    public TDecor3 Decor3 { get; }
    public TDecor4 Decor4 { get; }
    public TDecor5 Decor5 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core, arg.Decor1, arg.Decor3, arg.Decor4, arg.Decor5);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor4, arg.Decor5);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor5);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4);
}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
    where TDecor3 : IDecor<TDecorated, TDecor3>
    where TDecor4 : IDecor<TDecorated, TDecor4>
    where TDecor5 : IDecor<TDecorated, TDecor5>
    where TDecor6 : IDecor<TDecorated, TDecor6>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5, out bool success)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
		success = TDecor6.TryBuild(in core, out var temp );
		Decor6 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5, TDecor6 decor6)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
        Decor6 = decor6;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    public TDecor3 Decor3 { get; }
    public TDecor4 Decor4 { get; }
    public TDecor5 Decor5 { get; }
    public TDecor6 Decor6 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5, TDecor6>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core, arg.Decor1, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5, TDecor6>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor4, arg.Decor5, arg.Decor6);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5, TDecor6>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor5, arg.Decor6);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor6>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor6);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5);
}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
    where TDecor3 : IDecor<TDecorated, TDecor3>
    where TDecor4 : IDecor<TDecorated, TDecor4>
    where TDecor5 : IDecor<TDecorated, TDecor5>
    where TDecor6 : IDecor<TDecorated, TDecor6>
    where TDecor7 : IDecor<TDecorated, TDecor7>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5, TDecor6 decor6, out bool success)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
        Decor6 = decor6;
		success = TDecor7.TryBuild(in core, out var temp );
		Decor7 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5, TDecor6 decor6, TDecor7 decor7)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
        Decor6 = decor6;
        Decor7 = decor7;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    public TDecor3 Decor3 { get; }
    public TDecor4 Decor4 { get; }
    public TDecor5 Decor5 { get; }
    public TDecor6 Decor6 { get; }
    public TDecor7 Decor7 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor1, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5, TDecor6, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5, TDecor6, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor5, arg.Decor6, arg.Decor7);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor6, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor6, arg.Decor7);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor7);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6);
}

public readonly struct Decorated<TDecorated,TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>
    where TDecor1 : IDecor<TDecorated, TDecor1>
    where TDecor2 : IDecor<TDecorated, TDecor2>
    where TDecor3 : IDecor<TDecorated, TDecor3>
    where TDecor4 : IDecor<TDecorated, TDecor4>
    where TDecor5 : IDecor<TDecorated, TDecor5>
    where TDecor6 : IDecor<TDecorated, TDecor6>
    where TDecor7 : IDecor<TDecorated, TDecor7>
    where TDecor8 : IDecor<TDecorated, TDecor8>
	
{
	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5, TDecor6 decor6, TDecor7 decor7, out bool success)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
        Decor6 = decor6;
        Decor7 = decor7;
		success = TDecor8.TryBuild(in core, out var temp );
		Decor8 = temp!;
	}

	internal Decorated(TDecorated core,TDecor1 decor1, TDecor2 decor2, TDecor3 decor3, TDecor4 decor4, TDecor5 decor5, TDecor6 decor6, TDecor7 decor7, TDecor8 decor8)
	{
		Core = core;
        Decor1 = decor1;
        Decor2 = decor2;
        Decor3 = decor3;
        Decor4 = decor4;
        Decor5 = decor5;
        Decor6 = decor6;
        Decor7 = decor7;
        Decor8 = decor8;
	}

	public TDecorated Core { get; }

    public TDecor1 Decor1 { get; }
    public TDecor2 Decor2 { get; }
    public TDecor3 Decor3 { get; }
    public TDecor4 Decor4 { get; }
    public TDecor5 Decor5 { get; }
    public TDecor6 Decor6 { get; }
    public TDecor7 Decor7 { get; }
    public TDecor8 Decor8 { get; }
    
    public static implicit operator TDecorated(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => arg.Core;

	public static implicit operator Decorated<TDecorated, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor5, TDecor6, TDecor7, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor5, arg.Decor6, arg.Decor7, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor6, TDecor7, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor6, arg.Decor7, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor7, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor7, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor8>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor8);
	public static implicit operator Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7>(Decorated<TDecorated, TDecor1, TDecor2, TDecor3, TDecor4, TDecor5, TDecor6, TDecor7, TDecor8> arg) => new(arg.Core, arg.Decor1, arg.Decor2, arg.Decor3, arg.Decor4, arg.Decor5, arg.Decor6, arg.Decor7);
}
