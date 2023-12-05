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
        soundManager = GameObject.Find("Sound Manager"); //soundManager �ʱ�ȭ    
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //�׾��ٴ� ���� ȿ�� �÷���
        if (collision.gameObject.tag == "Player") {
            soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        }
    }
}
