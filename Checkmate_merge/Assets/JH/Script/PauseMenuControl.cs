using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuControl : MonoBehaviour//일시정지메뉴(퍼즈메뉴)
{
    public GameObject PauseMenu;//퍼즈메뉴 스크립트를 할당할 게임 오브젝트

    public void PauseMenuFun()//퍼즈메뉴 불러오기
    {
        PauseMenu.SetActive(true);
    }
    public void OnclickRestart()//다시시작을 누르면 게임씬 불러오기
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnclickReMenu()//메뉴를 누르면 메뉴씬 불러오기
    {
        SceneManager.LoadScene("Menu");
    }
    public void OnclickOut()//게임 종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit;
#endif
    }
}
