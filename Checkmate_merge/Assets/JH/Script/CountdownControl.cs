//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class CountdownControl : MonoBehaviour
//{
//    public static CountdownControl instance;

//    public int countdownTime;
//    public Text countdownTxt;
//    public GameObject player;

//    //싱글톤
//    public void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//        }
//        else
//        {
//            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
//            Destroy(gameObject);
//        }
//    }

//    public void Start()
//    {
//        player.SetActive(false);
//        countdownTxt.gameObject.SetActive(false);
        
//    }

//    //public void Update()
//    //{
//    //    if(GameManager.instance.state==GameManager.State.offDialog&&GameManager.instance.CanCountdown==true)
//    //    {
//    //        Debug.Log("카운트다운 코루틴");
//    //        StartCoroutine(Countstart());
//    //    }
//    //}

//    public void CountdownCoroutiine()
//    {
//        Debug.Log("카운트다운 코루틴");
//        StartCoroutine(Countstart());
//    }

//    public IEnumerator Countstart()
//    {
//        Debug.Log("카운트다운");

//        countdownTxt.gameObject.SetActive(true);

//        while(countdownTime>0)
//        {
//            countdownTxt.text = countdownTime.ToString();
      
//            yield return new WaitForSecondsRealtime(1f);//1초 쉬고
//            countdownTime--;
//        }

//        countdownTxt.text = "Go!";//타이머가 0이 되면 "go"출력

//        Time.timeScale = 1.0f;

//        yield return new WaitForSecondsRealtime(0.5f);//0.5초 쉬고
//        countdownTxt.gameObject.SetActive(false);//카운트다운 텍스트 비활성화
//        player.SetActive(true);
//        GameManager.instance.CanCountdown = false;
//        Debug.Log("카운트다운 끝/ state: " + GameManager.instance.state + "isFirstDialog: " + GameManager.instance.isFirstDialog + "canCountDown" + GameManager.instance.CanCountdown);


//    }
//}
