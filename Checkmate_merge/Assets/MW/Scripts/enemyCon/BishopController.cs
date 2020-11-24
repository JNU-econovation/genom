using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopController : MonoBehaviour
{
    [SerializeField] GameObject bishop;
    public int bishop_score;

    // Start is called before the first frame update
    void Start()
    {

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

        }


        else if (collision.tag == "Player" && bishop.tag == "BishopCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
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
  

        else if (collision.tag == "BishopCanKill")
        {
            BishopKilledByEnemy();
        }
        else if (collision.tag == "BishopCanKilled")
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
    }


    void Update()
    {

        BishopDestroy();
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
