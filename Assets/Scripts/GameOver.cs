using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    GameManager gameManager;

    [SerializeField]
    TextMeshProUGUI score;

    [SerializeField]
    TextMeshProUGUI bestScore;


    void Start() {
        gameManager = FindObjectOfType<GameManager>();

        if (gameManager == null) {
            Debug.Log("게임 매니저를 못찾았음.");
        }

        score.text = "Score : " + gameManager.GetScore().ToString();
        bestScore.text = "Best score : " + gameManager.GetBestScore().ToString();
    }

    public void Restart() {
        SceneManager.LoadScene("Play");
    }

    public void Close() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}







