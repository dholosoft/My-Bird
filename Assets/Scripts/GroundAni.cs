using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAni : MonoBehaviour
{
    float speed = 6.0f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if (transform.position.x <= -7.1) {
            transform.position = new Vector3(7.1f, transform.position.y, transform.position.z);
        }
    }
}
