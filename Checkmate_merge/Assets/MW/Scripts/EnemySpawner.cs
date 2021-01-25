using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public AudioClip nomalRound;
    public AudioClip bossRound;
    public AudioSource backAudio;


    public static EnemySpawner instance;
    [SerializeField] private Dialog ponEndDialog;
    [SerializeField] private Dialog bishopEndDialog;
    [SerializeField] private Dialog knightEndDialog;
    [SerializeField] private Dialog rockEndDialog;
    [SerializeField] private Dialog queenEndDialog;
    [SerializeField] private Dialog kingEndDialog;
    public bool isPonDialog = false;
    public bool isBishopDialog = false;
    public bool isKnightDialog = false;
    public bool isrRockDialog = false;
    public bool isQueenDialog = false;
    public bool isKingDialog = false;

    Vector2 a1 = new Vector2(-3.157f, 3.501f);
    Vector2 a2 = new Vector2(-2.057f, 3.501f);
    Vector2 a3 = new Vector2(-0.957f, 3.501f);
    Vector2 a4 = new Vector2(0.143f, 3.501f);
    Vector2 a5 = new Vector2(1.243f, 3.501f);
    Vector2 a6 = new Vector2(2.343f, 3.501f);
    Vector2 a7 = new Vector2(3.443f, 3.501f);
    Vector2 a8 = new Vector2(4.543f, 3.501f);

    Vector2 b1 = new Vector2(-3.157f, 2.4f);
    Vector2 b2 = new Vector2(-2.057f, 2.4f);
    Vector2 b3 = new Vector2(-0.957f, 2.4f);
    Vector2 b4 = new Vector2(0.143f, 2.4f);
    Vector2 b5 = new Vector2(1.243f, 2.4f);
    Vector2 b6 = new Vector2(2.343f, 2.4f);
    Vector2 b7 = new Vector2(3.443f, 2.4f);
    Vector2 b8 = new Vector2(4.543f, 2.4f);

    Vector2 c1 = new Vector2(-3.157f, 1.31f);
    Vector2 c2 = new Vector2(-2.057f, 1.31f);
    Vector2 c3 = new Vector2(-0.957f, 1.31f);
    Vector2 c4 = new Vector2(0.143f, 1.31f);
    Vector2 c5 = new Vector2(1.243f, 1.31f);
    Vector2 c6 = new Vector2(2.343f, 1.31f);
    Vector2 c7 = new Vector2(3.443f, 1.31f);
    Vector2 c8 = new Vector2(4.543f, 1.31f);

    Vector2 d1 = new Vector2(-3.157f, 0.2f);
    Vector2 d2 = new Vector2(-2.057f, 0.2f);
    Vector2 d3 = new Vector2(-0.957f, 0.2f);
    Vector2 d4 = new Vector2(0.143f, 0.2f);
    Vector2 d5 = new Vector2(1.243f, 0.2f);
    Vector2 d6 = new Vector2(2.343f, 0.2f);
    Vector2 d7 = new Vector2(3.443f, 0.2f);
    Vector2 d8 = new Vector2(4.543f, 0.2f);

    Vector2 e1 = new Vector2(-3.157f, -0.897f);
    Vector2 e2 = new Vector2(-2.057f, -0.897f);
    Vector2 e3 = new Vector2(-0.957f, -0.897f);
    Vector2 e4 = new Vector2(0.143f, -0.897f);
    Vector2 e5 = new Vector2(1.243f, -0.897f);
    Vector2 e6 = new Vector2(2.343f, -0.897f);
    Vector2 e7 = new Vector2(3.443f, -0.897f);
    Vector2 e8 = new Vector2(4.543f, -0.897f);

    Vector2 f1 = new Vector2(-3.157f, -2.001f);
    Vector2 f2 = new Vector2(-2.057f, -2.001f);
    Vector2 f3 = new Vector2(-0.957f, -2.001f);
    Vector2 f4 = new Vector2(0.143f, -2.001f);
    Vector2 f5 = new Vector2(1.243f, -2.001f);
    Vector2 f6 = new Vector2(2.343f, -2.001f);
    Vector2 f7 = new Vector2(3.443f, -2.001f);
    Vector2 f8 = new Vector2(4.543f, -2.001f);

    Vector2 g1 = new Vector2(-3.157f, -3.092f);
    Vector2 g2 = new Vector2(-2.057f, -3.092f);
    Vector2 g3 = new Vector2(-0.957f, -3.092f);
    Vector2 g4 = new Vector2(0.143f, -3.092f);
    Vector2 g5 = new Vector2(1.243f, -3.092f);
    Vector2 g6 = new Vector2(2.343f, -3.092f);
    Vector2 g7 = new Vector2(3.443f, -3.092f);
    Vector2 g8 = new Vector2(4.543f, -3.092f);

    Vector2 h1 = new Vector2(-3.157f, -4.19f);
    Vector2 h2 = new Vector2(-2.057f, -4.19f);
    Vector2 h3 = new Vector2(-0.957f, -4.19f);
    Vector2 h4 = new Vector2(0.143f, -4.19f);
    Vector2 h5 = new Vector2(1.243f, -4.19f);
    Vector2 h6 = new Vector2(2.343f, -4.19f);
    Vector2 h7 = new Vector2(3.443f, -4.19f);
    Vector2 h8 = new Vector2(4.543f, -4.19f);

    public int countdownTime;
    public Text countdownTxt;

    public GameObject BossGage;

    public GameObject PlayerPos;
    public GameObject Manager;
    public GameObject ponPrefab;
    public GameObject rockPrefab;
    public GameObject bishopPrefab;
    public GameObject knightPrefab;
    public GameObject kingPrefab;
    public GameObject queenPrefab;
    public GameObject devilHand;

    Vector2 ponBossPos = new Vector2(0.71f, 2.98f);
    Vector2 devilHandPos = new Vector2(18.25f, -1.46f);
    Vector2 BossGagePos = new Vector2(18.25f, -1.46f);

    public GameObject ponBossPrefab;
    int roundNum = 0;

    bool ponBossIsSpwan = false;
    public bool endPonBoss = false;
    bool firstPonBossSpawn = false;
    bool isPonDevilFirst = true;
    bool isKnightDevilFirst = true;
    bool isRockDevilFirst = true;
    bool isBishopDevilFirst = true;
    bool isQueenDevilFirst = true;
    bool isKingDevilFirst = true;
    float delayTime = 0.93023255813953488372093023255812f * 9;
    float handDelayTime  = 0.93023255813953488372093023255812f * 5;
    float BpssdelayTime = 0.93023255813953488372093023255812f * 45;
    public bool ponBossisEnd = false;
    bool knightBossisEnd = false;
    bool bishopBossisEnd = false;
    bool queenBossisEnd = false;
    bool rockBossisEnd = false;
    bool kingBossisEnd = false;
    bool ponBfirstStop = false;
    bool knightBfirstStop = false;
    bool bishopBfirstStop = false;
    bool queenBfirstStop = false;
    bool rockBfirstStop = false;
    bool kingBfirstStop = false;


    static int ponRoundScoreRange = 51;
    static int bishopRoundScoreRange = 151;
    static int knightRoundScoreRange = 301;
    static int rockRoundScoreRange = 501;
    static int queenRoundScoreRange = 751;
    static int kingRoundScoreRange = 1001;

    //싱글톤
    private void Awake()
    {
        backAudio.clip = nomalRound;
        backAudio.Play();
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
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fisrtTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if(backAudio.clip == nomalRound)
        {
            backAudio.volume =0.5f;
        }
        if (backAudio.clip == bossRound)
        {
            backAudio.volume = 1f;
        }


        if (GameManager.score == ponRoundScoreRange && !ponBfirstStop)
        {
            backAudio.clip = bossRound;
            backAudio.Play();
            ponBfirstStop = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        }

        if (GameManager.score == knightRoundScoreRange && !knightBfirstStop)
        {
            backAudio.clip = bossRound;
            backAudio.Play();
            knightBfirstStop = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        }

        if (GameManager.score == bishopRoundScoreRange && !bishopBfirstStop)
        {
            backAudio.clip = bossRound;
            backAudio.Play();
            bishopBfirstStop = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        }

        if (GameManager.score == rockRoundScoreRange && !rockBfirstStop)
        {
            backAudio.clip = bossRound;
            backAudio.Play();
            rockBfirstStop = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        }

        if (GameManager.score == queenRoundScoreRange && !queenBfirstStop)
        {
            backAudio.clip = bossRound;
            backAudio.Play();
            queenBfirstStop = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        }

        if (GameManager.score == kingRoundScoreRange && !kingBfirstStop)
        {
            backAudio.clip = bossRound; 
            backAudio.Play();
            kingBfirstStop = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        }
    }


    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 5);
        StartCoroutine(PonRound());
    }


    IEnumerator timer(float delayTime)
    {

        yield return new WaitForSeconds(delayTime);



        if (GameManager.score >= 0 && GameManager.score < ponRoundScoreRange)
        {

            StartCoroutine(PonRound());
        }

        else if(GameManager.score >= ponRoundScoreRange && ponBossisEnd == false)
        {
            if(isPonDevilFirst)
            {
                isPonDevilFirst = false;

                StartCoroutine(ponSpqwnDevilHand());

            }
            else if (!isPonDevilFirst)
            {
                StartCoroutine(PonBossRound());
               // StartCoroutine(Countstart());
            }
        }


        else if (GameManager.score >= ponRoundScoreRange && GameManager.score < bishopRoundScoreRange)
        {

            StartCoroutine(bishopRound());
        }

        else if (GameManager.score >= bishopRoundScoreRange && bishopBossisEnd == false)
        {

            StartCoroutine(BishopBossRound());
        }

        else if(GameManager.score >= bishopRoundScoreRange && GameManager.score < knightRoundScoreRange)
        {

            StartCoroutine(KnightRound());
        }

        else if(GameManager.score >= knightRoundScoreRange && knightBossisEnd == false)
        {
            StartCoroutine(KnightBossRound());
        }


        else if(GameManager.score >= knightRoundScoreRange && GameManager.score < rockRoundScoreRange)
        {

            StartCoroutine(RockRound());
        }

        else if(GameManager.score >= rockRoundScoreRange && rockBossisEnd == false)
        {
            StartCoroutine(RockBossRound());
        }


        else if(GameManager.score >= rockRoundScoreRange && GameManager.score < queenRoundScoreRange)
        {

            StartCoroutine(QueenRound());
        }

        else if(GameManager.score >= queenRoundScoreRange && queenBossisEnd == false)
        {
            StartCoroutine(QueenBossRound());
        }



        else if (GameManager.score >= queenRoundScoreRange && GameManager.score < kingRoundScoreRange)
        {

            StartCoroutine(kingRound());
        }

        else if (GameManager.score >= kingRoundScoreRange && kingBossisEnd == false)
        {

            StartCoroutine(KingBossRound());
        }


    }
    /*
    public IEnumerator Countstart()
    {
        while (countdownTime > 0)
        {
            countdownTxt.gameObject.SetActive(true);
            countdownTxt.text = "남은 시간: " + countdownTime.ToString();

            yield return new WaitForSeconds(1f);//1초 쉬고
            countdownTime--;
        }

        countdownTxt.gameObject.SetActive(false);//카운트다운 텍스트 비활성화

    }
    */

    bool isintervel = false;
    IEnumerator interverTimer(float     delayTime)
    {
        isintervel = true;
        yield return new WaitForSeconds(delayTime/4);
        StartCoroutine(timer(delayTime));
    }

    IEnumerator ponSpqwnDevilHand()
    {

        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime);
        StartCoroutine(PonBossRound());
    }
    IEnumerator bishopSpqwnDevilHand()
    {
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(5);
        StartCoroutine(bishopRound());
    }
    IEnumerator knightSpqwnDevilHand()
    {
        Debug.Log("나이트 데빌헨드 시작");
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(5);
        StartCoroutine(KnightBossRound());
    }
    IEnumerator rockSpqwnDevilHand()
    {
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(5);
        StartCoroutine(RockBossRound());
    }
    IEnumerator queenSpqwnDevilHand()
    {
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(5);
        StartCoroutine(QueenBossRound());
    }
    IEnumerator kingSpqwnDevilHand()
    {
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(5);
        //StartCoroutine(king());
    }

    IEnumerator ponBoss()
    {
        Debug.Log("폰보스 시작");
        yield return new WaitForSeconds(BpssdelayTime);

        StartCoroutine(ponBossEnd());
    }

    bool reset = false;

    void allStopCor()
    {
        StopAllCoroutines();
        reset = true;
        StartCoroutine(ponBossEnd());
    }

    

    IEnumerator ponBossEnd()
    {
        if(reset == false)
        {
            allStopCor();
        }
        Debug.Log("폰보스 끝");

       
        GameObject.Find("PSW(Clone)").GetComponent<KingTreeAi>().endPonBoss();
        //GameObject.Find("GameManager").GetComponent<GameManager>().PonBossDialog();//폰 대사
        yield return new WaitForSeconds(handDelayTime);

        Instantiate(devilHand, devilHandPos, Quaternion.identity);//악마손
        yield return new WaitForSeconds(handDelayTime);


        ponBossisEnd = true;


        GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        backAudio.clip = nomalRound;
        backAudio.Play();
        StartCoroutine(bishopRound());
         
        
        
        yield return null;
    }

    //public IEnumerator Dialog(Dialog dialog)
    //{

    //    Time.timeScale = 0.0f;
    //    FindObjectOfType<DialogManager>().ShowDialog(dialog);

    //    yield return null;

    //}

    int randPonBossNum = 0;
    IEnumerator PonBossRound()
    {

        randPonBossNum = Random.Range(1, 15);
        switch (randPonBossNum)
        {
            case 1:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                break;
            case 2:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 3:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
            case 5:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
            case 6:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 7:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 8:
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, d3, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, d6, Quaternion.identity);
                Instantiate(ponPrefab, e3, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, e6, Quaternion.identity);
                break;
            case 9:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, d6, Quaternion.identity);
                Instantiate(ponPrefab, e3, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, c4, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, d3, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, e6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f5, Quaternion.identity);
                break;
            case 13:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 14:
                Instantiate(ponPrefab, a4, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                break;
            case 15:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, c2, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, f7, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                break;
        }
        if (firstPonBossSpawn == false)
        {
            ponBossPrefab.tag = "PSW";
            firstPonBossSpawn = true;
            Instantiate(BossGage, BossGagePos, Quaternion.identity);
            Instantiate(ponBossPrefab, ponBossPos, Quaternion.identity);
            StartCoroutine(ponBoss());
        }

        StartCoroutine(timer(delayTime));
        yield return null;


    }

    IEnumerator PonRound()
    {

        roundNum = Random.Range(1, 15);
        switch (roundNum)
        {
            case 1:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                break;
            case 2:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 3:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
            case 5:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
            case 6:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 7:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 8:
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, d3, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, d6, Quaternion.identity);
                Instantiate(ponPrefab, e3, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, e6, Quaternion.identity);
                break;
            case 9:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, d6, Quaternion.identity);
                Instantiate(ponPrefab, e3, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, c4, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, d3, Quaternion.identity);
                Instantiate(ponPrefab, d5, Quaternion.identity);
                Instantiate(ponPrefab, e4, Quaternion.identity);
                Instantiate(ponPrefab, e6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f5, Quaternion.identity);
                break;
            case 13:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);
                break;
            case 14:
                Instantiate(ponPrefab, a4, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                break;
            case 15:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, c2, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, f7, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                break;
        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }


    IEnumerator RockRound()
    {
        roundNum = Random.Range(1, 15);
        switch (roundNum)
        {
            case 1:
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h7, Quaternion.identity);
                Instantiate(rockPrefab, h8, Quaternion.identity);
                break;
            case 2:
                Instantiate(rockPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a2, Quaternion.identity);
                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a4, Quaternion.identity);
                Instantiate(rockPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a6, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                break;
            case 3:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, c1, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);
                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);
                break;
            case 5:
                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);
                Instantiate(rockPrefab, b8, Quaternion.identity);
                Instantiate(rockPrefab, g1, Quaternion.identity);
                Instantiate(knightPrefab, c1, Quaternion.identity);
                Instantiate(knightPrefab, d8, Quaternion.identity);
                Instantiate(knightPrefab, e1, Quaternion.identity);
                Instantiate(knightPrefab, f8, Quaternion.identity);
                break;
            case 6:
                Instantiate(ponPrefab, b1, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, c1, Quaternion.identity);
                Instantiate(bishopPrefab, e1, Quaternion.identity);
                Instantiate(bishopPrefab, f1, Quaternion.identity);
                Instantiate(rockPrefab, b8, Quaternion.identity);
                Instantiate(rockPrefab, d8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                Instantiate(rockPrefab, h8, Quaternion.identity);


                break;
            case 7:
                Instantiate(ponPrefab, b3, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b5, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);

                Instantiate(bishopPrefab, d3, Quaternion.identity);
                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, d5, Quaternion.identity);
                Instantiate(bishopPrefab, d6, Quaternion.identity);

                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f4, Quaternion.identity);
                Instantiate(knightPrefab, f5, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                Instantiate(rockPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h4, Quaternion.identity);
                Instantiate(rockPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);
                break;
            case 8:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);

                Instantiate(knightPrefab, a8, Quaternion.identity);
                Instantiate(knightPrefab, h1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(rockPrefab, d8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                break;
            case 9:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(bishopPrefab, a5, Quaternion.identity);
                Instantiate(bishopPrefab, d1, Quaternion.identity);
                Instantiate(bishopPrefab, e8, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);


                Instantiate(rockPrefab, a6, Quaternion.identity);
                Instantiate(rockPrefab, b1, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(rockPrefab, g8, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, b1, Quaternion.identity);
                Instantiate(bishopPrefab, b3, Quaternion.identity);
                Instantiate(bishopPrefab, b5, Quaternion.identity);
                Instantiate(bishopPrefab, b7, Quaternion.identity);

                Instantiate(rockPrefab, d4, Quaternion.identity);
                Instantiate(rockPrefab, d5, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, f2, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);


                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);

                Instantiate(rockPrefab, b2, Quaternion.identity);
                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, f6, Quaternion.identity);
                Instantiate(rockPrefab, g7, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);

                Instantiate(bishopPrefab, a3, Quaternion.identity);
                Instantiate(bishopPrefab, a5, Quaternion.identity);
                Instantiate(bishopPrefab, a7, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);
                Instantiate(bishopPrefab, h6, Quaternion.identity);

                Instantiate(rockPrefab, d4, Quaternion.identity);
                Instantiate(rockPrefab, e5, Quaternion.identity);
                break;
            case 13:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(rockPrefab, c4, Quaternion.identity);
                Instantiate(rockPrefab, c7, Quaternion.identity);
                Instantiate(rockPrefab, f2, Quaternion.identity);
                Instantiate(rockPrefab, f5, Quaternion.identity);
                break;
            case 14:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a6, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);


                Instantiate(rockPrefab, a4, Quaternion.identity);
                Instantiate(rockPrefab, a5, Quaternion.identity);
                Instantiate(rockPrefab, d1, Quaternion.identity);
                Instantiate(rockPrefab, e1, Quaternion.identity);
                Instantiate(rockPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h8, Quaternion.identity);
                Instantiate(rockPrefab, c8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                break;
            case 15:
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);

                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);

                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);

                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, c6, Quaternion.identity);
                break;
        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }

    int RockBossRange = 0;
    int RBcounter = 0;
    public GameObject RBU;
    public GameObject RBD;
    public GameObject RBL;
    public GameObject RBR;
    public GameObject RBover;
    Vector2 endRBPos = new Vector2(1.16f, 2.76f);

    Vector2 Hor1 = new Vector2(-2.03f, -0.34f);
    Vector2 Hor2 = new Vector2(-0.92f, -0.34f);
    Vector2 Hor3 = new Vector2(0.13f, -0.34f);
    Vector2 Hor4 = new Vector2(1.24f, -0.34f);
    Vector2 Hor5 = new Vector2(2.32f, -0.34f);
    Vector2 Hor6 = new Vector2(3.46f, -0.34f);

    Vector2 Ver1 = new Vector2(0.65f, 2.4f);
    Vector2 Ver2 = new Vector2(0.65f, 1.33f);
    Vector2 Ver3 = new Vector2(0.65f, 0.22f);
    Vector2 Ver4 = new Vector2(0.65f, -0.88f);
    Vector2 Ver5 = new Vector2(0.65f, -1.98f);
    Vector2 Ver6 = new Vector2(0.65f, -3.08f);

    bool reset2 = false;

    void allStopCor2()
    {
        StopAllCoroutines();
        reset2 = true;
        StartCoroutine(RBend());
    }

    IEnumerator RBend()
    {
        if(reset2 == false)
        {
            allStopCor2();
        }
        //GameObject.Find("GameManager").GetComponent<GameManager>().RockBossDialog();//룩 대사
        rockBossisEnd = true;

        Instantiate(RBover, endRBPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime);

        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime);

        //isCanDialog = true;
        //if (GameManager.instance.state == GameManager.State.offDialog && isCanDialog == true)
        //{
        //    Debug.Log("폰대화시작");

        //    GameManager.instance.state = GameManager.State.onDialog;
        //    StartCoroutine(Dialog(ponEndDialog));
        //    yield return new WaitForSeconds(1f);
        //    isCanDialog = false;

        //    Debug.Log("isCanDialog: " + isCanDialog);
        //}
        backAudio.clip = nomalRound;
        backAudio.Play();
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        StartCoroutine(QueenRound());



    }
    IEnumerator RBRealend()
    {

        yield return new WaitForSeconds(BpssdelayTime);
        RBcounter = 10;
        StartCoroutine(RBend());

    }

    IEnumerator RBRoolout()
    {
        RockBossRange = Random.Range(1, 24);
        switch (RockBossRange)
        {
            case 1:
                Instantiate(RBU, Hor1, Quaternion.identity);
                RBcounter++;
                break;
            case 2:
                Instantiate(RBU, Hor2, Quaternion.identity);
                RBcounter++;
                break;
            case 3:
                Instantiate(RBU, Hor3, Quaternion.identity);
                RBcounter++;
                break;
            case 4:
                Instantiate(RBU, Hor4, Quaternion.identity);
                RBcounter++;
                break;
            case 5:
                Instantiate(RBU, Hor5, Quaternion.identity);
                RBcounter++;
                break;
            case 6:
                Instantiate(RBU, Hor6, Quaternion.identity);
                RBcounter++;
                break;
            case 7:
                Instantiate(RBD, Hor1, Quaternion.identity);
                RBcounter++;
                break;
            case 8:
                Instantiate(RBD, Hor2, Quaternion.identity);
                RBcounter++;
                break;
            case 9:
                Instantiate(RBD, Hor3, Quaternion.identity);
                RBcounter++;
                break;
            case 10:
                Instantiate(RBD, Hor4, Quaternion.identity);
                RBcounter++;
                break;
            case 11:
                Instantiate(RBD, Hor5, Quaternion.identity);
                RBcounter++;
                break;
            case 12:
                Instantiate(RBD, Hor6, Quaternion.identity);
                RBcounter++;
                break;
            case 13:
                Instantiate(RBL, Ver1, Quaternion.identity);
                RBcounter++;
                break;
            case 14:
                Instantiate(RBL, Ver2, Quaternion.identity);
                RBcounter++;
                break;
            case 15:
                Instantiate(RBL, Ver3, Quaternion.identity);
                RBcounter++;
                break;
            case 16:
                Instantiate(RBL, Ver4, Quaternion.identity);
                RBcounter++;
                break;
            case 17:
                Instantiate(RBL, Ver5, Quaternion.identity);
                RBcounter++;
                break;
            case 18:
                Instantiate(RBL, Ver6, Quaternion.identity);
                RBcounter++;
                break;
            case 19:
                Instantiate(RBR, Ver1, Quaternion.identity);
                RBcounter++;
                break;
            case 20:
                Instantiate(RBR, Ver2, Quaternion.identity);
                RBcounter++;
                break;
            case 21:
                Instantiate(RBR, Ver3, Quaternion.identity);
                RBcounter++;
                break;
            case 22:
                Instantiate(RBR, Ver4, Quaternion.identity);
                RBcounter++;
                break;
            case 23:
                Instantiate(RBR, Ver5, Quaternion.identity);
                RBcounter++;
                break;
            case 24:
                Instantiate(RBR, Ver6, Quaternion.identity);
                RBcounter++;
                break;

        }
        StartCoroutine(RBRooloutTimer());
        yield return null;
    }
    IEnumerator RBRooloutTimer()
    {
        yield return new WaitForSeconds(delayTime/3);
        StartCoroutine(RBRoolout());
    }

    IEnumerator RockBossRound()
    {

        StartCoroutine(RBRealend());
        if(RBcounter == 0)
        {

            Instantiate(BossGage, BossGagePos, Quaternion.identity);
            Instantiate(devilHand, devilHandPos, Quaternion.identity);
            RBcounter++;
            yield return new WaitForSeconds(handDelayTime);
            StartCoroutine(RBRoolout());
        }




        roundNum = Random.Range(1, 15);

   

        switch (roundNum)
        {
            case 1:
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h7, Quaternion.identity);
                Instantiate(rockPrefab, h8, Quaternion.identity);
                break;
            case 2:
                Instantiate(rockPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a2, Quaternion.identity);
                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a4, Quaternion.identity);
                Instantiate(rockPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a6, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                break;
            case 3:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, c1, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);
                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);
                break;
            case 5:
                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);
                Instantiate(rockPrefab, b8, Quaternion.identity);
                Instantiate(rockPrefab, g1, Quaternion.identity);
                Instantiate(knightPrefab, c1, Quaternion.identity);
                Instantiate(knightPrefab, d8, Quaternion.identity);
                Instantiate(knightPrefab, e1, Quaternion.identity);
                Instantiate(knightPrefab, f8, Quaternion.identity);
                break;
            case 6:
                Instantiate(ponPrefab, b1, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, c1, Quaternion.identity);
                Instantiate(bishopPrefab, e1, Quaternion.identity);
                Instantiate(bishopPrefab, f1, Quaternion.identity);
                Instantiate(rockPrefab, b8, Quaternion.identity);
                Instantiate(rockPrefab, d8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                Instantiate(rockPrefab, h8, Quaternion.identity);


                break;
            case 7:
                Instantiate(ponPrefab, b3, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b5, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);

                Instantiate(bishopPrefab, d3, Quaternion.identity);
                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, d5, Quaternion.identity);
                Instantiate(bishopPrefab, d6, Quaternion.identity);

                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f4, Quaternion.identity);
                Instantiate(knightPrefab, f5, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                Instantiate(rockPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h4, Quaternion.identity);
                Instantiate(rockPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);
                break;
            case 8:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);

                Instantiate(knightPrefab, a8, Quaternion.identity);
                Instantiate(knightPrefab, h1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(rockPrefab, d8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                break;
            case 9:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(bishopPrefab, a5, Quaternion.identity);
                Instantiate(bishopPrefab, d1, Quaternion.identity);
                Instantiate(bishopPrefab, e8, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);


                Instantiate(rockPrefab, a6, Quaternion.identity);
                Instantiate(rockPrefab, b1, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(rockPrefab, g8, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, b1, Quaternion.identity);
                Instantiate(bishopPrefab, b3, Quaternion.identity);
                Instantiate(bishopPrefab, b5, Quaternion.identity);
                Instantiate(bishopPrefab, b7, Quaternion.identity);

                Instantiate(rockPrefab, d4, Quaternion.identity);
                Instantiate(rockPrefab, d5, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, f2, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);


                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);

                Instantiate(rockPrefab, b2, Quaternion.identity);
                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, f6, Quaternion.identity);
                Instantiate(rockPrefab, g7, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);

                Instantiate(bishopPrefab, a3, Quaternion.identity);
                Instantiate(bishopPrefab, a5, Quaternion.identity);
                Instantiate(bishopPrefab, a7, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);
                Instantiate(bishopPrefab, h6, Quaternion.identity);

                Instantiate(rockPrefab, d4, Quaternion.identity);
                Instantiate(rockPrefab, e5, Quaternion.identity);
                break;
            case 13:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(rockPrefab, c4, Quaternion.identity);
                Instantiate(rockPrefab, c7, Quaternion.identity);
                Instantiate(rockPrefab, f2, Quaternion.identity);
                Instantiate(rockPrefab, f5, Quaternion.identity);
                break;
            case 14:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a6, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);


                Instantiate(rockPrefab, a4, Quaternion.identity);
                Instantiate(rockPrefab, a5, Quaternion.identity);
                Instantiate(rockPrefab, d1, Quaternion.identity);
                Instantiate(rockPrefab, e1, Quaternion.identity);
                Instantiate(rockPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h8, Quaternion.identity);
                Instantiate(rockPrefab, c8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                break;
            case 15:
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);

                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);

                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);

                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, c6, Quaternion.identity);
                break;
        }
        if (RBcounter != 10)
        {
            yield return null;
            StartCoroutine(timer(delayTime));
        }



    }


    IEnumerator bishopRound()
    {

        roundNum = Random.Range(1, 13);
        switch (roundNum)
        {
            case 1:
                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, a3, Quaternion.identity);
                Instantiate(bishopPrefab, a5, Quaternion.identity);
                Instantiate(bishopPrefab, a7, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);
                Instantiate(bishopPrefab, h6, Quaternion.identity);
                Instantiate(bishopPrefab, h8, Quaternion.identity);
                break;
            case 2:
                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, b8, Quaternion.identity);
                Instantiate(bishopPrefab, c1, Quaternion.identity);
                Instantiate(bishopPrefab, d8, Quaternion.identity);
                Instantiate(bishopPrefab, e1, Quaternion.identity);
                Instantiate(bishopPrefab, f8, Quaternion.identity);
                Instantiate(bishopPrefab, g1, Quaternion.identity);
                Instantiate(bishopPrefab, h8, Quaternion.identity);
                break;
            case 3:
                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, e5, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);
                Instantiate(bishopPrefab, h8, Quaternion.identity);
                break;
            case 4:
                Instantiate(bishopPrefab, a8, Quaternion.identity);
                Instantiate(bishopPrefab, b7, Quaternion.identity);
                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, d5, Quaternion.identity);
                Instantiate(bishopPrefab, e4, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);
                Instantiate(bishopPrefab, g2, Quaternion.identity);
                Instantiate(bishopPrefab, h1, Quaternion.identity);
                break;
            case 5:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, b4, Quaternion.identity);
                Instantiate(bishopPrefab, b6, Quaternion.identity);
                Instantiate(bishopPrefab, g3, Quaternion.identity);
                Instantiate(bishopPrefab, g5, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);

                break;
            case 6:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, c7, Quaternion.identity);
                Instantiate(bishopPrefab, d2, Quaternion.identity);
                Instantiate(bishopPrefab, e7, Quaternion.identity);
                Instantiate(bishopPrefab, f2, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);

                break;
            case 7:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, c6, Quaternion.identity);
                Instantiate(ponPrefab, f3, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);

                Instantiate(bishopPrefab, d5, Quaternion.identity);
                Instantiate(bishopPrefab, e4, Quaternion.identity);

                break;
            case 8:
                Instantiate(ponPrefab, a4, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);

                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);

                break;
            case 9:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, c4, Quaternion.identity);
                Instantiate(bishopPrefab, c7, Quaternion.identity);
                Instantiate(bishopPrefab, f2, Quaternion.identity);
                Instantiate(bishopPrefab, f5, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, c2, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, f7, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);

                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h7, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, a8, Quaternion.identity);
                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, d5, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, c3, Quaternion.identity);
                Instantiate(ponPrefab, d4, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, d5, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h7, Quaternion.identity);
                break;
            case 13:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);

                Instantiate(bishopPrefab, c1, Quaternion.identity);
                Instantiate(bishopPrefab, d8, Quaternion.identity);
                Instantiate(bishopPrefab, e1, Quaternion.identity);
                Instantiate(bishopPrefab, f8, Quaternion.identity);
                break;
        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }
    bool firstBishopBossSpawn = false;
    public GameObject lightningPrefep;
    public GameObject BB;
    int bishopBosNum;
    bool reset3 = false;

    void allStopCor3()
    {
        StopAllCoroutines();
        reset3 = true;
        StartCoroutine(bishopBossEnd());
    }

    IEnumerator bishopBoss()
    {
        yield return new WaitForSeconds(BpssdelayTime);
        bishopBossisEnd = true;
        StartCoroutine(bishopBossEnd());
    }
    IEnumerator bishopBossEnd()
    {
        if (reset3 == false)
        {
            allStopCor3();
        }
        Debug.Log("비숍보스 끝");
        GameObject.Find("BBoss(Clone)").GetComponent<anglerSSun> ().endBishopBoss();
        //GameObject.Find("GameManager").GetComponent<GameManager>().BishopBossDialog();//비숍 대사
        yield return new WaitForSeconds(handDelayTime);

        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime);

        //isCanDialog = true;
        //if (GameManager.instance.state == GameManager.State.offDialog && isCanDialog == true)
        //{
        //    Debug.Log("폰대화시작");

        //    GameManager.instance.state = GameManager.State.onDialog;
        //    StartCoroutine(Dialog(ponEndDialog));
        //    yield return new WaitForSeconds(1f);
        //    isCanDialog = false;

        //    Debug.Log("isCanDialog: " + isCanDialog);
        //}
        backAudio.clip = nomalRound;
        backAudio.Play();
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        StartCoroutine(KnightRound());
        yield return null;
    }
    IEnumerator BishopBossRound()
    {

        bishopBosNum = Random.Range(1, 13);
        if (firstBishopBossSpawn != false)
        {
            switch (bishopBosNum)
            {
                case 1:
                    Instantiate(bishopPrefab, a1, Quaternion.identity);
                    Instantiate(bishopPrefab, a3, Quaternion.identity);
                    Instantiate(bishopPrefab, a5, Quaternion.identity);
                    Instantiate(bishopPrefab, a7, Quaternion.identity);
                    Instantiate(bishopPrefab, h2, Quaternion.identity);
                    Instantiate(bishopPrefab, h4, Quaternion.identity);
                    Instantiate(bishopPrefab, h6, Quaternion.identity);
                    Instantiate(bishopPrefab, h8, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(bishopPrefab, a1, Quaternion.identity);
                    Instantiate(bishopPrefab, b8, Quaternion.identity);
                    Instantiate(bishopPrefab, c1, Quaternion.identity);
                    Instantiate(bishopPrefab, d8, Quaternion.identity);
                    Instantiate(bishopPrefab, e1, Quaternion.identity);
                    Instantiate(bishopPrefab, f8, Quaternion.identity);
                    Instantiate(bishopPrefab, g1, Quaternion.identity);
                    Instantiate(bishopPrefab, h8, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bishopPrefab, a1, Quaternion.identity);
                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, c3, Quaternion.identity);
                    Instantiate(bishopPrefab, d4, Quaternion.identity);
                    Instantiate(bishopPrefab, e5, Quaternion.identity);
                    Instantiate(bishopPrefab, f6, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);
                    Instantiate(bishopPrefab, h8, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(bishopPrefab, a8, Quaternion.identity);
                    Instantiate(bishopPrefab, b7, Quaternion.identity);
                    Instantiate(bishopPrefab, c6, Quaternion.identity);
                    Instantiate(bishopPrefab, d5, Quaternion.identity);
                    Instantiate(bishopPrefab, e4, Quaternion.identity);
                    Instantiate(bishopPrefab, f3, Quaternion.identity);
                    Instantiate(bishopPrefab, g2, Quaternion.identity);
                    Instantiate(bishopPrefab, h1, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, a8, Quaternion.identity);
                    Instantiate(ponPrefab, h1, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, b4, Quaternion.identity);
                    Instantiate(bishopPrefab, b6, Quaternion.identity);
                    Instantiate(bishopPrefab, g3, Quaternion.identity);
                    Instantiate(bishopPrefab, g5, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);

                    break;
                case 6:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, a8, Quaternion.identity);
                    Instantiate(ponPrefab, h1, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, c7, Quaternion.identity);
                    Instantiate(bishopPrefab, d2, Quaternion.identity);
                    Instantiate(bishopPrefab, e7, Quaternion.identity);
                    Instantiate(bishopPrefab, f2, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);

                    break;
                case 7:
                    Instantiate(ponPrefab, b2, Quaternion.identity);
                    Instantiate(ponPrefab, b7, Quaternion.identity);
                    Instantiate(ponPrefab, c3, Quaternion.identity);
                    Instantiate(ponPrefab, c6, Quaternion.identity);
                    Instantiate(ponPrefab, f3, Quaternion.identity);
                    Instantiate(ponPrefab, f6, Quaternion.identity);
                    Instantiate(ponPrefab, g2, Quaternion.identity);
                    Instantiate(ponPrefab, g7, Quaternion.identity);

                    Instantiate(bishopPrefab, d5, Quaternion.identity);
                    Instantiate(bishopPrefab, e4, Quaternion.identity);

                    break;
                case 8:
                    Instantiate(ponPrefab, a4, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, d1, Quaternion.identity);
                    Instantiate(ponPrefab, d8, Quaternion.identity);
                    Instantiate(ponPrefab, e1, Quaternion.identity);
                    Instantiate(ponPrefab, e8, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h5, Quaternion.identity);

                    Instantiate(bishopPrefab, c3, Quaternion.identity);
                    Instantiate(bishopPrefab, f6, Quaternion.identity);

                    break;
                case 9:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, a7, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(bishopPrefab, c4, Quaternion.identity);
                    Instantiate(bishopPrefab, c7, Quaternion.identity);
                    Instantiate(bishopPrefab, f2, Quaternion.identity);
                    Instantiate(bishopPrefab, f5, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, b6, Quaternion.identity);
                    Instantiate(ponPrefab, c2, Quaternion.identity);
                    Instantiate(ponPrefab, c8, Quaternion.identity);
                    Instantiate(ponPrefab, f1, Quaternion.identity);
                    Instantiate(ponPrefab, f7, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);

                    Instantiate(bishopPrefab, c3, Quaternion.identity);
                    Instantiate(bishopPrefab, c6, Quaternion.identity);
                    Instantiate(bishopPrefab, f3, Quaternion.identity);
                    Instantiate(bishopPrefab, f6, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(ponPrefab, h1, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h3, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h5, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h7, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(bishopPrefab, a1, Quaternion.identity);
                    Instantiate(bishopPrefab, a8, Quaternion.identity);
                    Instantiate(bishopPrefab, d4, Quaternion.identity);
                    Instantiate(bishopPrefab, d5, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, b2, Quaternion.identity);
                    Instantiate(ponPrefab, c3, Quaternion.identity);
                    Instantiate(ponPrefab, d4, Quaternion.identity);
                    Instantiate(ponPrefab, e5, Quaternion.identity);
                    Instantiate(ponPrefab, f6, Quaternion.identity);
                    Instantiate(ponPrefab, g7, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(bishopPrefab, d4, Quaternion.identity);
                    Instantiate(bishopPrefab, d5, Quaternion.identity);
                    Instantiate(bishopPrefab, h2, Quaternion.identity);
                    Instantiate(bishopPrefab, h7, Quaternion.identity);
                    break;
                case 13:
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, a7, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);

                    Instantiate(bishopPrefab, c1, Quaternion.identity);
                    Instantiate(bishopPrefab, d8, Quaternion.identity);
                    Instantiate(bishopPrefab, e1, Quaternion.identity);
                    Instantiate(bishopPrefab, f8, Quaternion.identity);
                    break;
            }
        }



        if (firstBishopBossSpawn == false)
        {

            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(handDelayTime);
            Instantiate(BossGage, BossGagePos, Quaternion.identity);
            firstBishopBossSpawn = true;
            StartCoroutine(bishopBoss());
            Instantiate(BB, ponBossPos, Quaternion.identity);
        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }



    bool firstqueenSpwan = false;
    void queenSetter()
    {
        StopAllCoroutines();
        StartCoroutine(QueenRound());
    }


    IEnumerator QueenRound()
    {

        roundNum = Random.Range(1, 15);
        switch (roundNum)
        {
            case 1:
                Instantiate(queenPrefab, b2, Quaternion.identity);
                Instantiate(queenPrefab, b7, Quaternion.identity);
                Instantiate(queenPrefab, g2, Quaternion.identity);
                Instantiate(queenPrefab, g7, Quaternion.identity);
                break;
            case 2:
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);
                Instantiate(bishopPrefab, h6, Quaternion.identity);

                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(rockPrefab, a5, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);

                Instantiate(queenPrefab, a1, Quaternion.identity);
                Instantiate(queenPrefab, h8, Quaternion.identity);

                break;
            case 3:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);


                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);
                break;
            case 4:
                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                Instantiate(queenPrefab, b7, Quaternion.identity);
                Instantiate(queenPrefab, g2, Quaternion.identity);
                break;
            case 5:
                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(rockPrefab, b1, Quaternion.identity);
                Instantiate(rockPrefab, g8, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);

                Instantiate(queenPrefab, d4, Quaternion.identity);
                Instantiate(queenPrefab, d5, Quaternion.identity);
                break;
            case 6:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, d8, Quaternion.identity);
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, e7, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);
                Instantiate(ponPrefab, g6, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(queenPrefab, a1, Quaternion.identity);
                Instantiate(queenPrefab, h8, Quaternion.identity);
                break;
            case 7:
                Instantiate(bishopPrefab, a3, Quaternion.identity);
                Instantiate(bishopPrefab, a5, Quaternion.identity);
                Instantiate(bishopPrefab, a7, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);
                Instantiate(bishopPrefab, h6, Quaternion.identity);

                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, f6, Quaternion.identity);

                Instantiate(queenPrefab, a1, Quaternion.identity);
                Instantiate(queenPrefab, h8, Quaternion.identity);
                break;
            case 8:
                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, b8, Quaternion.identity);
                Instantiate(knightPrefab, c1, Quaternion.identity);
                Instantiate(knightPrefab, d8, Quaternion.identity);
                Instantiate(knightPrefab, e1, Quaternion.identity);
                Instantiate(knightPrefab, f8, Quaternion.identity);
                Instantiate(knightPrefab, g1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);
                break;
            case 9:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);

                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(rockPrefab, b2, Quaternion.identity);
                Instantiate(rockPrefab, b6, Quaternion.identity);

                Instantiate(queenPrefab, a1, Quaternion.identity);
                Instantiate(queenPrefab, a8, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b5, Quaternion.identity);
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, d7, Quaternion.identity);
                Instantiate(ponPrefab, e2, Quaternion.identity);
                Instantiate(ponPrefab, e7, Quaternion.identity);
                Instantiate(ponPrefab, g4, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);


                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);


                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);
                break;
            case 11:
                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);


                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, a8, Quaternion.identity);
                Instantiate(knightPrefab, h1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(queenPrefab, c6, Quaternion.identity);
                Instantiate(queenPrefab, f3, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, c2, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, f7, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(queenPrefab, c5, Quaternion.identity);
                Instantiate(queenPrefab, f4, Quaternion.identity);
                break;
            case 13:
                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, b6, Quaternion.identity);
                Instantiate(bishopPrefab, g3, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);

                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(rockPrefab, b4, Quaternion.identity);
                Instantiate(rockPrefab, g5, Quaternion.identity);

                Instantiate(queenPrefab, a8, Quaternion.identity);
                Instantiate(queenPrefab, a1, Quaternion.identity);
                break;
            case 14:
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, b8, Quaternion.identity);
                Instantiate(ponPrefab, c7, Quaternion.identity);
                Instantiate(ponPrefab, f2, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);


                Instantiate(rockPrefab, b2, Quaternion.identity);
                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, f6, Quaternion.identity);
                Instantiate(rockPrefab, g7, Quaternion.identity);

                Instantiate(queenPrefab, b7, Quaternion.identity);
                Instantiate(queenPrefab, g2, Quaternion.identity);
                break;
            case 15:
                Instantiate(ponPrefab, d1, Quaternion.identity);
                Instantiate(ponPrefab, e8, Quaternion.identity);

                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);

                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);


                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, f6, Quaternion.identity);


                Instantiate(queenPrefab, a5, Quaternion.identity);
                Instantiate(queenPrefab, h4, Quaternion.identity);
                break;

        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }

    bool reset4 = false;

    void allStopCor4()
    {
        StopAllCoroutines();
        reset4 = true;
        StartCoroutine(queenBossEnd());
    }
    IEnumerator queenBoss()
    {

        yield return new WaitForSeconds(BpssdelayTime);
        queenBossisEnd = true;
        StartCoroutine(queenBossEnd());
    }

    IEnumerator queenBossEnd()
    {
        if(reset4 == false)
        {
            allStopCor4();
        }
        StopCoroutine(timer(delayTime));
        StopCoroutine(QueenBossRound());
        GameObject.Find("QBRed(Clone)").GetComponent<QueenTreeAi>().endQueenBoss();
        //GameObject.Find("GameManager").GetComponent<GameManager>().QueenBossDialog();//퀸 대사
        yield return new WaitForSeconds(handDelayTime);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime);

        //isCanDialog = true;
        //if (GameManager.instance.state == GameManager.State.offDialog && isCanDialog == true)
        //{
        //    Debug.Log("폰대화시작");

        //    GameManager.instance.state = GameManager.State.onDialog;
        //    StartCoroutine(Dialog(ponEndDialog));
        //    yield return new WaitForSeconds(1f);
        //    isCanDialog = false;

        //    Debug.Log("isCanDialog: " + isCanDialog);
        //}
        backAudio.clip = nomalRound;
        backAudio.Play();
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        StartCoroutine(kingRound());
        yield return null;
    }

    bool firstQueenBossSpawn = false;
    public GameObject QB;
    int QueenBosNum;



    IEnumerator QueenBossRound()
    {




        QueenBosNum = Random.Range(1, 15);
        if (firstQueenBossSpawn != false)
        {
            switch (QueenBosNum)
            {
                case 1:
                    Instantiate(queenPrefab, b2, Quaternion.identity);
                    Instantiate(queenPrefab, b7, Quaternion.identity);
                    Instantiate(queenPrefab, g2, Quaternion.identity);
                    Instantiate(queenPrefab, g7, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(bishopPrefab, h2, Quaternion.identity);
                    Instantiate(bishopPrefab, h4, Quaternion.identity);
                    Instantiate(bishopPrefab, h6, Quaternion.identity);

                    Instantiate(rockPrefab, a3, Quaternion.identity);
                    Instantiate(rockPrefab, a5, Quaternion.identity);
                    Instantiate(rockPrefab, a7, Quaternion.identity);

                    Instantiate(queenPrefab, a1, Quaternion.identity);
                    Instantiate(queenPrefab, h8, Quaternion.identity);

                    break;
                case 3:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, a7, Quaternion.identity);
                    Instantiate(ponPrefab, b8, Quaternion.identity);
                    Instantiate(ponPrefab, c1, Quaternion.identity);
                    Instantiate(ponPrefab, d8, Quaternion.identity);
                    Instantiate(ponPrefab, e1, Quaternion.identity);
                    Instantiate(ponPrefab, f8, Quaternion.identity);
                    Instantiate(ponPrefab, g1, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);


                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, c6, Quaternion.identity);
                    Instantiate(knightPrefab, d4, Quaternion.identity);
                    Instantiate(knightPrefab, e5, Quaternion.identity);
                    Instantiate(knightPrefab, f3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);

                    Instantiate(queenPrefab, b7, Quaternion.identity);
                    Instantiate(queenPrefab, g2, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, c6, Quaternion.identity);
                    Instantiate(knightPrefab, f3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);

                    Instantiate(rockPrefab, a7, Quaternion.identity);
                    Instantiate(rockPrefab, b1, Quaternion.identity);
                    Instantiate(rockPrefab, g8, Quaternion.identity);
                    Instantiate(rockPrefab, h2, Quaternion.identity);

                    Instantiate(queenPrefab, d4, Quaternion.identity);
                    Instantiate(queenPrefab, d5, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, b2, Quaternion.identity);
                    Instantiate(ponPrefab, b4, Quaternion.identity);
                    Instantiate(ponPrefab, c1, Quaternion.identity);
                    Instantiate(ponPrefab, c5, Quaternion.identity);
                    Instantiate(ponPrefab, d2, Quaternion.identity);
                    Instantiate(ponPrefab, d8, Quaternion.identity);
                    Instantiate(ponPrefab, e1, Quaternion.identity);
                    Instantiate(ponPrefab, e7, Quaternion.identity);
                    Instantiate(ponPrefab, f6, Quaternion.identity);
                    Instantiate(ponPrefab, f8, Quaternion.identity);
                    Instantiate(ponPrefab, g5, Quaternion.identity);
                    Instantiate(ponPrefab, g6, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);


                    Instantiate(queenPrefab, a1, Quaternion.identity);
                    Instantiate(queenPrefab, h8, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(bishopPrefab, a3, Quaternion.identity);
                    Instantiate(bishopPrefab, a5, Quaternion.identity);
                    Instantiate(bishopPrefab, a7, Quaternion.identity);
                    Instantiate(bishopPrefab, h2, Quaternion.identity);
                    Instantiate(bishopPrefab, h4, Quaternion.identity);
                    Instantiate(bishopPrefab, h6, Quaternion.identity);

                    Instantiate(rockPrefab, c3, Quaternion.identity);
                    Instantiate(rockPrefab, f6, Quaternion.identity);

                    Instantiate(queenPrefab, a1, Quaternion.identity);
                    Instantiate(queenPrefab, h8, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, b8, Quaternion.identity);
                    Instantiate(knightPrefab, c1, Quaternion.identity);
                    Instantiate(knightPrefab, d8, Quaternion.identity);
                    Instantiate(knightPrefab, e1, Quaternion.identity);
                    Instantiate(knightPrefab, f8, Quaternion.identity);
                    Instantiate(knightPrefab, g1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);

                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(ponPrefab, b2, Quaternion.identity);
                    Instantiate(ponPrefab, b4, Quaternion.identity);
                    Instantiate(ponPrefab, b6, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, g5, Quaternion.identity);
                    Instantiate(ponPrefab, g7, Quaternion.identity);

                    Instantiate(rockPrefab, a3, Quaternion.identity);
                    Instantiate(rockPrefab, a7, Quaternion.identity);
                    Instantiate(rockPrefab, b2, Quaternion.identity);
                    Instantiate(rockPrefab, b6, Quaternion.identity);

                    Instantiate(queenPrefab, a1, Quaternion.identity);
                    Instantiate(queenPrefab, a8, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(ponPrefab, b4, Quaternion.identity);
                    Instantiate(ponPrefab, b5, Quaternion.identity);
                    Instantiate(ponPrefab, d2, Quaternion.identity);
                    Instantiate(ponPrefab, d7, Quaternion.identity);
                    Instantiate(ponPrefab, e2, Quaternion.identity);
                    Instantiate(ponPrefab, e7, Quaternion.identity);
                    Instantiate(ponPrefab, g4, Quaternion.identity);
                    Instantiate(ponPrefab, g5, Quaternion.identity);


                    Instantiate(knightPrefab, c6, Quaternion.identity);
                    Instantiate(knightPrefab, f3, Quaternion.identity);


                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(bishopPrefab, c3, Quaternion.identity);
                    Instantiate(bishopPrefab, f6, Quaternion.identity);


                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, a8, Quaternion.identity);
                    Instantiate(knightPrefab, h1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);

                    Instantiate(queenPrefab, c6, Quaternion.identity);
                    Instantiate(queenPrefab, f3, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, b6, Quaternion.identity);
                    Instantiate(ponPrefab, c2, Quaternion.identity);
                    Instantiate(ponPrefab, c8, Quaternion.identity);
                    Instantiate(ponPrefab, f1, Quaternion.identity);
                    Instantiate(ponPrefab, f7, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);


                    Instantiate(queenPrefab, c5, Quaternion.identity);
                    Instantiate(queenPrefab, f4, Quaternion.identity);
                    break;
                case 13:
                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, b6, Quaternion.identity);
                    Instantiate(bishopPrefab, g3, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);

                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);

                    Instantiate(rockPrefab, b4, Quaternion.identity);
                    Instantiate(rockPrefab, g5, Quaternion.identity);

                    Instantiate(queenPrefab, a8, Quaternion.identity);
                    Instantiate(queenPrefab, a1, Quaternion.identity);
                    break;
                case 14:
                    Instantiate(ponPrefab, a7, Quaternion.identity);
                    Instantiate(ponPrefab, b6, Quaternion.identity);
                    Instantiate(ponPrefab, b8, Quaternion.identity);
                    Instantiate(ponPrefab, c7, Quaternion.identity);
                    Instantiate(ponPrefab, f2, Quaternion.identity);
                    Instantiate(ponPrefab, g1, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);


                    Instantiate(rockPrefab, b2, Quaternion.identity);
                    Instantiate(rockPrefab, c3, Quaternion.identity);
                    Instantiate(rockPrefab, f6, Quaternion.identity);
                    Instantiate(rockPrefab, g7, Quaternion.identity);

                    Instantiate(queenPrefab, b7, Quaternion.identity);
                    Instantiate(queenPrefab, g2, Quaternion.identity);
                    break;
                case 15:
                    Instantiate(ponPrefab, d1, Quaternion.identity);
                    Instantiate(ponPrefab, e8, Quaternion.identity);

                    Instantiate(bishopPrefab, c6, Quaternion.identity);
                    Instantiate(bishopPrefab, f3, Quaternion.identity);

                    Instantiate(knightPrefab, b2, Quaternion.identity);
                    Instantiate(knightPrefab, b7, Quaternion.identity);
                    Instantiate(knightPrefab, g2, Quaternion.identity);
                    Instantiate(knightPrefab, g7, Quaternion.identity);


                    Instantiate(rockPrefab, c3, Quaternion.identity);
                    Instantiate(rockPrefab, f6, Quaternion.identity);


                    Instantiate(queenPrefab, a5, Quaternion.identity);
                    Instantiate(queenPrefab, h4, Quaternion.identity);
                    break;
            }
        }

        if (firstQueenBossSpawn == false)
        {

            Instantiate(devilHand, devilHandPos, Quaternion.identity);
            StartCoroutine(queenBoss());
            yield return new WaitForSeconds(handDelayTime);
            ponBossPrefab.tag = "QBCanKill";
            firstQueenBossSpawn = true;
            Instantiate(BossGage, BossGagePos, Quaternion.identity);
            Instantiate(QB, a4, Quaternion.identity) ;


        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }
    IEnumerator KnightRound()
    {

        roundNum = Random.Range(1, 14);
        switch (roundNum)
        {
            case 1:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);

                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, d5, Quaternion.identity);
                Instantiate(knightPrefab, e4, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                break;
            case 2:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                break;
            case 3:
                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);

                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, a8, Quaternion.identity);
                Instantiate(knightPrefab, h1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, d3, Quaternion.identity);
                Instantiate(ponPrefab, e6, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);

                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, e5, Quaternion.identity);

                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);
                break;
            case 5:
                Instantiate(knightPrefab, c5, Quaternion.identity);
                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, d6, Quaternion.identity);
                Instantiate(knightPrefab, e3, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                Instantiate(knightPrefab, f4, Quaternion.identity);
                break;
            case 6:

                Instantiate(bishopPrefab, a7, Quaternion.identity);
                Instantiate(bishopPrefab, c1, Quaternion.identity);
                Instantiate(bishopPrefab, f8, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);

                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);
                break;
            case 7:
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);

                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, b4, Quaternion.identity);
                Instantiate(bishopPrefab, b6, Quaternion.identity);
                Instantiate(bishopPrefab, g3, Quaternion.identity);
                Instantiate(bishopPrefab, g5, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);

                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);
                break;
            case 8:
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, c2, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, f7, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);


                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);
                break;
            case 9:
                Instantiate(ponPrefab, a8, Quaternion.identity);
                Instantiate(ponPrefab, h1, Quaternion.identity);

                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, c7, Quaternion.identity);
                Instantiate(bishopPrefab, d2, Quaternion.identity);
                Instantiate(bishopPrefab, e7, Quaternion.identity);
                Instantiate(bishopPrefab, f2, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);

                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);
                break;
            case 10:
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h7, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(bishopPrefab, c3, Quaternion.identity);
                Instantiate(bishopPrefab, c6, Quaternion.identity);

                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, a8, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, a1, Quaternion.identity);
                Instantiate(ponPrefab, a2, Quaternion.identity);
                Instantiate(ponPrefab, a3, Quaternion.identity);
                Instantiate(ponPrefab, a4, Quaternion.identity);
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a6, Quaternion.identity);
                Instantiate(ponPrefab, a7, Quaternion.identity);
                Instantiate(ponPrefab, a8, Quaternion.identity);

                Instantiate(knightPrefab, h2, Quaternion.identity);
                Instantiate(knightPrefab, h4, Quaternion.identity);
                Instantiate(knightPrefab, h6, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b5, Quaternion.identity);
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, d7, Quaternion.identity);
                Instantiate(ponPrefab, e2, Quaternion.identity);
                Instantiate(ponPrefab, e7, Quaternion.identity);
                Instantiate(ponPrefab, g4, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);

                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);
                break;
            case 13:
                Instantiate(ponPrefab, a5, Quaternion.identity);
                Instantiate(ponPrefab, a6, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);

                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, b4, Quaternion.identity);
                Instantiate(bishopPrefab, g5, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);

                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);

                break;
            case 14:
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, c5, Quaternion.identity);
                Instantiate(ponPrefab, d6, Quaternion.identity);
                Instantiate(ponPrefab, e3, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);

                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                break;




        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }

    // 나이트 보스
    public GameObject KBfD;
    public GameObject KBfU;
    public GameObject KBfL;
    public GameObject KBfR;

    bool reset5= false;

    void allStopCor5()
    {
        StopAllCoroutines();
        reset5 = true;
        StartCoroutine(knightBossEnd());
    }
    IEnumerator knightBoss()
    {
        yield return new WaitForSeconds(BpssdelayTime);
        knightBossisEnd = true;
        StartCoroutine(knightBossEnd());
    }
    IEnumerator knightBossEnd()
    {
        if(reset5 == false)
        {
            allStopCor5();
        }
        StopCoroutine(timer(delayTime));
        StopCoroutine(KnightBossRound());
        GameObject.Find("KBfD(Clone)").GetComponent<KB2>().endKngitBoss();
        GameObject.Find("KBfU(Clone)").GetComponent<KB>().endKngitBoss();
        GameObject.Find("KBfR(Clone)").GetComponent<KB4>().endKngitBoss();
        GameObject.Find("KBfL(Clone)").GetComponent<KB3>().endKngitBoss();

        //GameObject.Find("GameManager").GetComponent<GameManager>().KnightBossDialog();//나이트 대사

        yield return new WaitForSeconds(handDelayTime);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime );

        //isCanDialog = true;
        //if (GameManager.instance.state == GameManager.State.offDialog && isCanDialog == true)
        //{
        //    Debug.Log("폰대화시작");

        //    GameManager.instance.state = GameManager.State.onDialog;
        //    StartCoroutine(Dialog(ponEndDialog));
        //    yield return new WaitForSeconds(1f);
        //    isCanDialog = false;

        //    Debug.Log("isCanDialog: " + isCanDialog);
        //}
        backAudio.clip = nomalRound;
        backAudio.Play();
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        StartCoroutine(RockRound());
        yield return null;
    }

    bool firstKnightBossSpawn = false;
    int KnightBosNum = 0;
    IEnumerator KnightBossRound()
    {

        KnightBosNum = Random.Range(1, 14);
        if (firstKnightBossSpawn != false)
        {
            switch (KnightBosNum)
            {
                case 1:
                    Instantiate(ponPrefab, b2, Quaternion.identity);
                    Instantiate(ponPrefab, b7, Quaternion.identity);
                    Instantiate(ponPrefab, g2, Quaternion.identity);
                    Instantiate(ponPrefab, g7, Quaternion.identity);

                    Instantiate(knightPrefab, d4, Quaternion.identity);
                    Instantiate(knightPrefab, d5, Quaternion.identity);
                    Instantiate(knightPrefab, e4, Quaternion.identity);
                    Instantiate(knightPrefab, e5, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, a7, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(knightPrefab, d4, Quaternion.identity);
                    Instantiate(knightPrefab, e5, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bishopPrefab, c3, Quaternion.identity);
                    Instantiate(bishopPrefab, c6, Quaternion.identity);
                    Instantiate(bishopPrefab, f3, Quaternion.identity);
                    Instantiate(bishopPrefab, f6, Quaternion.identity);

                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, a8, Quaternion.identity);
                    Instantiate(knightPrefab, h1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(ponPrefab, c5, Quaternion.identity);
                    Instantiate(ponPrefab, d3, Quaternion.identity);
                    Instantiate(ponPrefab, e6, Quaternion.identity);
                    Instantiate(ponPrefab, f4, Quaternion.identity);

                    Instantiate(bishopPrefab, d4, Quaternion.identity);
                    Instantiate(bishopPrefab, e5, Quaternion.identity);

                    Instantiate(knightPrefab, b2, Quaternion.identity);
                    Instantiate(knightPrefab, b7, Quaternion.identity);
                    Instantiate(knightPrefab, g2, Quaternion.identity);
                    Instantiate(knightPrefab, g7, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(knightPrefab, c5, Quaternion.identity);
                    Instantiate(knightPrefab, d4, Quaternion.identity);
                    Instantiate(knightPrefab, d6, Quaternion.identity);
                    Instantiate(knightPrefab, e3, Quaternion.identity);
                    Instantiate(knightPrefab, e5, Quaternion.identity);
                    Instantiate(knightPrefab, f4, Quaternion.identity);
                    break;
                case 6:

                    Instantiate(bishopPrefab, a7, Quaternion.identity);
                    Instantiate(bishopPrefab, c1, Quaternion.identity);
                    Instantiate(bishopPrefab, f8, Quaternion.identity);
                    Instantiate(bishopPrefab, h2, Quaternion.identity);

                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, c6, Quaternion.identity);
                    Instantiate(knightPrefab, f3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(ponPrefab, a8, Quaternion.identity);
                    Instantiate(ponPrefab, h1, Quaternion.identity);

                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, b4, Quaternion.identity);
                    Instantiate(bishopPrefab, b6, Quaternion.identity);
                    Instantiate(bishopPrefab, g3, Quaternion.identity);
                    Instantiate(bishopPrefab, g5, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);

                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, b6, Quaternion.identity);
                    Instantiate(ponPrefab, c2, Quaternion.identity);
                    Instantiate(ponPrefab, c8, Quaternion.identity);
                    Instantiate(ponPrefab, f1, Quaternion.identity);
                    Instantiate(ponPrefab, f7, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);


                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(ponPrefab, a8, Quaternion.identity);
                    Instantiate(ponPrefab, h1, Quaternion.identity);

                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, c7, Quaternion.identity);
                    Instantiate(bishopPrefab, d2, Quaternion.identity);
                    Instantiate(bishopPrefab, e7, Quaternion.identity);
                    Instantiate(bishopPrefab, f2, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);

                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(ponPrefab, h1, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h3, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h5, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h7, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(bishopPrefab, c3, Quaternion.identity);
                    Instantiate(bishopPrefab, c6, Quaternion.identity);

                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, a8, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(ponPrefab, a1, Quaternion.identity);
                    Instantiate(ponPrefab, a2, Quaternion.identity);
                    Instantiate(ponPrefab, a3, Quaternion.identity);
                    Instantiate(ponPrefab, a4, Quaternion.identity);
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, a6, Quaternion.identity);
                    Instantiate(ponPrefab, a7, Quaternion.identity);
                    Instantiate(ponPrefab, a8, Quaternion.identity);

                    Instantiate(knightPrefab, h2, Quaternion.identity);
                    Instantiate(knightPrefab, h4, Quaternion.identity);
                    Instantiate(knightPrefab, h6, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(ponPrefab, b4, Quaternion.identity);
                    Instantiate(ponPrefab, b5, Quaternion.identity);
                    Instantiate(ponPrefab, d2, Quaternion.identity);
                    Instantiate(ponPrefab, d7, Quaternion.identity);
                    Instantiate(ponPrefab, e2, Quaternion.identity);
                    Instantiate(ponPrefab, e7, Quaternion.identity);
                    Instantiate(ponPrefab, g4, Quaternion.identity);
                    Instantiate(ponPrefab, g5, Quaternion.identity);

                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, c6, Quaternion.identity);
                    Instantiate(knightPrefab, f3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);
                    break;
                case 13:
                    Instantiate(ponPrefab, a5, Quaternion.identity);
                    Instantiate(ponPrefab, a6, Quaternion.identity);
                    Instantiate(ponPrefab, h3, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);

                    Instantiate(bishopPrefab, b2, Quaternion.identity);
                    Instantiate(bishopPrefab, b4, Quaternion.identity);
                    Instantiate(bishopPrefab, g5, Quaternion.identity);
                    Instantiate(bishopPrefab, g7, Quaternion.identity);

                    Instantiate(knightPrefab, b7, Quaternion.identity);
                    Instantiate(knightPrefab, g2, Quaternion.identity);

                    break;
                case 14:
                    Instantiate(ponPrefab, b7, Quaternion.identity);
                    Instantiate(ponPrefab, c5, Quaternion.identity);
                    Instantiate(ponPrefab, d6, Quaternion.identity);
                    Instantiate(ponPrefab, e3, Quaternion.identity);
                    Instantiate(ponPrefab, f4, Quaternion.identity);
                    Instantiate(ponPrefab, g2, Quaternion.identity);

                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);

                    break;
            }
        }

        if (firstKnightBossSpawn == false)
        {


            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(handDelayTime);

            Debug.Log("최초의 나이트보스 등장");
            KBfD.tag = "KBCanKill";
            KBfU.tag = "KBCanKill";
            KBfL.tag = "KBCanKill";
            KBfR.tag = "KBCanKill";
            Instantiate(BossGage, BossGagePos, Quaternion.identity);
            Instantiate(KBfD, b3 , Quaternion.identity);
            Instantiate(KBfU, g6 , Quaternion.identity);
            Instantiate(KBfL, c7 , Quaternion.identity);
            Instantiate(KBfR, f2 , Quaternion.identity);
            firstKnightBossSpawn = true;
            StartCoroutine(knightBoss());

        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }


    // 킹 라운드

    IEnumerator kingRound()
    {

        roundNum = Random.Range(1, 14);
        switch (roundNum)
        {
            case 1:
                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, c6, Quaternion.identity);
                Instantiate(queenPrefab, f3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);

                Instantiate(kingPrefab, h1, Quaternion.identity);
                Instantiate(kingPrefab, h8, Quaternion.identity);
                break;
            case 2:
                Instantiate(ponPrefab, e1, Quaternion.identity);
                Instantiate(ponPrefab, e3, Quaternion.identity);
                Instantiate(ponPrefab, e5, Quaternion.identity);
                Instantiate(ponPrefab, e7, Quaternion.identity);
                Instantiate(ponPrefab, f2, Quaternion.identity);
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, f6, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, g1, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);


                Instantiate(kingPrefab, a1, Quaternion.identity);
                Instantiate(kingPrefab, a8, Quaternion.identity);
                break;
            case 3:
                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, d4, Quaternion.identity);
                Instantiate(knightPrefab, e5, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);

                Instantiate(queenPrefab, c6, Quaternion.identity);

                Instantiate(kingPrefab, f3, Quaternion.identity);

                break;
            case 4:
                Instantiate(bishopPrefab, d4, Quaternion.identity);
                Instantiate(bishopPrefab, e5, Quaternion.identity);

                Instantiate(knightPrefab, b3, Quaternion.identity);
                Instantiate(knightPrefab, g6, Quaternion.identity);

                Instantiate(rockPrefab, c2, Quaternion.identity);
                Instantiate(rockPrefab, c7, Quaternion.identity);
                Instantiate(rockPrefab, f2, Quaternion.identity);
                Instantiate(rockPrefab, f7, Quaternion.identity);

                Instantiate(queenPrefab, b6, Quaternion.identity);
                Instantiate(queenPrefab, g3, Quaternion.identity);

                Instantiate(kingPrefab, d5, Quaternion.identity);
                Instantiate(kingPrefab, e4, Quaternion.identity);
                break;
            case 5:
                Instantiate(ponPrefab, f4, Quaternion.identity);
                Instantiate(ponPrefab, f5, Quaternion.identity);

                Instantiate(bishopPrefab, a1, Quaternion.identity);
                Instantiate(bishopPrefab, b8, Quaternion.identity);
                Instantiate(bishopPrefab, c1, Quaternion.identity);
                Instantiate(bishopPrefab, d8, Quaternion.identity);
                Instantiate(bishopPrefab, e1, Quaternion.identity);
                Instantiate(bishopPrefab, f8, Quaternion.identity);
                Instantiate(bishopPrefab, g1, Quaternion.identity);
                Instantiate(bishopPrefab, h8, Quaternion.identity);

                Instantiate(knightPrefab, a8, Quaternion.identity);
                Instantiate(knightPrefab, b1, Quaternion.identity);
                Instantiate(knightPrefab, c8, Quaternion.identity);
                Instantiate(knightPrefab, d1, Quaternion.identity);
                Instantiate(knightPrefab, e8, Quaternion.identity);
                Instantiate(knightPrefab, f1, Quaternion.identity);
                Instantiate(knightPrefab, g8, Quaternion.identity);
                Instantiate(knightPrefab, h1, Quaternion.identity);


                Instantiate(queenPrefab, c4, Quaternion.identity);

                Instantiate(kingPrefab, d5, Quaternion.identity);

                break;
            case 6:

                Instantiate(knightPrefab, b6, Quaternion.identity);
                Instantiate(knightPrefab, g3, Quaternion.identity);

                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(rockPrefab, h6, Quaternion.identity);

                Instantiate(queenPrefab, a1, Quaternion.identity);
                Instantiate(queenPrefab, b8, Quaternion.identity);
                Instantiate(queenPrefab, g1, Quaternion.identity);
                Instantiate(queenPrefab, h8, Quaternion.identity);

                Instantiate(kingPrefab, d4, Quaternion.identity);
                Instantiate(kingPrefab, e5, Quaternion.identity);

                break;
            case 7:
                Instantiate(ponPrefab, h1, Quaternion.identity);
                Instantiate(ponPrefab, h2, Quaternion.identity);
                Instantiate(ponPrefab, h3, Quaternion.identity);
                Instantiate(ponPrefab, h4, Quaternion.identity);
                Instantiate(ponPrefab, h5, Quaternion.identity);
                Instantiate(ponPrefab, h6, Quaternion.identity);
                Instantiate(ponPrefab, h7, Quaternion.identity);
                Instantiate(ponPrefab, h8, Quaternion.identity);

                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f4, Quaternion.identity);
                Instantiate(knightPrefab, f5, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                Instantiate(queenPrefab, e2, Quaternion.identity);
                Instantiate(queenPrefab, e7, Quaternion.identity);

                Instantiate(kingPrefab, c3, Quaternion.identity);
                Instantiate(kingPrefab, c6, Quaternion.identity);

                break;
            case 8:
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, e7, Quaternion.identity);
                Instantiate(ponPrefab, g4, Quaternion.identity);

                Instantiate(bishopPrefab, d1, Quaternion.identity);
                Instantiate(bishopPrefab, e8, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);


                Instantiate(rockPrefab, b1, Quaternion.identity);
                Instantiate(rockPrefab, d4, Quaternion.identity);
                Instantiate(rockPrefab, g8, Quaternion.identity);
                Instantiate(rockPrefab, h2, Quaternion.identity);

                Instantiate(queenPrefab, c8, Quaternion.identity);
                Instantiate(queenPrefab, f1, Quaternion.identity);
                Instantiate(queenPrefab, h6, Quaternion.identity);

                Instantiate(kingPrefab, b6, Quaternion.identity);

                break;
            case 9:


                Instantiate(bishopPrefab, c6, Quaternion.identity);
                Instantiate(bishopPrefab, f3, Quaternion.identity);

                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);


                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, f6, Quaternion.identity);


                Instantiate(queenPrefab, d8, Quaternion.identity);
                Instantiate(queenPrefab, e1, Quaternion.identity);

                Instantiate(kingPrefab, d4, Quaternion.identity);
                Instantiate(kingPrefab, e5, Quaternion.identity);
                break;
            case 10:


                Instantiate(knightPrefab, a7, Quaternion.identity);
                Instantiate(knightPrefab, b6, Quaternion.identity);
                Instantiate(knightPrefab, b8, Quaternion.identity);
                Instantiate(knightPrefab, c7, Quaternion.identity);
                Instantiate(knightPrefab, f2, Quaternion.identity);
                Instantiate(knightPrefab, g1, Quaternion.identity);
                Instantiate(knightPrefab, g3, Quaternion.identity);
                Instantiate(knightPrefab, h2, Quaternion.identity);


                Instantiate(rockPrefab, b2, Quaternion.identity);
                Instantiate(rockPrefab, g7, Quaternion.identity);


                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);

                Instantiate(kingPrefab, b7, Quaternion.identity);
                Instantiate(kingPrefab, g2, Quaternion.identity);
                break;
            case 11:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b4, Quaternion.identity);
                Instantiate(ponPrefab, b6, Quaternion.identity);
                Instantiate(ponPrefab, c7, Quaternion.identity);
                Instantiate(ponPrefab, f2, Quaternion.identity);
                Instantiate(ponPrefab, g3, Quaternion.identity);
                Instantiate(ponPrefab, g5, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);

                Instantiate(bishopPrefab, c5, Quaternion.identity);
                Instantiate(bishopPrefab, f4, Quaternion.identity);

                Instantiate(knightPrefab, d2, Quaternion.identity);
                Instantiate(knightPrefab, e7, Quaternion.identity);
                Instantiate(knightPrefab, e3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);

                Instantiate(rockPrefab, c3, Quaternion.identity);
                Instantiate(rockPrefab, d6, Quaternion.identity);

                Instantiate(queenPrefab, e5, Quaternion.identity);

                Instantiate(kingPrefab, d4, Quaternion.identity);
                break;
            case 12:
                Instantiate(ponPrefab, c1, Quaternion.identity);
                Instantiate(ponPrefab, c8, Quaternion.identity);
                Instantiate(ponPrefab, f1, Quaternion.identity);
                Instantiate(ponPrefab, f8, Quaternion.identity);
                Instantiate(ponPrefab, d2, Quaternion.identity);
                Instantiate(ponPrefab, d7, Quaternion.identity);
                Instantiate(ponPrefab, e2, Quaternion.identity);
                Instantiate(ponPrefab, e7, Quaternion.identity);


                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);


                Instantiate(rockPrefab, h2, Quaternion.identity);
                Instantiate(rockPrefab, h7, Quaternion.identity);

                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);

                Instantiate(kingPrefab, d4, Quaternion.identity);
                Instantiate(kingPrefab, e5, Quaternion.identity);
                break;
            case 13:

                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, b8, Quaternion.identity);
                Instantiate(knightPrefab, c1, Quaternion.identity);
                Instantiate(knightPrefab, d8, Quaternion.identity);
                Instantiate(knightPrefab, e1, Quaternion.identity);
                Instantiate(knightPrefab, f8, Quaternion.identity);
                Instantiate(knightPrefab, g1, Quaternion.identity);
                Instantiate(knightPrefab, h8, Quaternion.identity);


                Instantiate(rockPrefab, d1, Quaternion.identity);
                Instantiate(rockPrefab, e8, Quaternion.identity);

                Instantiate(queenPrefab, c3, Quaternion.identity);
                Instantiate(queenPrefab, f6, Quaternion.identity);

                Instantiate(kingPrefab, c6, Quaternion.identity);
                Instantiate(kingPrefab, f3, Quaternion.identity);
                break;
            case 14:
                Instantiate(bishopPrefab, f2, Quaternion.identity);
                Instantiate(bishopPrefab, f4, Quaternion.identity);
                Instantiate(bishopPrefab, f6, Quaternion.identity);
                Instantiate(bishopPrefab, g2, Quaternion.identity);
                Instantiate(bishopPrefab, g4, Quaternion.identity);
                Instantiate(bishopPrefab, g6, Quaternion.identity);
                Instantiate(bishopPrefab, h2, Quaternion.identity);
                Instantiate(bishopPrefab, h4, Quaternion.identity);
                Instantiate(bishopPrefab, h6, Quaternion.identity);


                Instantiate(knightPrefab, a1, Quaternion.identity);
                Instantiate(knightPrefab, c1, Quaternion.identity);
                Instantiate(knightPrefab, e1, Quaternion.identity);

                Instantiate(rockPrefab, d8, Quaternion.identity);

                Instantiate(queenPrefab, f8, Quaternion.identity);


                Instantiate(kingPrefab, h8, Quaternion.identity);
                break;
        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }
    bool firstKingBossSpawn = false;

    public GameObject KingB;
    int kingBosNum;
    bool reset6 = false;

    void allStopCor6()
    {
        StopAllCoroutines();
        reset6 = true;
        StartCoroutine(kingBossEnd());
    }

    IEnumerator kingBoss()
    {
        yield return new WaitForSeconds(BpssdelayTime);
        bishopBossisEnd = true;
        StartCoroutine(kingBossEnd());
    }
    IEnumerator kingBossEnd()
    {
        if (reset6 == false)
        {
            allStopCor6();
        }

        GameObject.Find("KBfR(Clone)").GetComponent<KB4>().endKngitBoss();
        GameObject.Find("KBfR(Clone)").GetComponent<KB4>().endKngitBoss();
        GameObject.Find("KBfL(Clone)").GetComponent<KB3>().endKngitBoss();
        GameObject.Find("KBfL(Clone)").GetComponent<KB3>().endKngitBoss();
        GameObject.Find("kingBoss(Clone)").GetComponent<KingBoss>().endBishopBoss();
        //GameObject.Find("GameManager").GetComponent<GameManager>().PonBossDialog();//킹 대사
        yield return new WaitForSeconds(handDelayTime);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(handDelayTime);

        //isCanDialog = true;
        //if (GameManager.instance.state == GameManager.State.offDialog && isCanDialog == true)
        //{
        //    Debug.Log("폰대화시작");

        //    GameManager.instance.state = GameManager.State.onDialog;
        //    StartCoroutine(Dialog(ponEndDialog));
        //    yield return new WaitForSeconds(1f);
        //    isCanDialog = false;

        //    Debug.Log("isCanDialog: " + isCanDialog);
        //}
        GameManager.instance.GameOver();//게임오버함수 호출, 일단 킹보스 나오면 끝인걸로
        GameObject.Find("GameManager").GetComponent<GameManager>().ChangePlayState();
        StartCoroutine(kingRound());

        yield return null;
    }
    Vector2 KingBosspos = new Vector2(0.69f, 2.97f);
    IEnumerator KingBossRound()
    {

        bishopBosNum = Random.Range(1, 14);
        if (firstKingBossSpawn != false)
        {
            switch (bishopBosNum)
            {
                case 1:
                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, c6, Quaternion.identity);
                    Instantiate(queenPrefab, f3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);

                    Instantiate(kingPrefab, h1, Quaternion.identity);
                    Instantiate(kingPrefab, h8, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(ponPrefab, e1, Quaternion.identity);
                    Instantiate(ponPrefab, e3, Quaternion.identity);
                    Instantiate(ponPrefab, e5, Quaternion.identity);
                    Instantiate(ponPrefab, e7, Quaternion.identity);
                    Instantiate(ponPrefab, f2, Quaternion.identity);
                    Instantiate(ponPrefab, f4, Quaternion.identity);
                    Instantiate(ponPrefab, f6, Quaternion.identity);
                    Instantiate(ponPrefab, f8, Quaternion.identity);
                    Instantiate(ponPrefab, g1, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, g5, Quaternion.identity);
                    Instantiate(ponPrefab, g7, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);


                    Instantiate(kingPrefab, a1, Quaternion.identity);
                    Instantiate(kingPrefab, a8, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, b2, Quaternion.identity);
                    Instantiate(knightPrefab, c3, Quaternion.identity);
                    Instantiate(knightPrefab, d4, Quaternion.identity);
                    Instantiate(knightPrefab, e5, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);
                    Instantiate(knightPrefab, g7, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);

                    Instantiate(queenPrefab, c6, Quaternion.identity);

                    Instantiate(kingPrefab, f3, Quaternion.identity);

                    break;
                case 4:
                    Instantiate(bishopPrefab, d4, Quaternion.identity);
                    Instantiate(bishopPrefab, e5, Quaternion.identity);

                    Instantiate(knightPrefab, b3, Quaternion.identity);
                    Instantiate(knightPrefab, g6, Quaternion.identity);

                    Instantiate(rockPrefab, c2, Quaternion.identity);
                    Instantiate(rockPrefab, c7, Quaternion.identity);
                    Instantiate(rockPrefab, f2, Quaternion.identity);
                    Instantiate(rockPrefab, f7, Quaternion.identity);

                    Instantiate(queenPrefab, b6, Quaternion.identity);
                    Instantiate(queenPrefab, g3, Quaternion.identity);

                    Instantiate(kingPrefab, d5, Quaternion.identity);
                    Instantiate(kingPrefab, e4, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(ponPrefab, f4, Quaternion.identity);
                    Instantiate(ponPrefab, f5, Quaternion.identity);

                    Instantiate(bishopPrefab, a1, Quaternion.identity);
                    Instantiate(bishopPrefab, b8, Quaternion.identity);
                    Instantiate(bishopPrefab, c1, Quaternion.identity);
                    Instantiate(bishopPrefab, d8, Quaternion.identity);
                    Instantiate(bishopPrefab, e1, Quaternion.identity);
                    Instantiate(bishopPrefab, f8, Quaternion.identity);
                    Instantiate(bishopPrefab, g1, Quaternion.identity);
                    Instantiate(bishopPrefab, h8, Quaternion.identity);

                    Instantiate(knightPrefab, a8, Quaternion.identity);
                    Instantiate(knightPrefab, b1, Quaternion.identity);
                    Instantiate(knightPrefab, c8, Quaternion.identity);
                    Instantiate(knightPrefab, d1, Quaternion.identity);
                    Instantiate(knightPrefab, e8, Quaternion.identity);
                    Instantiate(knightPrefab, f1, Quaternion.identity);
                    Instantiate(knightPrefab, g8, Quaternion.identity);
                    Instantiate(knightPrefab, h1, Quaternion.identity);


                    Instantiate(queenPrefab, c4, Quaternion.identity);

                    Instantiate(kingPrefab, d5, Quaternion.identity);

                    break;
                case 6:

                    Instantiate(knightPrefab, b6, Quaternion.identity);
                    Instantiate(knightPrefab, g3, Quaternion.identity);

                    Instantiate(rockPrefab, a3, Quaternion.identity);
                    Instantiate(rockPrefab, a7, Quaternion.identity);
                    Instantiate(rockPrefab, h2, Quaternion.identity);
                    Instantiate(rockPrefab, h6, Quaternion.identity);

                    Instantiate(queenPrefab, a1, Quaternion.identity);
                    Instantiate(queenPrefab, b8, Quaternion.identity);
                    Instantiate(queenPrefab, g1, Quaternion.identity);
                    Instantiate(queenPrefab, h8, Quaternion.identity);

                    Instantiate(kingPrefab, d4, Quaternion.identity);
                    Instantiate(kingPrefab, e5, Quaternion.identity);

                    break;
                case 7:
                    Instantiate(ponPrefab, h1, Quaternion.identity);
                    Instantiate(ponPrefab, h2, Quaternion.identity);
                    Instantiate(ponPrefab, h3, Quaternion.identity);
                    Instantiate(ponPrefab, h4, Quaternion.identity);
                    Instantiate(ponPrefab, h5, Quaternion.identity);
                    Instantiate(ponPrefab, h6, Quaternion.identity);
                    Instantiate(ponPrefab, h7, Quaternion.identity);
                    Instantiate(ponPrefab, h8, Quaternion.identity);

                    Instantiate(knightPrefab, f3, Quaternion.identity);
                    Instantiate(knightPrefab, f4, Quaternion.identity);
                    Instantiate(knightPrefab, f5, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);

                    Instantiate(queenPrefab, e2, Quaternion.identity);
                    Instantiate(queenPrefab, e7, Quaternion.identity);

                    Instantiate(kingPrefab, c3, Quaternion.identity);
                    Instantiate(kingPrefab, c6, Quaternion.identity);

                    break;
                case 8:
                    Instantiate(ponPrefab, d2, Quaternion.identity);
                    Instantiate(ponPrefab, e7, Quaternion.identity);
                    Instantiate(ponPrefab, g4, Quaternion.identity);

                    Instantiate(bishopPrefab, d1, Quaternion.identity);
                    Instantiate(bishopPrefab, e8, Quaternion.identity);
                    Instantiate(bishopPrefab, h4, Quaternion.identity);


                    Instantiate(rockPrefab, b1, Quaternion.identity);
                    Instantiate(rockPrefab, d4, Quaternion.identity);
                    Instantiate(rockPrefab, g8, Quaternion.identity);
                    Instantiate(rockPrefab, h2, Quaternion.identity);

                    Instantiate(queenPrefab, c8, Quaternion.identity);
                    Instantiate(queenPrefab, f1, Quaternion.identity);
                    Instantiate(queenPrefab, h6, Quaternion.identity);

                    Instantiate(kingPrefab, b6, Quaternion.identity);

                    break;
                case 9:


                    Instantiate(bishopPrefab, c6, Quaternion.identity);
                    Instantiate(bishopPrefab, f3, Quaternion.identity);

                    Instantiate(knightPrefab, b2, Quaternion.identity);
                    Instantiate(knightPrefab, b7, Quaternion.identity);
                    Instantiate(knightPrefab, g2, Quaternion.identity);
                    Instantiate(knightPrefab, g7, Quaternion.identity);


                    Instantiate(rockPrefab, c3, Quaternion.identity);
                    Instantiate(rockPrefab, f6, Quaternion.identity);


                    Instantiate(queenPrefab, d8, Quaternion.identity);
                    Instantiate(queenPrefab, e1, Quaternion.identity);

                    Instantiate(kingPrefab, d4, Quaternion.identity);
                    Instantiate(kingPrefab, e5, Quaternion.identity);
                    break;
                case 10:


                    Instantiate(knightPrefab, a7, Quaternion.identity);
                    Instantiate(knightPrefab, b6, Quaternion.identity);
                    Instantiate(knightPrefab, b8, Quaternion.identity);
                    Instantiate(knightPrefab, c7, Quaternion.identity);
                    Instantiate(knightPrefab, f2, Quaternion.identity);
                    Instantiate(knightPrefab, g1, Quaternion.identity);
                    Instantiate(knightPrefab, g3, Quaternion.identity);
                    Instantiate(knightPrefab, h2, Quaternion.identity);


                    Instantiate(rockPrefab, b2, Quaternion.identity);
                    Instantiate(rockPrefab, g7, Quaternion.identity);


                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);

                    Instantiate(kingPrefab, b7, Quaternion.identity);
                    Instantiate(kingPrefab, g2, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(ponPrefab, b2, Quaternion.identity);
                    Instantiate(ponPrefab, b4, Quaternion.identity);
                    Instantiate(ponPrefab, b6, Quaternion.identity);
                    Instantiate(ponPrefab, c7, Quaternion.identity);
                    Instantiate(ponPrefab, f2, Quaternion.identity);
                    Instantiate(ponPrefab, g3, Quaternion.identity);
                    Instantiate(ponPrefab, g5, Quaternion.identity);
                    Instantiate(ponPrefab, g7, Quaternion.identity);

                    Instantiate(bishopPrefab, c5, Quaternion.identity);
                    Instantiate(bishopPrefab, f4, Quaternion.identity);

                    Instantiate(knightPrefab, d2, Quaternion.identity);
                    Instantiate(knightPrefab, e7, Quaternion.identity);
                    Instantiate(knightPrefab, e3, Quaternion.identity);
                    Instantiate(knightPrefab, f6, Quaternion.identity);

                    Instantiate(rockPrefab, c3, Quaternion.identity);
                    Instantiate(rockPrefab, d6, Quaternion.identity);

                    Instantiate(queenPrefab, e5, Quaternion.identity);

                    Instantiate(kingPrefab, d4, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(ponPrefab, c1, Quaternion.identity);
                    Instantiate(ponPrefab, c8, Quaternion.identity);
                    Instantiate(ponPrefab, f1, Quaternion.identity);
                    Instantiate(ponPrefab, f8, Quaternion.identity);
                    Instantiate(ponPrefab, d2, Quaternion.identity);
                    Instantiate(ponPrefab, d7, Quaternion.identity);
                    Instantiate(ponPrefab, e2, Quaternion.identity);
                    Instantiate(ponPrefab, e7, Quaternion.identity);


                    Instantiate(knightPrefab, c6, Quaternion.identity);
                    Instantiate(knightPrefab, f3, Quaternion.identity);


                    Instantiate(rockPrefab, h2, Quaternion.identity);
                    Instantiate(rockPrefab, h7, Quaternion.identity);

                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);

                    Instantiate(kingPrefab, d4, Quaternion.identity);
                    Instantiate(kingPrefab, e5, Quaternion.identity);
                    break;
                case 13:

                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, b8, Quaternion.identity);
                    Instantiate(knightPrefab, c1, Quaternion.identity);
                    Instantiate(knightPrefab, d8, Quaternion.identity);
                    Instantiate(knightPrefab, e1, Quaternion.identity);
                    Instantiate(knightPrefab, f8, Quaternion.identity);
                    Instantiate(knightPrefab, g1, Quaternion.identity);
                    Instantiate(knightPrefab, h8, Quaternion.identity);


                    Instantiate(rockPrefab, d1, Quaternion.identity);
                    Instantiate(rockPrefab, e8, Quaternion.identity);

                    Instantiate(queenPrefab, c3, Quaternion.identity);
                    Instantiate(queenPrefab, f6, Quaternion.identity);

                    Instantiate(kingPrefab, c6, Quaternion.identity);
                    Instantiate(kingPrefab, f3, Quaternion.identity);
                    break;
                case 14:
                    Instantiate(bishopPrefab, f2, Quaternion.identity);
                    Instantiate(bishopPrefab, f4, Quaternion.identity);
                    Instantiate(bishopPrefab, f6, Quaternion.identity);
                    Instantiate(bishopPrefab, g2, Quaternion.identity);
                    Instantiate(bishopPrefab, g4, Quaternion.identity);
                    Instantiate(bishopPrefab, g6, Quaternion.identity);
                    Instantiate(bishopPrefab, h2, Quaternion.identity);
                    Instantiate(bishopPrefab, h4, Quaternion.identity);
                    Instantiate(bishopPrefab, h6, Quaternion.identity);


                    Instantiate(knightPrefab, a1, Quaternion.identity);
                    Instantiate(knightPrefab, c1, Quaternion.identity);
                    Instantiate(knightPrefab, e1, Quaternion.identity);

                    Instantiate(rockPrefab, d8, Quaternion.identity);

                    Instantiate(queenPrefab, f8, Quaternion.identity);


                    Instantiate(kingPrefab, h8, Quaternion.identity);
                    break;
            }
        }

        if (firstKingBossSpawn == false)
        {
            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(handDelayTime);
            firstKingBossSpawn = true;
            StartCoroutine(kingBoss());
            KBfL.tag = "KBCanKill";
            KBfR.tag = "KBCanKill";
            Instantiate(BossGage, BossGagePos, Quaternion.identity);

            Instantiate(KBfL, e5, Quaternion.identity);
            Instantiate(KBfL, e7, Quaternion.identity);
            Instantiate(KBfR, f2, Quaternion.identity);
            Instantiate(KBfR, f4, Quaternion.identity);
            Instantiate(KingB, KingBosspos, Quaternion.identity);
        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }
}
