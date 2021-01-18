using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownControl : MonoBehaviour
{
    public int countdownTime;
    public Text countdownTxt;
    public GameObject player;

    public void Start()
    {
        player.SetActive(false);
        StartCoroutine(Countstart());
    }

    public IEnumerator Countstart()
    {
        while(countdownTime>0)
        {
            countdownTxt.text = countdownTime.ToString();
      
            yield return new WaitForSeconds(1f);//1초 쉬고
            countdownTime--;
        }

        countdownTxt.text = "Go!";//타이머가 0이 되면 "go"출력

        yield return new WaitForSeconds(0.5f);//0.5초 쉬고
       
        countdownTxt.gameObject.SetActive(false);//카운트다운 텍스트 비활성화
        player.SetActive(true);
        
        
    }
}
