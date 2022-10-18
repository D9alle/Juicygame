using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{   //Theo
    public Vector2 amplitude;
    public Vector2 frequency;
    Vector2 time = Vector2.zero;
    static bool shouldShake;
    static float shakeTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 shakePos = transform.localPosition;
        if (shakeTime > 0)
        {
            shouldShake = true;
            shakeTime = -Time.deltaTime;
        }
        else
        {
            shouldShake = false;
        }
        if (shouldShake == true)
        {
            shakePos.x = Mathf.Sin(time.x) * amplitude.x;
        }
        transform.localPosition = shakePos;
    }
}
