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
    }
}
