# LinqApplyIf
LINQ extension methods for applying transformations conditionally on enumerations, queryables, and async-enumerations.

## Samples

ApplyIf:

```csharp
var elements = new[] { 1, 2, 3, 4, 5 };
var alteredElements = elements.ApplyIf(true, xs => xs.Select(x => x + 1));
```

```csharp
var elements = new[] { 1, 2, 3, 4, 5 };
var alteredElements = elements.ApplyIf(() => true, xs => xs.Select(x => x + 1));
```

ApplyIfElse:

```csharp
var elements = new[] { 1, 2, 3, 4, 5 };
var alteredElements = elements.ApplyIfElse(true, 
    xs => xs.Select(x => x + 1),
    xs => xs.Select(x => x - 1));
```

```csharp
var elements = new[] { 1, 2, 3, 4, 5 };
var alteredElements = elements.ApplyIfElse(() => true, 
    xs => xs.Select(x => x + 1),
    xs => xs.Select(x => x - 1));
```
