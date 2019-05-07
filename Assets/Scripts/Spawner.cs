using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject ball;
    public bool isBomb;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;

    Background background;

    // Start is called before the first frame update
     void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

    void Awake()
    {
        background = GameObject.Find("Background").GetComponent<Background>();;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn < 0)
        {
            Vector3 position = transform.position;
            position.y = RandomY();
            transform.position = position;

            Instantiate(ball, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
    public float RandomY() => Random.Range(background.minY + 0.1f, background.maxY - 0.1f);
}
