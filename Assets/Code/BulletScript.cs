using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Olle
public class BulletScript : MonoBehaviour
{
    [SerializeField]
    float speed = 6;

    float deathTimer;
    float deathTime = 5;

    // Update is called once per frame
    void Update()
    {
        //flyttar upp skottet
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);

        deathTimer += Time.deltaTime;
        if (deathTimer > deathTime)
        {
            Destroy(gameObject);
        }
    }
}
