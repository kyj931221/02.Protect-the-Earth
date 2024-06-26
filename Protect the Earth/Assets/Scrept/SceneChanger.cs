using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GameStart()
    {
        GameManager.instance.LoadScene(1);
        Debug.Log("GameStart!!");
    }

    public void Restart()
    {
        GameManager.instance.LoadScene(0);
        Debug.Log("Game ReStart!!");
    }

    public void Exit()
    {
        GameManager.instance.Exit();
        Debug.Log("GameExit!!");
    }
}
