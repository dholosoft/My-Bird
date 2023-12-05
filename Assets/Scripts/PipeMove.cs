using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    float speed = 1.2f;

    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
