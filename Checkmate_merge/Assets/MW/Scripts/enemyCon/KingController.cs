using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingController : MonoBehaviour
{
    [SerializeField] GameObject king;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void KingKilledByPlayer()
    {
        Destroy(king);
    }
    public void KingKilledByEnemy()
    {
        Destroy(king);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && king.tag == "KingCanKilled")
        {
            KingKilledByPlayer();

        }


        else if (collision.tag == "Player" && king.tag == "KingCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }

        else if (collision.tag == "KingCanKill")
        {
            KingKilledByEnemy();
        }

        else if (collision.tag == "KingCanKilled")
        {
            KingKilledByEnemy();
        }






    }

    void Update()
    {

        KingDestroy();
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
