using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnerScript : MonoBehaviour
{

    [SerializeField]
    GameObject alien;

    [SerializeField]
    float time = 5;
    [SerializeField]
    float timer;

    [SerializeField]
    float maxSpawn;

    [SerializeField]
    float minSpawn;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > time)
        {
            Instantiate(alien, new Vector3(Random.Range(minSpawn, maxSpawn), transform.position.y, 0), Quaternion.identity);
            timer = 0;
        }
    }
}
