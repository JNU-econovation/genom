using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

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



    public GameObject PlayerPos;

    public GameObject ponPrefab;
    public GameObject rockPrefab;
    public GameObject bishopPrefab;
    public GameObject knightPrefab;
    public GameObject kingPrefab;
    public GameObject queenPrefab;
    public GameObject devilHand;

    Vector2 ponBossPos = new Vector2(0.81f, 3.62f);
    Vector2 devilHandPos = new Vector2(18.25f, -1.46f);


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
    float delayTime = 0.93023255813953488372093023255812f * 5;
    float BpssdelayTime = 0.93023255813953488372093023255812f * 30f;
    bool ponBossisEnd = false;
    bool knightBossisEnd = false;
    bool bishopBossisEnd = false;
    bool queenBossisEnd = false;
    bool rockBossisEnd = false;
    bool kingBossisEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fisrtTimer());
    }

    // Update is called once per frame
    void Update()
    {


    }


    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 6);
        StartCoroutine(PonRound());
    }


    IEnumerator timer(float delayTime)
    {

        yield return new WaitForSeconds(delayTime);

        if (GameManager.score >= 0 && GameManager.score < 100)
        {
            StartCoroutine(PonRound());
        }

        else if(GameManager.score >= 100 && ponBossisEnd == false)
        {
            if(isPonDevilFirst)
            {
                isPonDevilFirst = false;
                StartCoroutine(ponSpqwnDevilHand());

            }
            else if (!isPonDevilFirst)
            {
                StartCoroutine(PonBossRound());
            }
        }




        else if (GameManager.score >= 200 && GameManager.score < 300)
        {
            StartCoroutine(KnightRound());
        }

        else if (GameManager.score >= 300 && knightBossisEnd == false)
        {
            StartCoroutine(KnightBossRound());
        }




        else if(GameManager.score > 400 && GameManager.score < 500)
        {
            StartCoroutine(bishopRound());
        }

        else if(GameManager.score >= 500 && bishopBossisEnd == false)
        {
            StartCoroutine(BishopBossRound());
        }


        else if(GameManager.score > 600 && GameManager.score < 700)
        {

            StartCoroutine(RockRound());
        }

        else if(GameManager.score >= 700 && rockBossisEnd == false)
        {
            StartCoroutine(RockBossRound());
        }


        else if(GameManager.score > 800 && GameManager.score < 900)
        {

            StartCoroutine(QueenRound());
        }

        else if(GameManager.score >= 900 && queenBossisEnd == false)
        {
            StartCoroutine(QueenBossRound());
        }

        else
        {
            Debug.Log("인터벌");
            StartCoroutine(interverTimer(delayTime));
        }


    }
    IEnumerator interverTimer(float     delayTime)
    {
        yield return new WaitForSeconds(delayTime/2);
        StartCoroutine(timer(delayTime));
    }



        IEnumerator ponSpqwnDevilHand()
    {
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(5);
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
    IEnumerator ponBossEnd()
    {
        ponBossisEnd = true;
        Debug.Log("폰보스 끝");
        GameObject.Find("PSW(Clone)").GetComponent<KingTreeAi>().endPonBoss();
        yield return new WaitForSeconds(delayTime*2);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return null;
    }


    int randPonBossNum = 0;
    IEnumerator PonBossRound()
    {
        
     


        randPonBossNum = Random.Range(1, 5);
        switch (randPonBossNum)
        {
            case 1:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
            case 2:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                break;
            case 3:
                Instantiate(ponPrefab, b7, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, g2, Quaternion.identity);
                break;
            case 5:
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
        }
        if (firstPonBossSpawn == false)
        {
            ponBossPrefab.tag = "PSW";
            firstPonBossSpawn = true;
            Instantiate(ponBossPrefab, ponBossPos, Quaternion.identity);
            StartCoroutine(ponBoss());
        }

        StartCoroutine(timer(delayTime));
        yield return null;


    }

    IEnumerator PonRound()
    {

        roundNum = Random.Range(1, 5);
        switch (roundNum)
        {
            case 1:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;
            case 2:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                break;
            case 3:
                Instantiate(ponPrefab, b7, Quaternion.identity);
                break;
            case 4:
                Instantiate(ponPrefab, g2, Quaternion.identity);
                break;
            case 5:
                Instantiate(ponPrefab, g7, Quaternion.identity);
                break;

        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }




    IEnumerator RockRound()
    {
        roundNum = Random.Range(1, 5);
        switch (roundNum)
        {
            case 1:
                Instantiate(rockPrefab, a1, Quaternion.identity);
                Instantiate(rockPrefab, c1, Quaternion.identity);
                Instantiate(rockPrefab, e1, Quaternion.identity);
                Instantiate(rockPrefab, g1, Quaternion.identity);
                break;
            case 2:
                Instantiate(rockPrefab, h1, Quaternion.identity);
                Instantiate(rockPrefab, h3, Quaternion.identity);
                Instantiate(rockPrefab, h5, Quaternion.identity);
                Instantiate(rockPrefab, h7, Quaternion.identity);
                break;
            case 3:
                Instantiate(rockPrefab, h8, Quaternion.identity);
                Instantiate(rockPrefab, f8, Quaternion.identity);
                Instantiate(rockPrefab, d8, Quaternion.identity);
                Instantiate(rockPrefab, b8, Quaternion.identity);
                break;
            case 4:
                Instantiate(rockPrefab, a7, Quaternion.identity);
                Instantiate(rockPrefab, a5, Quaternion.identity);
                Instantiate(rockPrefab, a3, Quaternion.identity);
                Instantiate(rockPrefab, a1, Quaternion.identity);
                break;
            case 5:
                Instantiate(rockPrefab, c4, Quaternion.identity);
                Instantiate(rockPrefab, c5, Quaternion.identity);
                Instantiate(rockPrefab, d6, Quaternion.identity);
                Instantiate(rockPrefab, e6, Quaternion.identity);
                Instantiate(rockPrefab, f4, Quaternion.identity);
                Instantiate(rockPrefab, f5, Quaternion.identity);
                Instantiate(rockPrefab, d3, Quaternion.identity);
                Instantiate(rockPrefab, e3, Quaternion.identity);
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


    IEnumerator RockBossRound()
    {
        if(RBcounter == 0)
        {
            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(delayTime);
        }


        RockBossRange = Random.Range(1,24);
        if (RBcounter == 6)
        {

            RBcounter++;
            rockBossisEnd = true;

            Instantiate(RBover, endRBPos, Quaternion.identity);
            yield return new WaitForSeconds(delayTime * 2);

            Instantiate(devilHand, devilHandPos, Quaternion.identity);
        }


        if (RBcounter < 6) {
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

        }
        
    

        yield return null;
        StartCoroutine(timer(delayTime));

    }


    IEnumerator bishopRound()
    {

        roundNum = Random.Range(1, 5);
        switch (roundNum)
        {
            case 1:
                Instantiate(bishopPrefab, b2, Quaternion.identity);
                Instantiate(bishopPrefab, b7, Quaternion.identity);
                Instantiate(bishopPrefab, g2, Quaternion.identity);
                Instantiate(bishopPrefab, g7, Quaternion.identity);
                break;
            case 2:
                Instantiate(bishopPrefab, b2, Quaternion.identity);
                break;
            case 3:
                Instantiate(bishopPrefab, b7, Quaternion.identity);
                break;
            case 4:
                Instantiate(bishopPrefab, g2, Quaternion.identity);
                break;
            case 5:
                Instantiate(bishopPrefab, g7, Quaternion.identity);
                break;

        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }
    bool firstBishopBossSpawn = false;
    public GameObject lightningPrefep;
    public GameObject BB;
    int bishopBosNum;


    IEnumerator bishopBoss()
    {
        yield return new WaitForSeconds(BpssdelayTime);
        bishopBossisEnd = true;
        StartCoroutine(bishopBossEnd());
    }
    IEnumerator bishopBossEnd()
    {

        GameObject.Find("anglerSSun(Clone)").GetComponent< anglerSSun> ().endBishopBoss();
        yield return new WaitForSeconds(delayTime * 2);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return null;
    }
    IEnumerator BishopBossRound()
    {

        bishopBosNum = Random.Range(1, 5);
        if (firstBishopBossSpawn != false)
        {
            switch (bishopBosNum)
            {
                case 1:
                    Instantiate(lightningPrefep, c2 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, b3 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, d3 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, c4 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(lightningPrefep, e3 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, f2 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, f4 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, g3 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(lightningPrefep, a3 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, b4 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, c5 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, d6 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, e7 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, f8 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(lightningPrefep, b5 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, c4 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, c6 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, d5 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(lightningPrefep, e6 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, f5 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, f7 + new Vector2(0, 0.2f), Quaternion.identity);
                    Instantiate(lightningPrefep, g6 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
            }
        }
            
        if (firstBishopBossSpawn == false)
        {
            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(delayTime);
            firstBishopBossSpawn = true;
            StartCoroutine(bishopBoss());
            Instantiate(BB, ponBossPos, Quaternion.identity);
        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }

    IEnumerator QueenRound()
    {

        roundNum = Random.Range(1, 5);
        switch (roundNum)
        {
            case 1:
                Instantiate(queenPrefab, b2, Quaternion.identity);
                Instantiate(queenPrefab, b7, Quaternion.identity);
                Instantiate(queenPrefab, g2, Quaternion.identity);
                Instantiate(queenPrefab, g7, Quaternion.identity);
                break;
            case 2:
                Instantiate(queenPrefab, b2, Quaternion.identity);
                break;
            case 3:
                Instantiate(queenPrefab, b7, Quaternion.identity);
                break;
            case 4:
                Instantiate(queenPrefab, g2, Quaternion.identity);
                break;
            case 5:
                Instantiate(queenPrefab, g7, Quaternion.identity);
                break;

        }
        StartCoroutine(timer(delayTime));
        yield return null;

    }


    IEnumerator queenBoss()
    {

        yield return new WaitForSeconds(BpssdelayTime);
        queenBossisEnd = true;
        StartCoroutine(queenBossEnd());
    }
    IEnumerator queenBossEnd()
    {
        GameObject.Find("QBRed(Clone)").GetComponent<QueenTreeAi>().endQueenBoss();
        yield return new WaitForSeconds(delayTime * 2);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return null;
    }

    bool firstQueenBossSpawn = false;
    public GameObject QB;
    int QueenBosNum;




    IEnumerator QueenBossRound()
    {

        QueenBosNum = Random.Range(1, 5);
        if (firstQueenBossSpawn != false)
        {
            switch (QueenBosNum)
            {
                case 1:
                    Instantiate(lightningPrefep, g6 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(lightningPrefep, g6 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(lightningPrefep, g6 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(lightningPrefep, g6 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(lightningPrefep, g6 + new Vector2(0, 0.2f), Quaternion.identity);
                    break;
            }
        }

        if (firstQueenBossSpawn == false)
        {
            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(delayTime);
            ponBossPrefab.tag = "QBCanKill";
            firstQueenBossSpawn = true;
            StartCoroutine(queenBoss());
            Instantiate(QB, a4 + new Vector2(0, 0.5f), Quaternion.identity) ;


        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }
    IEnumerator KnightRound()
    {

        roundNum = Random.Range(1, 5);
        switch (roundNum)
        {
            case 1:
                Instantiate(knightPrefab, b2, Quaternion.identity);
                Instantiate(knightPrefab, b7, Quaternion.identity);
                Instantiate(knightPrefab, g2, Quaternion.identity);
                Instantiate(knightPrefab, g7, Quaternion.identity);
                break;
            case 2:
                Instantiate(knightPrefab, b2, Quaternion.identity);
                break;
            case 3:
                Instantiate(knightPrefab, b7, Quaternion.identity);
                break;
            case 4:
                Instantiate(knightPrefab, g2, Quaternion.identity);
                break;
            case 5:
                Instantiate(knightPrefab, g7, Quaternion.identity);
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


    IEnumerator knightBoss()
    {
        yield return new WaitForSeconds(BpssdelayTime);
        knightBossisEnd = true;
        StartCoroutine(knightBossEnd());
    }
    IEnumerator knightBossEnd()
    {
        GameObject.Find("KBfD(Clone)").GetComponent<KB2>().endKngitBoss();
        GameObject.Find("KBfU(Clone)").GetComponent<KB>().endKngitBoss();
        GameObject.Find("KBfR(Clone)").GetComponent<KB4>().endKngitBoss();
        GameObject.Find("KBfL(Clone)").GetComponent<KB3>().endKngitBoss();
        yield return new WaitForSeconds(delayTime * 2);
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return null;
    }

    bool firstKnightBossSpawn = false;
    int KnightBosNum = 0;
    IEnumerator KnightBossRound()
    {

        KnightBosNum = Random.Range(1, 5);
        if (firstKnightBossSpawn != false)
        {
            switch (KnightBosNum)
            {
                case 1:
                    Instantiate(knightPrefab, b5 , Quaternion.identity);
                    break;
                case 2:
                    Instantiate(knightPrefab, b5 , Quaternion.identity);
                    break;
                case 3:
                    Instantiate(knightPrefab, b5 , Quaternion.identity);
                    break;
                case 4:
                    Instantiate(knightPrefab, b5 , Quaternion.identity);
                    break;
                case 5:
                    Instantiate(knightPrefab, b5 , Quaternion.identity);
                    break;
            }
        }

        if (firstKnightBossSpawn == false)
        {

            Instantiate(devilHand, devilHandPos, Quaternion.identity);

            yield return new WaitForSeconds(delayTime);

            Debug.Log("최초의 나이트보스 등장");
            KBfD.tag = "KBCanKill";
            KBfU.tag = "KBCanKill";
            KBfL.tag = "KBCanKill";
            KBfR.tag = "KBCanKill";

            Instantiate(KBfD, b3 + new Vector2(0, 0.35f), Quaternion.identity);
            Instantiate(KBfU, g6 + new Vector2(0, 0.35f), Quaternion.identity);
            Instantiate(KBfL, c7 + new Vector2(0, 0.35f), Quaternion.identity);
            Instantiate(KBfR, f2 + new Vector2(0, 0.35f), Quaternion.identity);
            firstKnightBossSpawn = true;
            StartCoroutine(knightBoss());

        }
        yield return null;
        StartCoroutine(timer(delayTime));

    }
}
