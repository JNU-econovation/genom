using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    [SerializeField] GameObject rock;
    public int rock_score;
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    public void RockKilledByPlayer()
    {
        Destroy(rock);
    }
    public void RockKilledByEnemy()
    {
        Destroy(rock);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && rock.tag == "RockCanKilled")
        {
            // 점수 올리는 문항
            RockKilledByPlayer();
            GameManager.instance.EnemyScore(rock_score);

        }


        else if (collision.tag == "Player" && rock.tag == "RockCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
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




    }


    void Update()
    {

        RockDestroy();
        if (rock.transform.position.y > 3.744f && rock.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (rock.transform.position.y > 2.656f && rock.transform.position.y < 3.744f)
        {
            sprite.sortingOrder = 2;
        }
        if (rock.transform.position.y > 1.55f && rock.transform.position.y < 2.656f)
        {
            sprite.sortingOrder = 3;
        }
        if (rock.transform.position.y > 0.458f && rock.transform.position.y < 1.55f)
        {
            sprite.sortingOrder = 4;
        }
        if (rock.transform.position.y > -0.655f && rock.transform.position.y < 0.458f)
        {
            sprite.sortingOrder = 5;
        }
        if (rock.transform.position.y > -1.75f && rock.transform.position.y < -0.655f)
        {
            sprite.sortingOrder = 6;
        }

        if (rock.transform.position.y > -2.84f && rock.transform.position.y < -1.75f)
        {
            sprite.sortingOrder = 7;
        }
        if (rock.transform.position.y > -3.94f && rock.transform.position.y < -2.84f)
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
