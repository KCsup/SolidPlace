using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasHandler : MonoBehaviour
{

    public int width, height;

    [SerializeField] private Tile tile;

    private Dictionary<Vector2, Tile> tiles;

    private void Start()
    {
        Generate();
    }

    private void Generate()
    {
        tiles = new Dictionary<Vector2, Tile>();

        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Tile newTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity, transform);
                newTile.name = $"Tile {x} {y}";
                
                tiles.Add(new Vector2(x, y), newTile);
            }
        }
    }

    public Tile GetTileAtPoint(Vector2 point)
    {
        if(tiles.TryGetValue(point, out Tile tile))
        {
            return tile;
        }

        return null;
    }

    public int GetWidth() { return width;  }

    public int GetHeight() { return height; }

}
