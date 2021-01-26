using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] GameObject rock;
    int rock_score=4;
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
        Destroy(rock);
    }


    public void RockKilledByPlayer()
    {
        animator.SetFloat("Die", 1);
        rock.gameObject.tag = "Untagged";
        StartCoroutine(die());
    }
    public void RockKilledByEnemy()
    {
        animator.SetFloat("Die", 1);
        rock.gameObject.tag = "Untagged";
        StartCoroutine(die());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && rock.tag == "RockCanKilled")
        {
            // 점수 올리는 문항
            RockKilledByPlayer();
            GameManager.instance.EnemyCountScore(4);// 카운터 +1
            if (GameManager.isPlay == true)
            {
                GameManager.instance.EnemyScore(rock_score);

                string message = "+" + rock_score;
                FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
            }


        }

        else if (collision.tag == "skillATT")
        {
            RockKilledByPlayer();
            GameManager.instance.EnemyCountScore(4);// 카운터 +1
            if (GameManager.isPlay == true)
            {
                GameManager.instance.EnemyScore(rock_score);

                string message = "+" + rock_score;
                FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
            }


        }
        else if (collision.tag == "Player" && rock.tag == "RockCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            //GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }
        else if (collision.tag == "Hand")
        {
            RockKilledByEnemy();
        }

        else if (collision.tag == "KingCanKill")
        {
            RockKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            RockKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill")
        {
            RockKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled")
        {
            RockKilledByEnemy();
        }

      
        else if (collision.tag == "RockCanKill")
        {

            RockKilledByEnemy();
        }
        else if (collision.tag == "RockCanKilled")
        {

            RockKilledByEnemy();
        }
        else if (collision.tag == "PSW")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "PSW_over")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "RBp")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "RBover")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "QBattack")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "QBcanKilled")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "QBCanKill")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "BBCanKill")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "BBCanKilled")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "spearAtt")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "QBEatAtt")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "KBCanKill")
        {
            RockKilledByEnemy();
        }
        else if (collision.tag == "KBCanKilled")
        {
            RockKilledByEnemy();
        }


    }


    void Update()
    {

        RockDestroy();
        if (rock.transform.position.y > 3.744f && rock.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (rock.transform.position.y > 2.656f && rock.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (rock.transform.position.y > 1.55f && rock.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (rock.transform.position.y > 0.458f && rock.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (rock.transform.position.y > -0.655f && rock.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (rock.transform.position.y > -1.75f && rock.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (rock.transform.position.y > -2.84f && rock.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (rock.transform.position.y > -3.94f && rock.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
    public void RockDestroy() 
    {
        if (rock.transform.position.x > 5.5)
        {
            Destroy(rock);

        }
        if (rock.transform.position.x < -4)
        {
            Destroy(rock);
        }

        if (rock.transform.position.y > 4.5)
        {
            Destroy(rock);
        }
        if (rock.transform.position.y < -5)
        {
            Destroy(rock);
        }

    }

}
