    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class eatAtt : MonoBehaviour
{
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    public Animator animator;
    public GameObject lightningEF;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (lightningEF.transform.position.y > 3.744f && lightningEF.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (lightningEF.transform.position.y > 2.656f && lightningEF.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (lightningEF.transform.position.y > 1.55f && lightningEF.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (lightningEF.transform.position.y > 0.458f && lightningEF.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (lightningEF.transform.position.y > -0.655f && lightningEF.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (lightningEF.transform.position.y > -1.75f && lightningEF.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (lightningEF.transform.position.y > -2.84f && lightningEF.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (lightningEF.transform.position.y > -3.94f && lightningEF.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
    IEnumerator Timer()
    {
        lightningEF.gameObject.tag = "Untagged";
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 3);
        animator.SetFloat("Mag", 1);
        yield return new WaitForSeconds(0.3f);
        lightningEF.gameObject.tag = "QBEatAtt";
        yield return new WaitForSeconds(1.20f);
        Destroy(lightningEF);
    }

    void animation()
    {
        if(lightningEF.gameObject.tag == "QBattack")
        {

            StartCoroutine(end());
        }

    }
    IEnumerator end()
    {
        yield return new WaitForSeconds(0.9f);
        Destroy(lightningEF);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {


        if (collision.tag == "Player" && lightningEF.gameObject.tag == "QBEatAtt")//폰이 플레이어를 죽임(게임 오버)
        {
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            //GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }


    }
}
