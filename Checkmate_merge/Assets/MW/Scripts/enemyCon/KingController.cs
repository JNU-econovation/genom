using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] GameObject king;
    public int king_score = 4;

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
        Destroy(king);
    }
    public void KingKilledByPlayer()
    {
        animator.SetFloat("Die", 1);
        king.gameObject.tag = "Untagged";
        StartCoroutine(die());
    }
    public void KingKilledByEnemy()
    {
        animator.SetFloat("Die", 1);
        king.gameObject.tag = "Untagged";
        StartCoroutine(die());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && king.tag == "KingCanKilled")
        {
            KingKilledByPlayer();
            GameManager.instance.EnemyScore(king_score);
            string message = "+" + king_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }

        else if (collision.tag == "skillATT")
        {
            KingKilledByPlayer();
            GameManager.instance.EnemyScore(king_score);
            string message = "+" + king_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }
        else if (collision.tag == "Player" && king.tag == "KingCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
           // GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }

        else if (collision.tag == "KingCanKill")
        {
            KingKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            KingKilledByEnemy();
        }

        else if (collision.tag == "Hand")
        {
            KingKilledByEnemy();
        }


        else if (collision.tag == "PSW")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "PSW_over")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "RBp")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "RBover")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "QBattack")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "QBcanKilled")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "QBCanKill")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "BBCanKill")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "BBCanKilled")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "spearAtt")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "QBEatAtt")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "KBCanKill")
        {
            KingKilledByEnemy();
        }
        else if (collision.tag == "KBCanKilled")
        {
            KingKilledByEnemy();
        }

    }

    void Update()
    {

        KingDestroy();
        if (king.transform.position.y > 3.744f && king.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (king.transform.position.y > 2.656f && king.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (king.transform.position.y > 1.55f && king.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (king.transform.position.y > 0.458f && king.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (king.transform.position.y > -0.655f && king.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (king.transform.position.y > -1.75f && king.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (king.transform.position.y > -2.84f && king.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (king.transform.position.y > -3.94f && king.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
    public void KingDestroy() 
    {
        if (king.transform.position.x > 5.5)
        {
            Destroy(king);

        }
        if (king.transform.position.x < -4)
        {
            Destroy(king);
        }

        if (king.transform.position.y > 4.5)
        {
            Destroy(king);
        }
        if (king.transform.position.y < -5)
        {
            Destroy(king);
        }

    }

}
