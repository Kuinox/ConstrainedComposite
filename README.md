<h1 align="center">
	Decor
</h1>
<p align="center">
Decorate your .NET Types
</p>

### A new tool for increased type safety

Decor's decorators are fully type safe.
Applying a decorator can fail (and return null), that's a bit annoying, but allow to do something very powerful: emulating [Refinement Types](https://en.wikipedia.org/wiki/Refinement_type).

With this decorator:
```csharp
struct NotZero : IDecor<int, NotZero>
{
    public static bool TryBuild(in int arg, [MaybeNullWhen(true)] out NotZero decorator)
    {
        decorator = default;
        return arg != 0;
    }
}
```
We can now make a method that take a number that cannot be 0:
```csharp
int FooBar(Decorated<int, NotZero> number) {
    return 42/number;
}

int input = GetNumber();
FooBar(input); // Type error !

var checkedInput = input.Extend<int,NotZero>();
if(checkedInput is not null)
{
    FooBar(checkedInput.Value); // Cannot be 0 !
}
```
