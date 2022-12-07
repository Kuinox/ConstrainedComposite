
namespace ConstrainedComposite;


public readonly struct Composition<TCore,TComposite1>
    where TComposite1 : IComposite<TCore, TComposite1>
	
{
	internal Composition(TCore core, out bool success)
	{
		Core = core;

		success = TComposite1.TryCompose(in core, out var temp );
		Composite1 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1)
	{
		Core = core;
        Composite1 = composite1;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1> arg) => arg.Core;

}

public readonly struct Composition<TCore,TComposite1, TComposite2>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
	
{
	internal Composition(TCore core,TComposite1 composite1, out bool success)
	{
		Core = core;
        Composite1 = composite1;
		success = TComposite2.TryCompose(in core, out var temp );
		Composite2 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2>(Composition<TCore, TComposite1, TComposite2> arg) => new(arg.Core, arg.Composite2);
	public static implicit operator Composition<TCore, TComposite1>(Composition<TCore, TComposite1, TComposite2> arg) => new(arg.Core, arg.Composite1);
}

public readonly struct Composition<TCore,TComposite1, TComposite2, TComposite3>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
    where TComposite3 : IComposite<TCore, TComposite3>
	
{
	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, out bool success)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
		success = TComposite3.TryCompose(in core, out var temp );
		Composite3 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    public TComposite3 Composite3 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2, TComposite3> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2, TComposite3>(Composition<TCore, TComposite1, TComposite2, TComposite3> arg) => new(arg.Core, arg.Composite2, arg.Composite3);
	public static implicit operator Composition<TCore, TComposite1, TComposite3>(Composition<TCore, TComposite1, TComposite2, TComposite3> arg) => new(arg.Core, arg.Composite1, arg.Composite3);
	public static implicit operator Composition<TCore, TComposite1, TComposite2>(Composition<TCore, TComposite1, TComposite2, TComposite3> arg) => new(arg.Core, arg.Composite1, arg.Composite2);
}

public readonly struct Composition<TCore,TComposite1, TComposite2, TComposite3, TComposite4>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
    where TComposite3 : IComposite<TCore, TComposite3>
    where TComposite4 : IComposite<TCore, TComposite4>
	
{
	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, out bool success)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
		success = TComposite4.TryCompose(in core, out var temp );
		Composite4 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    public TComposite3 Composite3 { get; }
    public TComposite4 Composite4 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2, TComposite3, TComposite4>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4> arg) => new(arg.Core, arg.Composite2, arg.Composite3, arg.Composite4);
	public static implicit operator Composition<TCore, TComposite1, TComposite3, TComposite4>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4> arg) => new(arg.Core, arg.Composite1, arg.Composite3, arg.Composite4);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite4>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite4);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3);
}

public readonly struct Composition<TCore,TComposite1, TComposite2, TComposite3, TComposite4, TComposite5>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
    where TComposite3 : IComposite<TCore, TComposite3>
    where TComposite4 : IComposite<TCore, TComposite4>
    where TComposite5 : IComposite<TCore, TComposite5>
	
{
	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, out bool success)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
		success = TComposite5.TryCompose(in core, out var temp );
		Composite5 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    public TComposite3 Composite3 { get; }
    public TComposite4 Composite4 { get; }
    public TComposite5 Composite5 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2, TComposite3, TComposite4, TComposite5>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5> arg) => new(arg.Core, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5);
	public static implicit operator Composition<TCore, TComposite1, TComposite3, TComposite4, TComposite5>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5> arg) => new(arg.Core, arg.Composite1, arg.Composite3, arg.Composite4, arg.Composite5);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite4, TComposite5>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite4, arg.Composite5);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite5>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite5);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4);
}

public readonly struct Composition<TCore,TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
    where TComposite3 : IComposite<TCore, TComposite3>
    where TComposite4 : IComposite<TCore, TComposite4>
    where TComposite5 : IComposite<TCore, TComposite5>
    where TComposite6 : IComposite<TCore, TComposite6>
	
{
	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5, out bool success)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
		success = TComposite6.TryCompose(in core, out var temp );
		Composite6 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5, TComposite6 composite6)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
        Composite6 = composite6;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    public TComposite3 Composite3 { get; }
    public TComposite4 Composite4 { get; }
    public TComposite5 Composite5 { get; }
    public TComposite6 Composite6 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => new(arg.Core, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6);
	public static implicit operator Composition<TCore, TComposite1, TComposite3, TComposite4, TComposite5, TComposite6>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => new(arg.Core, arg.Composite1, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite4, TComposite5, TComposite6>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite4, arg.Composite5, arg.Composite6);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite5, TComposite6>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite5, arg.Composite6);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite6>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite6);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5);
}

public readonly struct Composition<TCore,TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
    where TComposite3 : IComposite<TCore, TComposite3>
    where TComposite4 : IComposite<TCore, TComposite4>
    where TComposite5 : IComposite<TCore, TComposite5>
    where TComposite6 : IComposite<TCore, TComposite6>
    where TComposite7 : IComposite<TCore, TComposite7>
	
{
	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5, TComposite6 composite6, out bool success)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
        Composite6 = composite6;
		success = TComposite7.TryCompose(in core, out var temp );
		Composite7 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5, TComposite6 composite6, TComposite7 composite7)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
        Composite6 = composite6;
        Composite7 = composite7;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    public TComposite3 Composite3 { get; }
    public TComposite4 Composite4 { get; }
    public TComposite5 Composite5 { get; }
    public TComposite6 Composite6 { get; }
    public TComposite7 Composite7 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7);
	public static implicit operator Composition<TCore, TComposite1, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite1, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite4, TComposite5, TComposite6, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite5, TComposite6, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite5, arg.Composite6, arg.Composite7);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite6, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite6, arg.Composite7);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite7);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6);
}

public readonly struct Composition<TCore,TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8>
    where TComposite1 : IComposite<TCore, TComposite1>
    where TComposite2 : IComposite<TCore, TComposite2>
    where TComposite3 : IComposite<TCore, TComposite3>
    where TComposite4 : IComposite<TCore, TComposite4>
    where TComposite5 : IComposite<TCore, TComposite5>
    where TComposite6 : IComposite<TCore, TComposite6>
    where TComposite7 : IComposite<TCore, TComposite7>
    where TComposite8 : IComposite<TCore, TComposite8>
	
{
	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5, TComposite6 composite6, TComposite7 composite7, out bool success)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
        Composite6 = composite6;
        Composite7 = composite7;
		success = TComposite8.TryCompose(in core, out var temp );
		Composite8 = temp!;
	}

	internal Composition(TCore core,TComposite1 composite1, TComposite2 composite2, TComposite3 composite3, TComposite4 composite4, TComposite5 composite5, TComposite6 composite6, TComposite7 composite7, TComposite8 composite8)
	{
		Core = core;
        Composite1 = composite1;
        Composite2 = composite2;
        Composite3 = composite3;
        Composite4 = composite4;
        Composite5 = composite5;
        Composite6 = composite6;
        Composite7 = composite7;
        Composite8 = composite8;
	}

	public TCore Core { get; }

    public TComposite1 Composite1 { get; }
    public TComposite2 Composite2 { get; }
    public TComposite3 Composite3 { get; }
    public TComposite4 Composite4 { get; }
    public TComposite5 Composite5 { get; }
    public TComposite6 Composite6 { get; }
    public TComposite7 Composite7 { get; }
    public TComposite8 Composite8 { get; }
    
    public static implicit operator TCore(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => arg.Core;

	public static implicit operator Composition<TCore, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite5, TComposite6, TComposite7, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite5, arg.Composite6, arg.Composite7, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite6, TComposite7, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite6, arg.Composite7, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite7, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite7, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite8>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite8);
	public static implicit operator Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7>(Composition<TCore, TComposite1, TComposite2, TComposite3, TComposite4, TComposite5, TComposite6, TComposite7, TComposite8> arg) => new(arg.Core, arg.Composite1, arg.Composite2, arg.Composite3, arg.Composite4, arg.Composite5, arg.Composite6, arg.Composite7);
}
