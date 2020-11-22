using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    [SerializeField] GameObject rock;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void RockKilledByPlayer()
    {
        Destroy(rock);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rock.tag == "RockCanKilled")
        {
            RockKilledByPlayer();

        }
        else if (rock.tag == "RockCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
            GameManager.instance.GameOver();//플레이어를 죽이면 게임오버 함수 호출
        }
    }


    void Update()
    {

        RockDestroy();
    }
    public void RockDestroy() 
    {
        if (rock.transform.position.x > 5.5)
        {
            Destroy(rock);

        }
        if (rock.transform.position.x < -4)
        {
            Destroy(rock);
        }

        if (rock.transform.position.y > 4.5)
        {
            Destroy(rock);
        }
        if (rock.transform.position.y < -5)
        {
            Destroy(rock);
        }

    }

}
