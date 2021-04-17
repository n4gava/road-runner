using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTile : MonoBehaviour
{
    public void SetSortlingLayer(string sortingLayer)
    {
        var spriteRenderer = this.GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();

        spriteRenderer.SetNextOrder(sortingLayer);
    }
}