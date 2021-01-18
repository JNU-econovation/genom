using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    public bool noDeathMode = true;
    static bool fisrtSpwan = true;

    Image  image;
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerControllUi;
    [SerializeField] GameObject playerPos;
    private Rigidbody2D playerRigidbody;
    public int sortingOrder = 0;
     SpriteRenderer sprite;
    //[SerializeField] PonController KingController; 



    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        image = player.GetComponent<Image>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.y > 3.744f && player.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (player.transform.position.y > 2.656f && player.transform.position.y < 3.744f)
        {
            sprite.sortingOrder = 2;
        }
        if (player.transform.position.y > 1.55f && player.transform.position.y < 2.656f)
        {
            sprite.sortingOrder = 3;
        }
        if (player.transform.position.y > 0.458f && player.transform.position.y < 1.55f)
        {
            sprite.sortingOrder = 4;
        }
        if (player.transform.position.y > -0.655f && player.transform.position.y < 0.458f)
        {
            sprite.sortingOrder = 5;
        }
        if (player.transform.position.y > -1.75f && player.transform.position.y < -0.655f)
        {
            sprite.sortingOrder = 6;
        }

        if (player.transform.position.y > -2.84f && player.transform.position.y < -1.75f)
        {
            sprite.sortingOrder = 7;
        }
        if (player.transform.position.y > -3.94f && player.transform.position.y < -2.84f)
        {
            sprite.sortingOrder = 8;
        }
    }

    public void PlayerKilledByEnemy()
    {
        if(noDeathMode == true)
        {

            StartCoroutine(whenReSpwan());
        }

        // 플레이어가 죽었을때 발동되는 함수들.
        else if(noDeathMode == false)
        {
            GameManager.instance.GameOver();//게임오버함수 호출
            Destroy(player);
            Destroy(playerControllUi);
            Destroy(playerPos);
        }

    }

    IEnumerator whenReSpwan()
    {

        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(twinkle());
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 3);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;


    }

    IEnumerator twinkle()
    {
        sprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 0.5f);
        sprite.color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 0.5f);
        sprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 0.5f);
        sprite.color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 0.5f);
        sprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 0.5f);
        sprite.color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 0.5f);

    }

}
