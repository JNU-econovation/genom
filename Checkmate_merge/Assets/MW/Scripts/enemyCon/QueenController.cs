using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] GameObject queen;
    int queen_score=5;
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(queen);
    }
    public void QueenKilledByPlayer()
    {
        animator.SetFloat("Die", 1);
        queen.gameObject.tag = "Untagged";
        StartCoroutine(die());
    }
    public void QueenKilledByEnemy()
    {
        animator.SetFloat("Die", 1);
        queen.gameObject.tag = "Untagged";
        StartCoroutine(die());
    }
    public void BossdieCor()
    {
        Destroy(queen);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByPlayer();
            GameManager.instance.EnemyScore(queen_score);
            string message = "+" + queen_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }
        else if (collision.tag == "skillATT" && queen.tag == "QueenCanKilled") // 퀸이 스킬에 맞으면
        {
            QueenKilledByPlayer();
            GameManager.instance.EnemyScore(queen_score);
            string message = "+" + queen_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }
        else if (collision.tag == "skillATT" && queen.tag == "QueenCanKill") // 퀸이 스킬에 맞으면
        {
            QueenKilledByPlayer();
            GameManager.instance.EnemyScore(queen_score);
            string message = "+" + queen_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }

        else if (collision.tag == "Player" && queen.tag == "QueenCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            // GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }


        else if (collision.tag == "Player" && queen.tag == "QBCanKilled") // 퀸보스
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().QueenBossDialog();//퀸 대사
            BossdieCor();

        }
        else if (collision.tag == "Player" && queen.tag == "QBCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            //  GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }
        if (collision.tag == "Hand")
        {
            if(queen.tag == "QBCanKilled")
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().QueenBossDialog();//퀸 대사
                BossdieCor();
            }
            BossdieCor();
            //GameManager.instance.EnemyScore(king_score);
        }
        else if (collision.tag == "PSW" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "PSW_over" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "RBp" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "RBover" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "QBattack" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "QBcanKilled" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "QBCanKill" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "BBCanKill" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "BBCanKilled" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "spearAtt" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "QBEatAtt" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "KBCanKill" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "KBCanKilled" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }


        else if (collision.tag == "KingCanKill" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "KingCanKill" && queen.tag == "QueenCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "KingCanKilled" && queen.tag == "QueenCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "QueenCanKill" && queen.tag == "QueenCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }
        else if (collision.tag == "QueenCanKilled" && queen.tag == "QueenCanKill")
        {
            QueenKilledByEnemy();
        }

    }

void Update()
    {



        QueenDestroy();
        if (queen.transform.position.y > 3.744f && queen.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (queen.transform.position.y > 2.656f && queen.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (queen.transform.position.y > 1.55f && queen.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (queen.transform.position.y > 0.458f && queen.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (queen.transform.position.y > -0.655f && queen.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (queen.transform.position.y > -1.75f && queen.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (queen.transform.position.y > -2.84f && queen.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (queen.transform.position.y > -3.94f && queen.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
    public void QueenDestroy() 
    {
        if (queen.transform.position.x > 5.5)
        {
            Destroy(queen);

        }
        if (queen.transform.position.x < -4)
        {
            Destroy(queen);
        }

        if (queen.transform.position.y > 4.5)
        {
            Destroy(queen);
        }
        if (queen.transform.position.y < -5)
        {
            Destroy(queen);
        }

    }

}
