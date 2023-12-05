using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int bestScore = 0;
    
    //[SerializeField]
    TextMeshProUGUI scoreText;
    //GameObject scoreText;

    void Awake() {
        var managerCnt = FindObjectsOfType<GameManager>();

        if (managerCnt  != null && managerCnt.Length == 1) {
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }

        score = 0;

        scoreText = GameObject.FindGameObjectWithTag("GameScore").GetComponent<TextMeshProUGUI>();

        Debug.Log(scoreText.text);
        //Debug.Log("GameManager의 Awake()가 실행되었음....");
    }

    // Update is called once per frame
    void FixedUpdate() {
        scoreText.text = "Score  : " + score.ToString();
    }

    public void SetScore() {
        score++;
         if (score > bestScore) {
            bestScore = score;
        }
    }

    public int GetScore() {
        return score;
    }

    public int GetBestScore() {
        return bestScore;
    }
}
