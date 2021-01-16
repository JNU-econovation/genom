using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenController : MonoBehaviour
{
    [SerializeField] GameObject queen;
    public int queen_score;
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void QueenKilledByPlayer()
    {
        Destroy(queen);
    }
    public void QueenKilledByEnemy()
    {
        Destroy(queen);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByPlayer();
            GameManager.instance.EnemyScore(queen_score);

        }
        else if (collision.tag == "Player" && queen.tag == "QBCanKilled")
        {
            QueenKilledByPlayer();

        }

        else if (collision.tag == "Player" && queen.tag == "QueenCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }
        else if (collision.tag == "Player" && queen.tag == "QBCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }
        if (collision.tag == "Hand")
        {
            QueenKilledByEnemy();
            //GameManager.instance.EnemyScore(king_score);
        }

        else if (collision.tag == "KingCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled")
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
