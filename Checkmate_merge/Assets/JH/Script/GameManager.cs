using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//1월 25(JH)추가사항 1. 퍼즈매뉴 오류를 아직 못잡았습니다... 2. UI위치 조정 및 기타 스크립트 수정
//1월 24(MW)추가사항 1.킹 보스패턴 추가. 2.인트로 영상 완성 3.보스 죽을때 메시지 나오도록 변동 4. 대화창 이름이 검은색은 잘 안보여서 흰색으로 변동 5.메뉴로 이동시 종료되던것을 메뉴로 이동되도록 씬연결
                        //재설정 6. 빌드 설정 완료후 1차 exe빌드 완성
//1월 24(jh)추가사항 1. play하자마자 DialogStartUI나오고,카운트다운 시작,생존 점수 시작 순서로 바꿈
//1월 23(MW)추가사항 1. menu1 인트로 씬 추가 및 menu 기존씬과 연결, ui 알파값 조절
//1월 23일 추가사항 1. 대사 타이핑 효과 코루틴 수정 2.보스딜레이 타임 45초로 바꿈(영우님 요청사항) 3.DialogEnd 판넬 추가 4.DialogStartUI,DialogEndUI,각 Dialog 끝나면 2초 뒤에 적 기물과 점수 움직임 
                     //5. 모든 대사 입력 완료
//1월22일 추가사항 1. 보스도 알림마크 추가, 2.영우님이 주신 메뉴창이랑 죽을때 뜨는창 이미지 수정 및 메인화면 수정, 3. 글자 폰트 바꾸기, 4. 주희님 폴더에 sprite->대화창 폴더에 쓰실 이미지들 미리 추가해뒀습니다.
public class GameManager : MonoBehaviour
{
    float delayTime = 0.93023255813953488372093023255812f;
    public static GameManager instance;

    private bool isPlay = false;//플레이 중인가?
    public bool isContinued = false;//이어하기 버튼을 눌렀는가?
    public GameObject gameoverUI;//게임오버 UI
    public GameObject gameoverDie;//죽었을때
    public GameObject gameoverWin;// 게임완료시


    public static int score;//기본 점수
    public Text scoreText;
    private static int enemyscore;//적 점수
    private static int deathCounter=0;//데스카운텉
    public Text enemyscore_text;
    public Text deathCounter_text;
    private int lastscore;//총 점수
    public Text lastscore_txt;
    private static int lastDeathCount = 0;//데스카운텉
    public Text lastDeathCount_text;

    public enum State { onDialog,offDialog,onCounDown };
    public State state;

    [SerializeField] private Dialog dialog1;
    [SerializeField] private Dialog dialog2;
    [SerializeField] private Dialog dialog3;
    [SerializeField] private Dialog dialog4;
    [SerializeField] private Dialog dialog5;
    [SerializeField] private Dialog dialog6;

    [SerializeField] private Dialog ponEndDialog;
    [SerializeField] private Dialog bishopEndDialog;
    [SerializeField] private Dialog knightEndDialog;
    [SerializeField] private Dialog rockEndDialog;
    [SerializeField] private Dialog queenEndDialog;
    [SerializeField] private Dialog kingEndDialog;

    public int countdownTime;
    public Text countdownTxt;
    public GameObject player;

    public bool isFirstDialog = false;
    public bool CanCountdown = false;
   
    
    bool isPonBossDialog = false;
    bool isBishpBossDialog = false;
    bool isKnightBossDialog = false;
    bool isRockBossDialog = false;
    bool isQueenBossDialog = false;
    bool isKingBossDialog = false;

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
        Screen.SetResolution(1280, 720, true);
        player.SetActive(false);

        isFirstDialog = true; 
        isPlay = true;
        state = State.offDialog;
       

        score = 0;
        scoreText.text = "score : " + score.ToString();
        enemyscore = 0;
        enemyscore_text.text = "Enemy : " + enemyscore.ToString();
    
        //StartCoroutine(AddScore());//생존점수계산 코루틴 시작
      
    }

    public void Update()
    {
        //if(PauseManager.instance.isRestarted==true)
        //{
        //    state = State.onCounDown;
        //    CanCountdown = true;
        //    StartCoroutine(Countstart());
        //}
        if (state == State.offDialog && isFirstDialog == true)//StartUI 시작
        {
            
            
            state = State.onDialog;
            FindObjectOfType<DialogManager>().FirstDialog();

        }

        if (state == State.offDialog && CanCountdown == true)//카운트 다운 시작
        {
            Debug.Log("카운트");
            state = State.onCounDown;
            StartCoroutine(Countstart());
            
            
        }

        if (score == 50 && state == State.offDialog && isPonBossDialog == false)//폰
        {
            isPonBossDialog = true;
            state = State.onDialog;
            StartCoroutine(Dialog(dialog1));

            }
        if (score == 150 && state == State.offDialog && isBishpBossDialog == false)//비숍
        {
            isBishpBossDialog = true;
            state = State.onDialog;
                StartCoroutine(Dialog(dialog2));
            }

        if (score == 500 && state == State.offDialog && isKnightBossDialog == false)//룩
        {
            isKnightBossDialog = true;
            state = State.onDialog;
                StartCoroutine(Dialog(dialog4));
            }

        if (score == 300 && state == State.offDialog && isRockBossDialog == false)//나이트
        {
            isRockBossDialog = true;
            state = State.onDialog;
            StartCoroutine(Dialog(dialog3));
        }
        if (score == 750 && state == State.offDialog && isQueenBossDialog == false)//퀸
        {
            isQueenBossDialog = true;
            state = State.onDialog;
                StartCoroutine(Dialog(dialog5));
            }
        if (score == 1000 && state == State.offDialog && isKingBossDialog == false)//킹
        {
            isKingBossDialog = true;
            state = State.onDialog;
                StartCoroutine(Dialog(dialog6));
            }
  
    }
    
    //대화 
    public IEnumerator Dialog(Dialog dialog)
    {

        Time.timeScale = 0.0f;
        FindObjectOfType<DialogManager>().ShowDialog(dialog);

        yield return null;

    }
    public void PonBossDialog()  // 폰보스 엔딩 다이얼로그 출력함수
    {

        if (state == State.offDialog)
        {
            Debug.Log("폰대화시작");

            state = State.onDialog;
            StartCoroutine(Dialog(ponEndDialog));

            //Debug.Log("isCanDialog: " + EnemySpawner.instance.isPonDialog);
        }

    }
    public void BishopBossDialog()  // 비숍 엔딩 다이얼로그 출력함수
    {

        if (state == State.offDialog)
        {
            Debug.Log("비숍대화시작");

            state = State.onDialog;
            StartCoroutine(Dialog(bishopEndDialog));

        }

    }

    bool KBDchecke = false;
    public void KnightBossDialog()  // 나이트 엔딩 다이얼로그 출력함수
    {

        if (state == State.offDialog && KBDchecke == false)
        {
            Debug.Log("나이트대화시작");
            KBDchecke = true;
            state = State.onDialog;
            StartCoroutine(Dialog(knightEndDialog));

        }

    }
    public void RockBossDialog()  //룩 엔딩 다이얼로그 출력함수
    {

        if (state == State.offDialog)
        {
            Debug.Log("룩 대화시작");

            state = State.onDialog;
            StartCoroutine(Dialog(rockEndDialog));

        }

    }
    public void QueenBossDialog()  // 퀸 엔딩 다이얼로그 출력함수
    {

        if (state == State.offDialog)
        {
            Debug.Log("퀸 대화시작");

            state = State.onDialog;
            StartCoroutine(Dialog(queenEndDialog));

        }

    }
    public void KingBossDialog()  // 킹 엔딩 다이얼로그 출력함수
    {

        if (state == State.offDialog)
        {
            Debug.Log("킹 대화시작");

            state = State.onDialog;
            StartCoroutine(Dialog(kingEndDialog));

        }

    }


    //카운트 다운
    public IEnumerator Countstart()
    {
        if(state==State.onCounDown)
        {
            Debug.Log("카운트다운");

            countdownTxt.gameObject.SetActive(true);


            while (countdownTime > 0)
            {
                countdownTxt.text = countdownTime.ToString();

                yield return new WaitForSecondsRealtime(1f);//1초 쉬고
                countdownTime--;
                Debug.Log("count: " + countdownTime);

            }

            countdownTxt.text = "Go!";//타이머가 0이 되면 "go"출력

            Time.timeScale = 1.0f;

            yield return new WaitForSecondsRealtime(0.5f);//0.5초 쉬고
            countdownTxt.gameObject.SetActive(false);//카운트다운 텍스트 비활성화
            player.SetActive(true);

            state = State.offDialog;
            CanCountdown = false;
            Debug.Log("카운트다운 끝");

            StartCoroutine(AddScore());
        }
        
            


    }
    //생존 점수 계산
    public IEnumerator AddScore()
    {
        //yield return new WaitForSeconds(delayTime * 4f);//4초 후에 점수 카운트 시작

        while (isPlay)
        {
                score++;
                scoreText.text = "score : " + score.ToString();
                yield return new WaitForSeconds(delayTime * 1f);
                Debug.Log("생존점수 증가");

        }
        // isPlay false시 공회전 코루틴 시작
        if (!isPlay)
        {
                StartCoroutine(WaitAddScore());
        }
  

    }

    //적 점수 계산
    public void EnemyScore(int value)
    {
        enemyscore += value;//value 만큼 적 점수 증가
        enemyscore_text.text = "Enemy: " + enemyscore.ToString();//적 점수 표시
    }
    public void DeathCount()
    {
        deathCounter += 1;//value 만큼 적 점수 증가
        deathCounter_text.text = "Death : " + deathCounter.ToString();//적 점수 표시
    }

    //게임오버시 게임오버UI 활성화
    public void GameOver()
    {
        isPlay = false;//플레이가 종료되면
        StopCoroutine(AddScore());//코루틴 정지
        Time.timeScale = 0.0f;//모든 오브젝트 정지
        
        gameoverUI.SetActive(true); // 게임오버시 나오는 UI를 활성화시킴
        lastscore = score + enemyscore;
        lastscore_txt.text = "총 점수 : " + lastscore.ToString();
        lastDeathCount = deathCounter;
        lastDeathCount_text.text = "죽음 : " + lastDeathCount.ToString();
    }

    public void GameWin() // 킹보스를 죽이고 승리했을시 ui변경
    {
        gameoverDie.SetActive(false);
        gameoverWin.SetActive(true);
        GameOver();
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
    
    


}
