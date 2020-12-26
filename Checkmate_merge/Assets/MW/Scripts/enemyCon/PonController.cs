using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonController : MonoBehaviour
{
    [SerializeField] GameObject pon;
    public int pon_score = 1;

    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void PonKilledByPlayer()//폰이 플레이어에 잡혔을 때 함수(폰 파괴)
    {
        Destroy(pon);
    }
    public void PonKilledByEnemy()
    {
        Destroy(pon);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && pon.tag == "PonCanKilled")//폰이 플레이어에 의해 죽음(1점 증가)
        {
           
            PonKilledByPlayer();
            GameManager.instance.EnemyScore(pon_score);//폰 점수(1점) 넣기
           

        }
        else if (collision.tag == "Player" && pon.tag == "PonCanKill")//폰이 플레이어를 죽임(게임 오버)
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }




        else if (collision.tag == "PonCanKill")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "PonCanKilled")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "KingCanKill")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "KnightCanKill")
        {
            PonKilledByEnemy();
        }
        else if (collision.tag == "KnightCanKilled")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "BishopCanKill")
        {
            PonKilledByEnemy();
        }
        else if (collision.tag == "BishopCanKilled")
        {
            PonKilledByEnemy();
        }

        else if (collision.tag == "RockCanKill")
        {

            PonKilledByEnemy();
        }
        else if (collision.tag == "RockCanKilled")
        {

            PonKilledByEnemy();
        }

    }

    void Update()//매 프레임마다 폰의 위치를 파악하여 범위에서 벗어나면 폰 파괴
    {

        PonDestroy();
        if (pon.transform.position.y > 3.744f && pon.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (pon.transform.position.y > 2.656f && pon.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (pon.transform.position.y > 1.55f && pon.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (pon.transform.position.y > 0.458f && pon.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (pon.transform.position.y > -0.655f && pon.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (pon.transform.position.y > -1.75f && pon.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (pon.transform.position.y > -2.84f && pon.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (pon.transform.position.y > -3.94f && pon.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }

    public void PonDestroy()//폰 위치가 범위에서 벗어나면 폰을 파괴하는 함수.
    {
        if (pon.transform.position.x > 5.5)
        {
            Destroy(pon);

        }
        if (pon.transform.position.x < -4)
        {
            Destroy(pon);
        }

        if (pon.transform.position.y > 4.5)
        {
            Destroy(pon);
        }
        if (pon.transform.position.y < -5)
        {
            Destroy(pon);
        }

    }

}
