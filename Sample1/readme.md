# About

Simple example for checking if there are duplicate elements in a string array, case sensitive.

**Array**

```csharp
string[] lines = {
    "This is a test",
    "This is a apple",
    "This is a orange",
    "This is a grape",
    "This is a test",
    "This is a orange",
    "This is a test"
};
```

A language extension is used to see if there are duplicates

```csharp
/// <summary>
/// Determine if there are duplicates in source
/// </summary>
/// <typeparam name="T">inferred type</typeparam>
/// <param name="source">IEnumerable</param>
/// <returns>true if duplicates, false no duplicates</returns>
/// <remarks>
/// Alternate
/// if(source.Count != source.Distinct().Count())
/// </remarks>
public static bool ContainsDuplicates<T>(this IEnumerable<T> source)
{
    var knownKeys = new HashSet<T>();
    return source.Any(item => !knownKeys.Add(item));
}
```

**Test**

```csharp
if (lines.ContainsDuplicates())
```

