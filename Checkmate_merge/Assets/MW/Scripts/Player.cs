using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{ 
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerControllUi;
    private Rigidbody2D playerRigidbody;
    //[SerializeField] PonController KingController; 
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();

        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerKilledByEnemy()
    {
        Destroy(player);
        Destroy(playerControllUi);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PonCanKilled")
        {
            GameObject.Find("Pon").GetComponent<PonController>().PonKilledByPlayer();

        }
        else if (collision.tag == "PonCanKill")
        {
            PlayerKilledByEnemy();
        }


        if (collision.tag == "KingCanKilled")
        {
            GameObject.Find("King").GetComponent<KingController>().KingKilledByPlayer();

        }
        else if (collision.tag == "KingCanKill")
        {
            PlayerKilledByEnemy();
        }


        if (collision.tag == "RockCanKilled")
        {
            GameObject.Find("Rock").GetComponent<RockController>().RockKilledByPlayer();


        }
        else if (collision.tag == "RockCanKill")
        {
            PlayerKilledByEnemy();
        }


        if (collision.tag == "BishopCanKilled")
        {
            GameObject.Find("Bishop").GetComponent<BishopController>().BishopKilledByPlayer();


        }
        else if (collision.tag == "BishopCanKill")
        {
            PlayerKilledByEnemy();
        }



        if (collision.tag == "QueenCanKilled")
        {
            GameObject.Find("Queen").GetComponent<QueenController>().QueenKilledByPlayer();


        }
        else if (collision.tag == "QueenCanKill")
        {
            PlayerKilledByEnemy();
        }
    }



}
