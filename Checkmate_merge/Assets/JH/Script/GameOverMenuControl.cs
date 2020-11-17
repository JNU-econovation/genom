using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverMenuControl : MonoBehaviour
{
    public void OnclickRestart()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnclickRetrunToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
