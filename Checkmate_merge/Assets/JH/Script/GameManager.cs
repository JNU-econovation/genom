using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    float delayTime = 0.93023255813953488372093023255812f;
    public static GameManager instance;

    private bool isPlay = false;//플레이 중인가?
    public GameObject gameoverUI;//게임오버 UI
    
    public static int score;//기본 점수
    public Text scoreText;
    private static int enemyscore;//적 점수
    public Text enemyscore_text;
    private int lastscore;//총 점수
    public Text lastscore_txt;

    public enum State { onDialog,offDialog };
    public State state;

    [SerializeField] private Dialog dialog1;
    [SerializeField] private Dialog dialog2;
    [SerializeField] private Dialog dialog3;
    [SerializeField] private Dialog dialog4;
    [SerializeField] private Dialog dialog5;
    [SerializeField] private Dialog dialog6;

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

    // 초기화
    public void Start()
    {
        isPlay = true;
        state = State.offDialog;

        score = 0;
        scoreText.text = "score : " + score.ToString();
        enemyscore = 0;
        enemyscore_text.text = "Enemy : " + enemyscore.ToString();
    
        StartCoroutine(AddScore());//생존점수계산 코루틴 시작
      
    }

    public void Update()
    {/*
        
        if (score == 100 && state == State.offDialog)
            {
                state = State.onDialog;
                
                FindObjectOfType<DialogManager>().FirstDialog();

            }
        if (score == 120 && state == State.offDialog)//폰
            {
                state = State.onDialog;
                StartCoroutine(Dialog(dialog1));

            }
        if (score == 150 && state == State.offDialog)//비숍
            {
                state = State.onDialog;
                StartCoroutine(Dialog(dialog2));
            }
        if (score == 300 && state == State.offDialog)//룩
            {
                state = State.onDialog;
                StartCoroutine(Dialog(dialog3));
            }
        if (score == 500 && state == State.offDialog)//나이트
            {
                state = State.onDialog;
                StartCoroutine(Dialog(dialog4));
            }
        if (score == 750 && state == State.offDialog)//퀸
            {
                state = State.onDialog;
                StartCoroutine(Dialog(dialog5));
            }
        if (score == 1000 && state == State.offDialog)//킹
            {
                state = State.onDialog;
                StartCoroutine(Dialog(dialog6));
            }
      */
    }
    
    //대화 
    public IEnumerator Dialog(Dialog dialog)
    {

        Time.timeScale = 0.0f;
        FindObjectOfType<DialogManager>().ShowDialog(dialog);

        yield return null;

    }

    //생존 점수 계산
    public IEnumerator AddScore()
    {
        yield return new WaitForSeconds(delayTime * 4f);//4초 후에 점수 카운트 시작

        while (isPlay)
        {

            score++;
            scoreText.text = "score : " + score.ToString();
            yield return new WaitForSeconds(delayTime * 0.5f);

        }
        // isPlay false시 공회전 코루틴 시작
        if (!isPlay)
        {
            StartCoroutine(WaitAddScore());
        }


    }
    //MW 추가내역, 보스전투시 점수 공회전 코루틴
    public IEnumerator WaitAddScore()
    {
        yield return new WaitForSeconds(delayTime*0.25f);
        StartCoroutine(AddScore());
    }

    //isplay 상태 변환 함수
    public void ChangePlayState()
    {
        if (isPlay)
        {
            isPlay = false;
        }

        else if (!isPlay)
        {

            isPlay = true;
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
