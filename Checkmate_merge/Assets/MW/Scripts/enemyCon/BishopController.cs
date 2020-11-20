using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopController : MonoBehaviour
{
    [SerializeField] GameObject bishop;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void BishopKilledByPlayer()
    {
        Destroy(bishop);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bishop.tag == "BishopCanKilled")
        {
            BishopKilledByPlayer();

        }
        else if (bishop.tag == "BishopCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }
    }


    void Update()
    {

        BishopDestroy();
    }
    public void BishopDestroy() 
    {
        if (bishop.transform.position.x > 5.5)
        {
            Destroy(bishop);

        }
        if (bishop.transform.position.x < -4)
        {
            Destroy(bishop);
        }

        if (bishop.transform.position.y > 4.5)
        {
            Destroy(bishop);
        }
        if (bishop.transform.position.y < -5)
        {
            Destroy(bishop);
        }

    }

}
