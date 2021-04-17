using System.Collections.Generic;
using UnityEngine;

public static class SortingOrder
{
    private static Dictionary<string, int> _sortingLayer = new Dictionary<string, int>();

    public readonly static string ROAD = "Road";
    public readonly static string TOP_GRASS = "TopGrass";
    public readonly static string GRASS_OBJECTS = "GrassObjects";
    public readonly static string HOUSES = "Houses";
    public readonly static string BOTTOM_GRASS = "BottomGrass";
    public readonly static string GROUND1 = "Ground1";
    public readonly static string GROUND2 = "Ground2";
    public readonly static string GROUND3 = "Ground3";
    public readonly static string GROUND4 = "Ground4";

    public static int GetNext(string sortingLayer)
    {
        int value;

        if (_sortingLayer.TryGetValue(sortingLayer, out value))
            value++;

        if (sortingLayer == HOUSES)
            Debug.Log($"GetNext {sortingLayer}-{value}");

        _sortingLayer[sortingLayer] = value;
        return value;
    }
}
