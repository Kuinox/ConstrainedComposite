<h1 align="center">
	ConstrainedComposite
</h1>
<p align="center">
Constrain or Compose on the fly your .NET Types
</p>

### Constrain: A new tool for increased type safety

Constrain allow to emulate [Refinement Types](https://en.wikipedia.org/wiki/Refinement_type) in C#.  

You can ensure, that an object given to your methods has previously satisfied a condition.

Which mean, with this constraint:

```csharp
struct NotZero : IConstrainer<int>
{
    public static bool TryConstrain(int arg) => arg != 0;
}
```
We can now make a method that take a number that cannot be 0 :
```csharp
int FooBar(Constrained<int, NotZero> number) {
    return 42/number;
}

int input = GetNumber();
FooBar(input); // Type error !

var checkedInput = input.Refine<int,NotZero>();
if(checkedInput is not null)
{
    FooBar(checkedInput.Value); // Cannot be 0 !
}
```

### Composite: Create on the fly an anonymous structs.

Yes, [anonymous types exists in C#](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types).  
But it's just an `object`, you can't write code that take it as input.  

```csharp
struct PathComposite : IComposite<string, PathComposite>
{
    readonly string[] _parts;
    private PathComposite(string core) => _parts_ = core.Split('/');

    public static bool TryCompose(in string core, [MaybeNullWhen(false)] out PathComposite composite)
    {
        // check if string is a path...
        composite = new PathComposite(core);
        return true;
    }

    public string[] Parts => _core;
}

public void ReadReport(Composition<string, PathComposite> path)
{
    // We know our path, is a path.
    var parts = path.Composite1.Parts; //And we can access the composite fields.
}
}
```
This could be implemented as an extension method, but this demo:
- The fact that we can have a local state
- That we can pass these composite object by parameter.

While we could create a new struct by hand to do the composition, sometimes it's not practical.  
For example, when I'm gradualing building an object in multiples steps, in these case we would have tons of little structs for all the transitory steps, this library would allow to use anonymous composition instead of declaring a new struct.