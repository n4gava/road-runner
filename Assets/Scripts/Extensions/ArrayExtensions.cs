using System;
using System.Collections.Generic;
using System.Linq;

public static class ArrayExtensions
{
    public static IEnumerable<T> GetRandomValues<T>(this T[] array, int qty)
    {
        if (qty == 0)
            yield break;

        if (array == null || array.Length == 0)
            throw new Exception("O array deve possuir valores");

        for (int i = 0; i < qty; i++)
        {
            yield return array[GameRandom.Get(qty)];
        }

    }

    public static IEnumerable<T> GetRandomValuesWithoutRepeat<T>(this T[] array, int qty)
    {
        if (qty == 0)
            return Enumerable.Empty<T>();

        if (array == null || array.Length == 0)
            throw new Exception("O array deve possuir valores");

        if (qty > array.Length)
            throw new Exception("A quantidade a ser retornada deve ser igual a maior que a quantidade de itens no array quando o parametro CanRepeat for false.");

        var shuffledArray = array.Shuffle();

        return shuffledArray.Take(qty);
    }

    public static T[] Shuffle<T>(this T[] array)
    {
        if (array == null || array.Length == 0)
            throw new Exception("O array deve possuir valores");

        return array.OrderBy(x => GameRandom.Get()).ToArray();
    }
}