using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
//using UnityEditor.SearchService;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameover = false;
    public Text scoreText;
    public Text recordText;
    public GameObject gameoverUI;

    int score = 0;
    public int bestscore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("More than one game manager exists in the scene.");
            Destroy(gameObject);
        }

        bestscore = PlayerPrefs.GetInt("BestScore");
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void AddScore(int newScore)
    {
        if(!isGameover)
        {
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }

    public void BestScore()
    {
        int bestscore = PlayerPrefs.GetInt("BestScore");
        if (score > bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetInt("BestScore", bestscore);
        }
    }

    public void OnPlayerDead(int sceneId)
    {
        BestScore();
        isGameover = true;
        PlayerPrefs.SetInt("CurrentScore", score);
        SceneManager.LoadScene(sceneId);
    }

    public void LoadScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
