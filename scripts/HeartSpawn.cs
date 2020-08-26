using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawn : MonoBehaviour
{
    public GameObject heart;
    public GameObject sound;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            Instantiate(heart, whereToSpawn, Quaternion.identity);
            Instantiate(sound, whereToSpawn, Quaternion.identity);
        }
    }
}
