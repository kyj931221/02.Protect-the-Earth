using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene(1);
        Debug.Log("GameStart!!");
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Game ReStart!!");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("GameExit!!");
    }
}
