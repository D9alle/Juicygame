using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Olle
public class AlienScript : MonoBehaviour
{

    SpaceShipScript spaceShip;

    [SerializeField]
    float speed = 5;
    public GameObject deathEffect; // gör GameObjekt vid namn deathEffect av alvin

    void Start()
    {
        spaceShip = FindObjectOfType<SpaceShipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //flytar ner ner alien
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

        //när alien är tillräckligt långt ner så försvinner den
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //när alien nuddar skott så försvinner den
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Bomb")
        {
            spaceShip.score++;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            CameraShake.shakeTime = 1;
            Destroy(collision.gameObject);
        }

        Instantiate(deathEffect, transform.position, Quaternion.identity); // denna gör så vi kan ha death effect av alvin
    }
}
