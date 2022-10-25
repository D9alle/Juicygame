using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Olle
public class SpaceShipScript : MonoBehaviour
{

    [SerializeField]
    public int speed = 5;

    int max = 15;

    int vapen = 0;

    [SerializeField]
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            vapen++;
            if (vapen > 1)
            {
                vapen = 0;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (vapen == 0)
            {
                Instantiate(prefabs[0], transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(prefabs[1], transform.position, Quaternion.identity);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x > max)
        {
            transform.position = new Vector3(-max, transform.position.y, 0);
        }
        if (transform.position.x < -max)
        {
            transform.position = new Vector3(max, transform.position.y, 0);
        }
    }
}
