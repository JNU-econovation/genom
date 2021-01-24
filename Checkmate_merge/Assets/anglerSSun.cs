using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anglerSSun : MonoBehaviour
{
    GameObject player;
    public Animator animator;
    [SerializeField] GameObject SSun;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("PlayerPos");
        SSun.gameObject.tag = "BBCanKill";
        StartCoroutine(timer());
    }
    public void endBishopBoss()
    {
        SSun.gameObject.tag = "BBCanKilled";
    }

    // Update is called once per frame
    void Update()
    {
        if (SSun.transform.tag == "BBCanKilled")
        {
            animator.SetFloat("Mag", 3);
        }
    }
    void Die()
    {        
        GameObject.Find("GameManager").GetComponent<GameManager>().BishopBossDialog();//비숍 대사
        Destroy(SSun);
    }
    public GameObject BBligt;
    IEnumerator BBeatAttak()
    {
        if (transform.gameObject.tag == "BBCanKill")
        {

            Instantiate(BBligt, player.transform.position + new Vector3(0, 0.7f, 0), Quaternion.identity);
            StartCoroutine(timer());
            yield return null;
        }


    }

    IEnumerator timer()
    {
        if (transform.gameObject.tag != "QBCanKilled")
        {
            yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);
            StartCoroutine(BBeatAttak());
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && SSun.tag == "BBCanKilled")
        {
            Die();

        }
        if (collision.tag == "Hand")
        {
            Die();
            //GameManager.instance.EnemyScore(king_score);
        }

        else if (collision.tag == "Player" && SSun.tag == "BBCanKill")
        {
            Debug.Log("di");
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }


    }
}
