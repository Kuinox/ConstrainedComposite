
namespace RefinedComposite;


public readonly struct Refined<TRefined,T1>
    where T1 : IRefinement<TRefined, T1>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1> arg) => arg.Core;

}

public readonly struct Refined<TRefined,T1, T2>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2>(Refined<TRefined, T1, T2> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1>(Refined<TRefined, T1, T2> arg) => new(arg.Core);
}

public readonly struct Refined<TRefined,T1, T2, T3>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
    where T3 : IRefinement<TRefined, T3>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2, T3> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2, T3>(Refined<TRefined, T1, T2, T3> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T3>(Refined<TRefined, T1, T2, T3> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2>(Refined<TRefined, T1, T2, T3> arg) => new(arg.Core);
}

public readonly struct Refined<TRefined,T1, T2, T3, T4>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
    where T3 : IRefinement<TRefined, T3>
    where T4 : IRefinement<TRefined, T4>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2, T3, T4> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2, T3, T4>(Refined<TRefined, T1, T2, T3, T4> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T3, T4>(Refined<TRefined, T1, T2, T3, T4> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T4>(Refined<TRefined, T1, T2, T3, T4> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3>(Refined<TRefined, T1, T2, T3, T4> arg) => new(arg.Core);
}

public readonly struct Refined<TRefined,T1, T2, T3, T4, T5>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
    where T3 : IRefinement<TRefined, T3>
    where T4 : IRefinement<TRefined, T4>
    where T5 : IRefinement<TRefined, T5>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2, T3, T4, T5> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2, T3, T4, T5>(Refined<TRefined, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T3, T4, T5>(Refined<TRefined, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T4, T5>(Refined<TRefined, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T5>(Refined<TRefined, T1, T2, T3, T4, T5> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4>(Refined<TRefined, T1, T2, T3, T4, T5> arg) => new(arg.Core);
}

public readonly struct Refined<TRefined,T1, T2, T3, T4, T5, T6>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
    where T3 : IRefinement<TRefined, T3>
    where T4 : IRefinement<TRefined, T4>
    where T5 : IRefinement<TRefined, T5>
    where T6 : IRefinement<TRefined, T6>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2, T3, T4, T5, T6>(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T3, T4, T5, T6>(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T4, T5, T6>(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T5, T6>(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T6>(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T5>(Refined<TRefined, T1, T2, T3, T4, T5, T6> arg) => new(arg.Core);
}

public readonly struct Refined<TRefined,T1, T2, T3, T4, T5, T6, T7>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
    where T3 : IRefinement<TRefined, T3>
    where T4 : IRefinement<TRefined, T4>
    where T5 : IRefinement<TRefined, T5>
    where T6 : IRefinement<TRefined, T6>
    where T7 : IRefinement<TRefined, T7>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2, T3, T4, T5, T6, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T3, T4, T5, T6, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T4, T5, T6, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T5, T6, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T6, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T5, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T5, T6>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7> arg) => new(arg.Core);
}

public readonly struct Refined<TRefined,T1, T2, T3, T4, T5, T6, T7, T8>
    where T1 : IRefinement<TRefined, T1>
    where T2 : IRefinement<TRefined, T2>
    where T3 : IRefinement<TRefined, T3>
    where T4 : IRefinement<TRefined, T4>
    where T5 : IRefinement<TRefined, T5>
    where T6 : IRefinement<TRefined, T6>
    where T7 : IRefinement<TRefined, T7>
    where T8 : IRefinement<TRefined, T8>
	
{
	internal Refined(TRefined core)
	{
		Core = core;
	}

	public TRefined Core { get; }

    public static implicit operator TRefined(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => arg.Core;

	public static implicit operator Refined<TRefined, T2, T3, T4, T5, T6, T7, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T3, T4, T5, T6, T7, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T4, T5, T6, T7, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T5, T6, T7, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T6, T7, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T5, T7, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T5, T6, T8>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
	public static implicit operator Refined<TRefined, T1, T2, T3, T4, T5, T6, T7>(Refined<TRefined, T1, T2, T3, T4, T5, T6, T7, T8> arg) => new(arg.Core);
}
