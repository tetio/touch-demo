using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        float width = transform.localScale.x * spriteRenderer.sprite.bounds.size.x;
        Debug.Log("Width = " + width);
        Debug.Log("spriteRenderer.sprite.bounds.size = " + spriteRenderer.sprite.bounds.size);

        minX = spriteRenderer.sprite.bounds.min.x;
        maxX = spriteRenderer.sprite.bounds.max.x;
        minY = spriteRenderer.sprite.bounds.min.y;
        maxY = spriteRenderer.sprite.bounds.max.y;
        Debug.Log("max x = " + maxX);
        Debug.Log("min x = " + minX);

        Debug.Log("max y = " + maxY);
        Debug.Log("min y = " + minY);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
