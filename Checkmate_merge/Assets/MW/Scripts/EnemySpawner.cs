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
    Vector2 C7 = new Vector2(3.443f, 1.31f);
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
    float count;
    float firstCount;
    bool firstSpawn = true;

    bool ponBossIsSpwan = false;

    public bool endPonBoss = false;
    bool firstPonBossSpawn = false;
    bool isDevilFirst = true;
    float delayTime = 0.93023255813953488372093023255812f * 5;

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

        if (GameManager.score >= 0 && GameManager.score < 50)
        {
            StartCoroutine(PonRound());
        }

        if(GameManager.score >= 50 && ponBossIsSpwan == false)
        {
            if(isDevilFirst)
            {
                StartCoroutine(SpqwnDevilHand());
                isDevilFirst = false;
            }
            if (!isDevilFirst)
            {
                PonBossRound();
            }
        }


        if (GameManager.score > 200 && GameManager.score < 400)
        {
            StartCoroutine(RockRound());
        }





    }


    IEnumerator SpqwnDevilHand()
    {
        Instantiate(devilHand, devilHandPos, Quaternion.identity);
        yield return new WaitForSeconds(10);
        StartCoroutine(PonBossRound());
    }





    IEnumerator ponBoss()
    {
        Debug.Log("폰보스 시작");
        yield return new WaitForSeconds(10);
        StartCoroutine(ponBossEnd());
    }
    IEnumerator ponBossEnd()
    {
        
        Debug.Log("폰보스 끝");
        GameObject.Find("PSW(Clone)").GetComponent<KingTreeAi>().endPonBoss();
        yield return null;
    }



    IEnumerator PonBossRound()
    {
        
        if (firstPonBossSpawn == false)
        {
            ponBossPrefab.tag = "PSW";
            firstPonBossSpawn = true;
            Instantiate(ponBossPrefab, ponBossPos, Quaternion.identity);
            StartCoroutine(ponBoss());
        }
        



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
                yield return null;
        StartCoroutine(timer(delayTime));

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



}
