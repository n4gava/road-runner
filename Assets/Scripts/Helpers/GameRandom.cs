using System;

public static class GameRandom
{
    public static int Get(int minValue, int maxValue)
    {
        return UnityEngine.Random.Range(minValue, maxValue + 1);
    }

    public static int Get(int maxValue)
    {
        return Get(0, maxValue);
    }

    public static int Get()
    {
        return Get(int.MinValue, int.MaxValue);
    }
}
