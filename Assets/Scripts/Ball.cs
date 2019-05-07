using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    public bool isLeftTo2Right;

    private Vector2 direction;


    public void Start()
    {
        if (isLeftTo2Right)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.left;
        }
        direction.y += Random.Range(-0.5f, 0.5f) > 0? 0.5f:-0.5f;
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isLeftTo2Right && other.name.Equals("RightWall"))
        {
            Destroy(gameObject);

        }
        if (!isLeftTo2Right && other.name.Equals("LeftWall"))
        {
            Destroy(gameObject);
        }
        if (other.name.Equals("TopWall") || other.name.Equals("BottomWall") || other.name.StartsWith("Ball"))
        {
            direction.y *= -1;

        }
    }
}
