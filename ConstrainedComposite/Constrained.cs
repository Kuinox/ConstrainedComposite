
namespace ConstrainedComposite;


public readonly struct Constrained<TConstrained,T1>
    where T1 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1> arg) => arg.Core;

}

public readonly struct Constrained<TConstrained,T1, T2>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2>(Constrained<TConstrained, T1, T2> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1>(Constrained<TConstrained, T1, T2> arg) => new(arg.Core);
}

public readonly struct Constrained<TConstrained,T1, T2, T3>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
    where T3 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2, T3> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2, T3>(Constrained<TConstrained, T1, T2, T3> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T3>(Constrained<TConstrained, T1, T2, T3> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2>(Constrained<TConstrained, T1, T2, T3> arg) => new(arg.Core);
}

public readonly struct Constrained<TConstrained,T1, T2, T3, T4>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
    where T3 : IConstrainer<TConstrained>
    where T4 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2, T3, T4> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2, T3, T4>(Constrained<TConstrained, T1, T2, T3, T4> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T3, T4>(Constrained<TConstrained, T1, T2, T3, T4> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T4>(Constrained<TConstrained, T1, T2, T3, T4> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3>(Constrained<TConstrained, T1, T2, T3, T4> arg) => new(arg.Core);
}

public readonly struct Constrained<TConstrained,T1, T2, T3, T4, T5>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
    where T3 : IConstrainer<TConstrained>
    where T4 : IConstrainer<TConstrained>
    where T5 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2, T3, T4, T5> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2, T3, T4, T5>(Constrained<TConstrained, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T3, T4, T5>(Constrained<TConstrained, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T4, T5>(Constrained<TConstrained, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T5>(Constrained<TConstrained, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4>(Constrained<TConstrained, T1, T2, T3, T4, T5> arg) => new(arg.Core);
}

public readonly struct Constrained<TConstrained,T1, T2, T3, T4, T5, T6>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
    where T3 : IConstrainer<TConstrained>
    where T4 : IConstrainer<TConstrained>
    where T5 : IConstrainer<TConstrained>
    where T6 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2, T3, T4, T5, T6>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T3, T4, T5, T6>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T4, T5, T6>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T5, T6>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T6>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T5>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
}

public readonly struct Constrained<TConstrained,T1, T2, T3, T4, T5, T6, T7>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
    where T3 : IConstrainer<TConstrained>
    where T4 : IConstrainer<TConstrained>
    where T5 : IConstrainer<TConstrained>
    where T6 : IConstrainer<TConstrained>
    where T7 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2, T3, T4, T5, T6, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T3, T4, T5, T6, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T4, T5, T6, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T5, T6, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T6, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T5, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T5, T6>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
}

public readonly struct Constrained<TConstrained,T1, T2, T3, T4, T5, T6, T7, T8>
    where T1 : IConstrainer<TConstrained>
    where T2 : IConstrainer<TConstrained>
    where T3 : IConstrainer<TConstrained>
    where T4 : IConstrainer<TConstrained>
    where T5 : IConstrainer<TConstrained>
    where T6 : IConstrainer<TConstrained>
    where T7 : IConstrainer<TConstrained>
    where T8 : IConstrainer<TConstrained>
	
{
	internal Constrained(TConstrained core)
	{
		Core = core;
	}

	public TConstrained Core { get; }

    public static implicit operator TConstrained(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => arg.Core;

	public static implicit operator Constrained<TConstrained, T2, T3, T4, T5, T6, T7, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T3, T4, T5, T6, T7, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T4, T5, T6, T7, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T5, T6, T7, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T6, T7, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T5, T7, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T8>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7>(Constrained<TConstrained, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
}
