using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    [SerializeField] GameObject rock;

    // Start is called before the first frame update
    void Start()
    {

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
            // 폰이 죽였을때 점수 올리는 문항
            RockKilledByPlayer();

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
