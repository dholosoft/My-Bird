using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMakier : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //점수 초기화
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = new Vector3(0.0f, Random.Range(-1.58f, 2.43f), 0.0f);
        Destroy(newPipe, 6.5f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3.3f) {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(0.0f, Random.Range(-1.58f, 2.43f), 0.0f);
            Destroy(newPipe, 6.5f);

            timer = 0.0f;
        }
    }
}
