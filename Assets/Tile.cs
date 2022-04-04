using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public Color color;

    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start()
    {
        SetColor(new Color(255, 255, 255));
    }

    public void SetColor(Color color)
    {
        this.color = color;
        spriteRenderer.color = color;
    }

    private void OnMouseDown()
    {
        Debug.Log("E");
        SetColor(new Color(0, 0, 0));
    }

}
