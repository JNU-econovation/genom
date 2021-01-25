using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSW_CON : MonoBehaviour
{
    [SerializeField] GameObject PSW;
    [SerializeField] GameObject spwaner;
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    public void KingKilledByPlayer()
    {
        Destroy(PSW);
    }
    public void KingKilledByEnemy()
    {
        Destroy(PSW);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && PSW.tag == "PSW_over")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().PonBossDialog();//폰 대사
            KingKilledByPlayer();
            //GameManager.instance.EnemyScore(king_score);
        }

        if (collision.tag == "Hand")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().PonBossDialog();//폰 대사
            KingKilledByPlayer();
            //GameManager.instance.EnemyScore(king_score);
        }
        else if (collision.tag == "Player" && PSW.tag == "PSW")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            // GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }








    }



    void Update()
    {
    



        if (PSW.transform.position.y > 3.744f && PSW.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (PSW.transform.position.y > 2.656f && PSW.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (PSW.transform.position.y > 1.55f && PSW.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (PSW.transform.position.y > 0.458f && PSW.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (PSW.transform.position.y > -0.655f && PSW.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (PSW.transform.position.y > -1.75f && PSW.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (PSW.transform.position.y > -2.84f && PSW.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (PSW.transform.position.y > -3.94f && PSW.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
}