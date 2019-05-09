using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
        direction.y += UnityEngine.Random.Range(-0.5f, 0.5f) > 0 ? 0.5f : -0.5f;
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ball otherBall = other.GetComponent<Ball>();

        if (isLeftTo2Right && other.name.Equals("RightWall"))
        {
            Destroy(gameObject);

        }

        if (!isLeftTo2Right && other.name.Equals("LeftWall"))
        {
            Destroy(gameObject);
        }
        if (other.name.Equals("TopWall") || other.name.Equals("BottomWall"))
        {
            direction.y *= -1;
        }
        if (other.name.StartsWith("Ball"))
        {
            if (transform.position.y <= other.transform.position.y + 0.45
                && transform.position.y >= other.transform.position.y - 0.45)
            {
                direction.x *= -1;
            } else if (transform.position.x <= other.transform.position.x + 0.45
                && transform.position.x >= other.transform.position.x - 0.45)
            {
                direction.y *= -1;

            }
            // else if (Math.Sign(otherBall.direction.y) != Math.Sign(direction.y)
            //     && Math.Sign(otherBall.direction.x) != Math.Sign(direction.x))
            // {
            //     direction.x *= -1;
            //     direction.y *= -1;
            // }
            // else if (Math.Sign(otherBall.direction.y) == Math.Sign(direction.y)
            //     && Math.Sign(otherBall.direction.x) != Math.Sign(direction.x))
            // {
            //     direction.x *= -1;
            // }
            // else if (Math.Sign(otherBall.direction.y) == Math.Sign(direction.y)
            //     && Math.Sign(otherBall.direction.x) == Math.Sign(direction.x))
            // {
            //     if (transform.position.y < other.transform.position.y)
            //     {
            //         direction.y *= -1;
            //     }
            //     // else if (otherBall.speed > speed)
            //     // {
            //     //     direction.y *= -1;
            //     // }

            // }
            // else if (Math.Sign(otherBall.direction.y) != Math.Sign(direction.y)
            //     && Math.Sign(otherBall.direction.x) == Math.Sign(direction.x))
            // {
            //     direction.x *= -1;
            // }
        }
    }
}
