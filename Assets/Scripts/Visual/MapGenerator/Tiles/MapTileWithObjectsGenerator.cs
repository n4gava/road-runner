using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapTileWithObjectsGenerator : MapTile
{
    public GameObject[] Objects;
    public Vector3[] ObjectsPositions;
    public int MaxObjects = 2;
    public int MinObjects = 0;

    private void Awake()
    {
        var qtyObjects = GameRandom.Get(MinObjects, MaxObjects);

        var objectsPositions = ObjectsPositions.GetRandomValuesWithoutRepeat(qtyObjects);

        foreach (var position in objectsPositions.OrderByDescending(o => o.y))
        {
            var gameObject = Instantiate(Objects.GetRandomValues(1).First());
            gameObject.transform.parent = this.transform;
            gameObject.transform.localPosition = position;
            var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingLayerName = SortingOrder.GRASS_OBJECTS;
                spriteRenderer.sortingOrder = SortingOrder.GetNext(SortingOrder.GRASS_OBJECTS);
            }
        }
    }
}