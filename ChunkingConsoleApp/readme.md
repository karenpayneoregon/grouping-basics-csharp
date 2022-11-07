# About

Group via chunking where `GroupBy` is in the following extension method


**For .NET Core 5**

```csharp
public static class GenericExtensions
{

    public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize) =>
        source
            .Select((value, index) => new { Index = index, Value = value })
            .GroupBy(item => item.Index / chunkSize)
            .Select(item => item.Select(value => value.Value).ToList())
            .ToList();
}
```

**For .NET Core 6**

Licensed to the .NET Foundation under one or more agreements.
The .NET Foundation licenses this file to you under the MIT license.


```csharp
public static IEnumerable<TSource[]> Chunk<TSource>(this IEnumerable<TSource> source, int size)
{
    if (source == null)
    {
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
    }

    if (size < 1)
    {
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.size);
    }

    return ChunkIterator(source, size);
}

private static IEnumerable<TSource[]> ChunkIterator<TSource>(IEnumerable<TSource> source, int size)
{
    using IEnumerator<TSource> e = source.GetEnumerator();
    while (e.MoveNext())
    {
        TSource[] chunk = new TSource[size];
        chunk[0] = e.Current;

        int i = 1;
        for (; i < chunk.Length && e.MoveNext(); i++)
        {
            chunk[i] = e.Current;
        }

        if (i == chunk.Length)
        {
            yield return chunk;
        }
        else
        {
            Array.Resize(ref chunk, i);
            yield return chunk;
            yield break;
        }
    }
}
```