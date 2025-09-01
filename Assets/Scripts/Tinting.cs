using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tinting : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color newTint = Color.blue;

    void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = newTint; // Set the sprite's tint
        }
    }
}
