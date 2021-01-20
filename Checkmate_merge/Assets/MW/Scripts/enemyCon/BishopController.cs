using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopController : MonoBehaviour
{
    [SerializeField] GameObject bishop;
    public int bishop_score;
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    public void BishopKilledByPlayer()
    {
        Destroy(bishop);
    }
    public void BishopKilledByEnemy()
    {
        Destroy(bishop);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && bishop.tag == "BishopCanKilled")
        {
            BishopKilledByPlayer();
            GameManager.instance.EnemyScore(bishop_score);
            string message = "+" + bishop_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }


        else if (collision.tag == "Player" && bishop.tag == "BishopCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            //GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }
        else if (collision.tag == "skillATT")
        {
            BishopKilledByPlayer();
            GameManager.instance.EnemyScore(bishop_score);
            string message = "+" + bishop_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }

        else if (collision.tag == "Hand")
        {
            BishopKilledByEnemy();
        }

        else if (collision.tag == "KingCanKill")
        {
            BishopKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            BishopKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill")
        {
            BishopKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled")
        {
            BishopKilledByEnemy();
        }

        else if (collision.tag == "KnightCanKill")
        {
            BishopKilledByEnemy();
        }
  

        else if (collision.tag == "BishopCanKill" && bishop.tag == "BishopCanKilled")
        {
            BishopKilledByEnemy();
        }


        else if (collision.tag == "RockCanKill")
        {

            BishopKilledByEnemy();
        }
        else if (collision.tag == "RockCanKilled")
        {

            BishopKilledByEnemy();
        }
        else if (collision.tag == "PSW")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "PSW_over")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "RBp")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "RBover")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "QBattack")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "QBcanKilled")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "QBCanKill")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "BBCanKill")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "BBCanKilled")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "spearAtt")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "QBEatAtt")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "KBCanKill")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "KBCanKilled")
        {
            BishopKilledByEnemy();
        }
    }


    void Update()
    {

        BishopDestroy();
        if (bishop.transform.position.y > 3.744f && bishop.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (bishop.transform.position.y > 2.656f && bishop.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (bishop.transform.position.y > 1.55f && bishop.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (bishop.transform.position.y > 0.458f && bishop.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (bishop.transform.position.y > -0.655f && bishop.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (bishop.transform.position.y > -1.75f && bishop.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (bishop.transform.position.y > -2.84f && bishop.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (bishop.transform.position.y > -3.94f && bishop.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
    public void BishopDestroy() 
    {
        if (bishop.transform.position.x > 5.5)
        {
            Destroy(bishop);

        }
        if (bishop.transform.position.x < -4)
        {
            Destroy(bishop);
        }

        if (bishop.transform.position.y > 4.5)
        {
            Destroy(bishop);
        }
        if (bishop.transform.position.y < -5)
        {
            Destroy(bishop);
        }

    }

}
