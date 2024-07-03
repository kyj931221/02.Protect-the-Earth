using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreRecode : MonoBehaviour
{
    public Text recordText;
    public Text scoreText;

    float score;

    void Start()
    {
        score = 0;
        recordText.text = "BEST SCORE : " + PlayerPrefs.GetInt("BestScore");
        scoreText.text = "SCORE : " + PlayerPrefs.GetInt("CurrentScore");
    }


    public void Score()
    {
        GameManager.instance.BestScore();
    }
}
