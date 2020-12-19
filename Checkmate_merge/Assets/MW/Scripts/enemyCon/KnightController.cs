using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    [SerializeField] GameObject knight;
    public int knight_score;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void KnightKilledByPlayer()
    {
        Destroy(knight);
    }
    public void KnightKilledByEnemy()
    {
        Destroy(knight);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && knight.tag == "KnightCanKilled")
        {
            KnightKilledByPlayer();
            GameManager.instance.EnemyScore(knight_score);
        }


        else if (collision.tag == "Player" && knight.tag == "KnightCanKill")
        {
            Debug.Log("di");
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }




        else if (collision.tag == "KingCanKill")
        {
            KnightKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            KnightKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill")
        {
            KnightKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled")
        {
            KnightKilledByEnemy();
        }

        else if (collision.tag == "KnightCanKill")
        {
            KnightKilledByEnemy();
        }
 

        else if (collision.tag == "BishopCanKill")
        {
            KnightKilledByEnemy();
        }


        else if (collision.tag == "RockCanKill")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "RockCanKilled")
        {
            KnightKilledByEnemy();
        }

    }
    void Update()
    {

        PonDestroy();
    }
    public void PonDestroy() 
    {
        if (knight.transform.position.x > 5.5)
        {
            Destroy(knight);

        }
        if (knight.transform.position.x < -4)
        {
            Destroy(knight);
        }

        if (knight.transform.position.y > 4.5)
        {
            Destroy(knight);
        }
        if (knight.transform.position.y < -5)
        {
            Destroy(knight);
        }

    }

}
