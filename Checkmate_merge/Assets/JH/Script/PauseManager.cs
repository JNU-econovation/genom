using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;//일시정지 중인가?
    public GameObject puasemenuUI;//일시정지 UI

    //퍼즈메뉴 창 열기
    public void OpenPasemenuUI()
    {
        isPaused = true;//게임상태 pause로 변경
        Time.timeScale = 0.0f;// 모든 게임오브젝트 정지
        puasemenuUI.SetActive(true);// 퍼즈메뉴 창 실행
    }
    public void OnclickContinue()//계속하기 버튼
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        puasemenuUI.SetActive(false);
    }
    public void OnclickRestart()// 다시 시작
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Game");
    }
    public void OnclickMenu()//메뉴
    {
        SceneManager.LoadScene("Menu");
    }
    public void OnclickQuit()//종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
