using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WarMachin_back : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Player")//폰이 플레이어를 죽임(게임 오버)
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }


    }
    // Update is called once per frame
    void Update()
    {
        Destroy();
        transform.Translate(Vector3.up * 15f * Time.deltaTime);
    }


    void Destroy()
    {
        if (transform.position.y > 10)
        {
            Destroy(self);
        }
    }

}
