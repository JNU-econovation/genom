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
    public void OnclickContinue()//이어하기 버튼
    {
        isPaused = false;
        

        Time.timeScale = 1.0f;
        puasemenuUI.SetActive(false);

        if (GameManager.instance.state == GameManager.State.onDialog)
        {
            Time.timeScale = 0.0f;
            DialogManager.instance.canKeyControl = true;
        }
    }
    public void OnclickRestart()// 다시 시작
    {
        
        isPaused = false;
        isRestarted = true;

        Time.timeScale = 1.0f;
        puasemenuUI.SetActive(false);
        


 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            OpenPasemenuUI();
        }
    }

}
