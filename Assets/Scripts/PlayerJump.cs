using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    GameObject soundManager;

    Rigidbody2D rb;
    float power = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("Sound Manager");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            soundManager.GetComponent<SoundManager>().SoundPlay("JUMP"); //사운드 효과
            rb.velocity = Vector2.up * power;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //SceneManager.LoadScene("Gameover");
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver() {
        yield return new WaitForSeconds(0.8f);
        //soundManager.GetComponent<SoundManager>().SoundPlay("DIE"); //사운드 효과
        SceneManager.LoadScene("Gameover");
    }
}
