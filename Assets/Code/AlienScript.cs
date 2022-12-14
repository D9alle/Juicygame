using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Olle
public class AlienScript : MonoBehaviour
{

    SpaceShipScript spaceShip;

    [SerializeField]
    float speed = 5;
    public GameObject deathEffect; // g?r GameObjekt vid namn deathEffect av alvin

    void Start()
    {
        spaceShip = FindObjectOfType<SpaceShipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //flytar ner ner alien
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

        //n?r alien ?r tillr?ckligt l?ngt ner s? f?rsvinner den
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //n?r alien nuddar skott s? f?rsvinner den
        if (collision.gameObject.tag == "Bullet")
        {
            spaceShip.score++;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Bomb")
        {
            spaceShip.score++;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            CameraShake.shakeTime = 1;
            Destroy(collision.gameObject);
            SceneManager.LoadScene(3); //Theo - laddar scene 3
        }

        Instantiate(deathEffect, transform.position, Quaternion.identity); // denna g?r s? vi kan ha death effect av alvin
    }
}
