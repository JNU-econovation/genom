using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenController : MonoBehaviour
{
    [SerializeField] GameObject queen;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void QueenKilledByPlayer()
    {
        Destroy(queen);
    }
    public void QueenKilledByEnemy()
    {
        Destroy(queen);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && queen.tag == "QueenCanKilled")
        {
            QueenKilledByPlayer();

        }


        else if (collision.tag == "Player" && queen.tag == "QueenCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }

       

        else if (collision.tag == "KingCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKill")
        {
            QueenKilledByEnemy();
        }

        else if (collision.tag == "QueenCanKilled")
        {
            QueenKilledByEnemy();
        }


    }

    void Update()
    {

        QueenDestroy();
    }
    public void QueenDestroy() 
    {
        if (queen.transform.position.x > 5.5)
        {
            Destroy(queen);

        }
        if (queen.transform.position.x < -4)
        {
            Destroy(queen);
        }

        if (queen.transform.position.y > 4.5)
        {
            Destroy(queen);
        }
        if (queen.transform.position.y < -5)
        {
            Destroy(queen);
        }

    }

}
