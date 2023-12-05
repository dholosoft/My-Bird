using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Collidition : MonoBehaviour
{
    GameObject soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("Sound Manager"); //soundManager 초기화    
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //죽었다는 사운드 효과 플레이
        if (collision.gameObject.tag == "Player") {
            soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        }
    }
}
