using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonController : MonoBehaviour
{
    [SerializeField] GameObject pon;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PonKilledByPlayer()
    {
        Destroy(pon);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pon.tag == "PonCanKilled")
        {
            // 폰이 죽였을때 점수 올리는 문항
            PonKilledByPlayer();

        }


        else if (pon.tag == "PonCanKill")
        {

            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }

        
    }
    void Update()
    {

        PonDestroy();
    }
    public void PonDestroy() 
    {
        if (pon.transform.position.x > 5.5)
        {
            Destroy(pon);

        }
        if (pon.transform.position.x < -4)
        {
            Destroy(pon);
        }

        if (pon.transform.position.y > 4.5)
        {
            Destroy(pon);
        }
        if (pon.transform.position.y < -5)
        {
            Destroy(pon);
        }

    }

}
