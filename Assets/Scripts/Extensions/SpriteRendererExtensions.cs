using UnityEngine;

public static class SpriteRendererExtensions
{
    public static void SetNextOrder(this SpriteRenderer spriteRenderer, string sortingLayer)
    {
        if (spriteRenderer != null)
        {
            var nextOrder = SortingOrder.GetNext(sortingLayer);
            spriteRenderer.sortingLayerName = sortingLayer;
            spriteRenderer.sortingOrder = nextOrder;
        }
    }
}
