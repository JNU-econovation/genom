using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameover = false;
    public Text scoreText;
    public GameObject gameoverUI;

    private int score = 0;

    //싱글톤
    private void Awake()
    {
        if (instance == null)
        {
            // instance가 비어있다면(null) 그곳에 자기 자신을 할당
            instance = this;
        }
        else
        {
            // instance에 이미 다른 GameManager 오브젝트가 할당되어 있는 경우

            // 씬에 두개 이상의 GameManager 오브젝트가 존재한다는 의미.
            // 싱글톤 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }
    //점수 계산
    public void Addscore(int newScore)
    {
        if (!isGameover)//게임오버가 아니라면
        {
            score += newScore;//점수증가
            scoreText.text = "Score :" + score;
        }
    }
    //게임오버시 게임오버UI 활성화
    public void OnPlayerDead()
    {
        isGameover = true;//게임오버되면
        gameoverUI.SetActive(true); // 게임오버시 나오는 UI를 활성화시킴
    }



}
