using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDemo : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
                Debug.Log("touch at x: " + touchPosition.x + " Y:" + touchPosition.y);
                Collider2D collider2D = Physics2D.OverlapPoint(touchPosition);
                if (collider2D != null)
                {
                    GameObject ball = collider2D.gameObject;
                    Destroy(ball);
                }
            }
        }
    }
}
