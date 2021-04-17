using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLineGenerator : MonoBehaviour
{
    public GameObject[] TilesPrefabs;
    public Vector3 Offset;
    public int TilesQty;
    public string SortingLayer;
    public float zRotation = 30;

    private Vector3 _lastPosition;
   
    void Start()
    {
        Initialize();
    }

    void Update()
    {
        
    }

    void Initialize()
    {
        _lastPosition = new Vector3(this.transform.position.x, 0, 0);

        for (int i = 0; i < TilesQty; i++)
        {
            InstantiateNextTile();
        }
        
    }

    private void InstantiateNextTile()
    {
        if (SortingLayer == SortingOrder.HOUSES)
            Debug.Log("Teste");

        _lastPosition += Offset;
        var randomIndex = GameRandom.Get(0, TilesPrefabs.Length - 1);
        
        var tile = TilesPrefabs[randomIndex];
        var tileObject = Instantiate<GameObject>(tile);
        tileObject.transform.Rotate(new Vector3(0, 0, zRotation));
        var mapTile = tileObject.GetComponent<MapTile>();
        if (mapTile != null)
            mapTile.SetSortlingLayer(SortingLayer);

        tileObject.transform.parent = this.transform;
        tileObject.transform.localPosition = _lastPosition;

    }
}
