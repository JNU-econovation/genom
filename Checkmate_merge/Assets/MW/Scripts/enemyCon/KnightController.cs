﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    [SerializeField] GameObject knight;
    public int knight_score;

    // Start is called before the first frame update
 

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

            string message = "+" + knight_score;
            FloatingManager.instance.CreateFloatingCanvas(message);//플로팅 텍스트
        }


        else if (collision.tag == "Player" && knight.tag == "KnightCanKill")
        {
            Debug.Log("di");
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }

        else if (collision.tag == "PSW")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "PSW_over")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "RBp")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "RBover")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "QBattack")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "QBcanKilled")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "QBCanKill")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "BBCanKill")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "BBCanKilled")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "spearAtt")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "QBEatAtt")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "KBCanKill")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "KBCanKilled")
        {
            KnightKilledByEnemy();
        }
        else if (collision.tag == "Hand")
        {
            KnightKilledByEnemy();
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

    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

        PonDestroy();

        if (knight.transform.position.y > 3.744f && knight.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (knight.transform.position.y > 2.656f && knight.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (knight.transform.position.y > 1.55f && knight.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (knight.transform.position.y > 0.458f && knight.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (knight.transform.position.y > -0.655f && knight.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (knight.transform.position.y > -1.75f && knight.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (knight.transform.position.y > -2.84f && knight.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (knight.transform.position.y > -3.94f && knight.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }

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
        if (knight.transform.position.y < -3.94f)
        {
            Destroy(knight);
        }

    }

}
