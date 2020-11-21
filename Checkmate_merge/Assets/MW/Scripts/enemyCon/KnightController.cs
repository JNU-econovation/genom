using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    [SerializeField] GameObject knight;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PonKilledByPlayer()
    {
        Destroy(knight);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (knight.tag == "KnightCanKilled")
        {
            // 폰이 죽였을때 점수 올리는 문항
            PonKilledByPlayer();

        }


        else 
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();


        
    }
    void Update()
    {

        PonDestroy();
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
        if (knight.transform.position.y < -5)
        {
            Destroy(knight);
        }

    }

}
