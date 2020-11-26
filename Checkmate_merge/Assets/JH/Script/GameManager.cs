﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isPlay = false;//플레이 중인가?
    public GameObject gameoverUI;

    static int score;//기본 점수
    public Text scoreText;

    static int enemyscore;//적 점수
    public Text enemyscore_text;

    private int lastscore;
    public Text lastscore_txt;

    //싱글톤
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        isPlay = true;
        
        score = 0;
        scoreText.text = "score : " + score.ToString();
        enemyscore = 0;
        enemyscore_text.text = "Enemy : " + enemyscore.ToString();

        StartCoroutine(AddScore());//생존점수계산 코루틴 시작
    }

    //기본 점수 계산
    private IEnumerator AddScore()
    {
        yield return new WaitForSeconds(4f);//4초 후에 점수 카운트 시작

        while (isPlay)
        {
            score++;
            scoreText.text = "score : " + score.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }

    //적 점수 계산
    public void EnemyScore(int value)
    {
        enemyscore += value;//value 만큼 적 점수 증가
        enemyscore_text.text = "Enemy: " + enemyscore.ToString();//적 점수 표시
    }


    //게임오버시 게임오버UI 활성화
    public void GameOver()
    {
        isPlay=false;//플레이가 종료되면
        StopCoroutine(AddScore());//코루틴 정지
        Time.timeScale = 0.0f;//모든 오브젝트 정지
        gameoverUI.SetActive(true); // 게임오버시 나오는 UI를 활성화시킴
        lastscore = score + enemyscore;
        lastscore_txt.text = "총 점수 : " + lastscore.ToString();
    }

  

}
