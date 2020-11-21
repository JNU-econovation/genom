using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isPlay = false;//플레이 중인가?
    public GameObject gameoverUI;
    public Text scoreText;
    private float score=0.0f;

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

    public void StartGame()
    {
        isPlay = true;
        StartCoroutine(AddScore());//점수계산 코루틴 시작
    }

    //점수 계산
    IEnumerator AddScore()
    {
        while (isPlay == true)//플레이 중일때만 실행
        {
            score++;
            scoreText.text = "점수 : "+ score.ToString();
            yield return new WaitForSeconds(0.5f);//0.5초마다 증가
        }

    }


    //게임오버시 게임오버UI 활성화
    public void OnPlayerDead()
    {
        isPlay=false;//플레이가 종료되면
        StopCoroutine(AddScore());//코루틴 정지
        gameoverUI.SetActive(true); // 게임오버시 나오는 UI를 활성화시킴
    }

}
