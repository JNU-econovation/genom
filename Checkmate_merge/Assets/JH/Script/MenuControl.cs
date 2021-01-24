using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour//메인 메뉴
{
    public void OnclickStart()//start버튼을 누르면 게임 시작
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }
    public void OnclickStartImortal()//이모탈 버튼을 누르면 무적 시작
    {
        StartCoroutine(wait());

    }
    public void OnclickStartIntro()//인트로 -> 메뉴
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game_Immortal");
        Time.timeScale = 1.0f;


    }
    public void OnclickQuitBtn()//게임종료 버튼을 누르면 게임 종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
