using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Vector2 a1 = new Vector2(-3.16f, 3.52f);
    Vector2 a2 = new Vector2(-2.06f, 3.52f);
    Vector2 a3 = new Vector2(-0.96f, 3.52f);
    Vector2 a4 = new Vector2(0.14f, 3.52f);
    Vector2 a5 = new Vector2(1.24f, 3.52f);
    Vector2 a6 = new Vector2(2.34f, 3.52f);
    Vector2 a7 = new Vector2(3.44f, 3.52f);
    Vector2 a8 = new Vector2(4.54f, 3.52f);

    Vector2 b1 = new Vector2(-3.16f, 2.42f);
    Vector2 b2 = new Vector2(-2.06f, 2.42f);
    Vector2 b3 = new Vector2(-0.96f, 2.42f);
    Vector2 b4 = new Vector2(0.14f, 2.42f);
    Vector2 b5 = new Vector2(1.24f, 2.42f);
    Vector2 b6 = new Vector2(2.34f, 2.42f);
    Vector2 b7 = new Vector2(3.44f, 2.42f);
    Vector2 b8 = new Vector2(4.54f, 2.42f);

    Vector2 c1 = new Vector2(-3.16f, 1.32f);
    Vector2 c2 = new Vector2(-2.06f, 1.32f);
    Vector2 c3 = new Vector2(-0.96f, 1.32f);
    Vector2 c4 = new Vector2(0.14f, 1.32f);
    Vector2 c5 = new Vector2(1.24f, 1.32f);
    Vector2 c6 = new Vector2(2.34f, 1.32f);
    Vector2 C7 = new Vector2(3.44f, 1.32f);
    Vector2 c8 = new Vector2(4.54f, 1.32f);

    Vector2 d1 = new Vector2(-3.16f, 0.22f);
    Vector2 d2 = new Vector2(-2.06f, 0.22f);
    Vector2 d3 = new Vector2(-0.96f, 0.22f);
    Vector2 d4 = new Vector2(0.14f, 0.22f);
    Vector2 d5 = new Vector2(1.24f, 0.22f);
    Vector2 d6 = new Vector2(2.34f, 0.22f);
    Vector2 d7 = new Vector2(3.44f, 0.22f);
    Vector2 d8 = new Vector2(4.54f, 0.22f);

    Vector2 e1 = new Vector2(-3.16f, -0.88f);
    Vector2 e2 = new Vector2(-2.06f, -0.88f);
    Vector2 e3 = new Vector2(-0.96f, -0.88f);
    Vector2 e4 = new Vector2(0.14f, -0.88f);
    Vector2 e5 = new Vector2(1.24f, -0.88f);
    Vector2 e6 = new Vector2(2.34f, -0.88f);
    Vector2 e7 = new Vector2(3.44f, -0.88f);
    Vector2 e8 = new Vector2(4.54f, -0.88f);

    Vector2 f1 = new Vector2(-3.16f, -1.98f);
    Vector2 f2 = new Vector2(-2.06f, -1.98f);
    Vector2 f3 = new Vector2(-0.96f, -1.98f);
    Vector2 f4 = new Vector2(0.14f, -1.98f);
    Vector2 f5 = new Vector2(1.24f, -1.98f);
    Vector2 f6 = new Vector2(2.34f, -1.98f);
    Vector2 f7 = new Vector2(3.44f, -1.98f);
    Vector2 f8 = new Vector2(4.54f, -1.98f);

    Vector2 g1 = new Vector2(-3.16f, -3.08f);
    Vector2 g2 = new Vector2(-2.06f, -3.08f);
    Vector2 g3 = new Vector2(-0.96f, -3.08f);
    Vector2 g4 = new Vector2(0.14f, -3.08f);
    Vector2 g5 = new Vector2(1.24f, -3.08f);
    Vector2 g6 = new Vector2(2.34f, -3.08f);
    Vector2 g7 = new Vector2(3.44f, -3.08f);
    Vector2 g8 = new Vector2(4.54f, -3.08f);

    Vector2 h1 = new Vector2(-3.16f, -4.18f);
    Vector2 h2 = new Vector2(-2.06f, -4.18f);
    Vector2 h3 = new Vector2(-0.96f, -4.18f);
    Vector2 h4 = new Vector2(0.14f, -4.18f);
    Vector2 h5 = new Vector2(1.24f, -4.18f);
    Vector2 h6 = new Vector2(2.34f, -4.18f);
    Vector2 h7 = new Vector2(3.44f, -4.18f);
    Vector2 h8 = new Vector2(4.54f, -4.18f);



    public GameObject ponPrefab;
    public GameObject rockPrefab;
    public GameObject bishopPrefab;
    public GameObject knightPrefab;
    public GameObject kingPrefab;
    public GameObject queenPrefab;


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



    IEnumerator timer(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        StartCoroutine(setRound());
    }
    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f* 6);
        StartCoroutine(setRound());
    }

    int roundNum = 0;
    float count;
    float firstCount;
    bool firstSpawn = true;
    IEnumerator setRound()
    {



        roundNum = Random.Range(1, 8);


        switch (roundNum)
        {
            case 1:
                Instantiate(ponPrefab, b2, Quaternion.identity);
                Instantiate(ponPrefab, b7, Quaternion.identity);
                Instantiate(ponPrefab, g2, Quaternion.identity);
                Instantiate(ponPrefab, g7, Quaternion.identity);
                count = 0;
                break;
            case 2:
                Instantiate(rockPrefab, a1, Quaternion.identity);
                Instantiate(rockPrefab, b1, Quaternion.identity);
                Instantiate(rockPrefab, c1, Quaternion.identity);
                Instantiate(rockPrefab, d1, Quaternion.identity);
                Instantiate(rockPrefab, e1, Quaternion.identity);
                Instantiate(rockPrefab, f1, Quaternion.identity);
                Instantiate(rockPrefab, g1, Quaternion.identity);
                Instantiate(rockPrefab, h1, Quaternion.identity);
                count = 0;
                break;
            case 3:
                Instantiate(knightPrefab, c3, Quaternion.identity);
                Instantiate(knightPrefab, c6, Quaternion.identity);
                Instantiate(knightPrefab, f3, Quaternion.identity);
                Instantiate(knightPrefab, f6, Quaternion.identity);
                break;
            case 4:
                Instantiate(queenPrefab, a4, Quaternion.identity);
                Instantiate(queenPrefab, g5, Quaternion.identity);
                break;
            case 5:
                Instantiate(kingPrefab, d4, Quaternion.identity);
                break;
            case 6:
                Instantiate(bishopPrefab, b3, Quaternion.identity);
                Instantiate(bishopPrefab, c4, Quaternion.identity);
                Instantiate(bishopPrefab, d5, Quaternion.identity);
                break;



        }

                yield return null;

        StartCoroutine(timer(delayTime));

    }


}
