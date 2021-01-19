using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearAtack : MonoBehaviour
{
    private SpriteRenderer sprite;
    public int sortingOrder = 0;
    public Animator animator;
    public GameObject SpearEF;
    // Start is called before the first frame update
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        StartCoroutine(end());
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && SpearEF.gameObject.tag == "spearAtt")//폰이 플레이어를 죽임(게임 오버)
        {
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            //GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }

    }
    IEnumerator end()
    {
        yield return new WaitForSeconds(0.0013022093023255812f);
        yield return new WaitForSeconds(0.0013022093023255812f);
        SpearEF.gameObject.tag = "spearAtt";

        yield return new WaitForSeconds(0.7f);
        Destroy(SpearEF);
    }



    // Update is called once per frame
    void Update()
    {

        if (SpearEF.transform.position.y > 3.744f && SpearEF.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (SpearEF.transform.position.y > 2.656f && SpearEF.transform.position.y < 3.743f)
        {
            sprite.sortingOrder = 2;
        }
        if (SpearEF.transform.position.y > 1.55f && SpearEF.transform.position.y < 2.655f)
        {
            sprite.sortingOrder = 3;
        }
        if (SpearEF.transform.position.y > 0.458f && SpearEF.transform.position.y < 1.54f)
        {
            sprite.sortingOrder = 4;
        }
        if (SpearEF.transform.position.y > -0.655f && SpearEF.transform.position.y < 0.457f)
        {
            sprite.sortingOrder = 5;
        }
        if (SpearEF.transform.position.y > -1.75f && SpearEF.transform.position.y < -0.656f)
        {
            sprite.sortingOrder = 6;
        }

        if (SpearEF.transform.position.y > -2.84f && SpearEF.transform.position.y < -1.76f)
        {
            sprite.sortingOrder = 7;
        }
        if (SpearEF.transform.position.y > -3.94f && SpearEF.transform.position.y < -2.85f)
        {
            sprite.sortingOrder = 8;
        }
    }
}
