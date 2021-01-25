using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public static PauseManager instance;
    public bool isPaused = false;//일시정지 중인가?
    public bool isContinued = false;
    public bool isRestarted = false;

    public GameObject puasemenuUI;//일시정지 UI

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

    //퍼즈메뉴 창 열기
    public void OpenPasemenuUI()
    {
        isPaused = true;//게임상태 pause로 변경
        Time.timeScale = 0.0f;// 모든 게임오브젝트 정지
        puasemenuUI.SetActive(true);// 퍼즈메뉴 창 실행

        if (GameManager.instance.state == GameManager.State.onDialog)
        {
            DialogManager.instance.canKeyControl = false;
        }

    }
    public void OnclickContinue()//계속하기 버튼
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        puasemenuUI.SetActive(false);

        if (GameManager.instance.state == GameManager.State.onDialog)//대화 중이라면 기물 및 점수 계속 정지
        {
            DialogManager.instance.canKeyControl = true;
            Time.timeScale = 0.0f;
        }

    }
    public void OnclickRestart()// 다시 시작
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Game");

    }
    public void OnclickMenu()//메뉴
    {
        isPaused = false;
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            OpenPasemenuUI();
        }
    }

}
