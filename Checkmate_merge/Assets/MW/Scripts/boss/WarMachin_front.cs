using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WarMachin_front : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
        transform.Translate(Vector3.down * 15f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Player" )//폰이 플레이어를 죽임(게임 오버)
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }


    }
    void Destroy()
    {
        if (transform.position.y < -10)
        {
            Destroy(self);
        }
    }

}
