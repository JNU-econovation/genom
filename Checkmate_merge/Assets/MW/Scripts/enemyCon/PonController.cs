using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonController : MonoBehaviour
{
    [SerializeField] GameObject pon;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PonKilledByPlayer()
    {
        Destroy(pon);
    }
    public void PonKilledByEnemy()
    {
        Destroy(pon);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && pon.tag == "PonCanKilled")
        {
            // 폰이 죽였을때 점수 올리는 문항
            PonKilledByPlayer();

        }


        else if (collision.tag == "Player" && pon.tag == "PonCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
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
    void Update()
    {

        PonDestroy();
    }
    public void PonDestroy() 
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
