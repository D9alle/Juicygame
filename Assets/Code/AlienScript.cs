using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Olle
public class AlienScript : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    // Update is called once per frame
    void Update()
    {
        //flytar ner ner alien
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

        //n�r alien �r tillr�ckligt l�ngt ner s� f�rsvinner den
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //n�r alien nuddar skott s� f�rsvinner den
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
