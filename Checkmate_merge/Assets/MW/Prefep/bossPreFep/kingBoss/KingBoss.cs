using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingBoss : MonoBehaviour
{
    GameObject player;
    public Animator animator;
    [SerializeField] GameObject kingBoss;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("PlayerPos");
        kingBoss.gameObject.tag = "FinalBossCanKill";
        StartCoroutine(timer());
    }
    public void endBishopBoss()
    {
        kingBoss.gameObject.tag = "FinalBossCanKilled";
    }

    // Update is called once per frame
    void Update()
    {
        if (kingBoss.transform.tag == "FinalBossCanKilled")
        {
            animator.SetFloat("Mag", 3);
        }
    }
    void Die()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PonBossDialog();//킹 대사
        Destroy(kingBoss);
    }
    public GameObject BBligt;
    IEnumerator BBeatAttak()
    {
        if (transform.gameObject.tag == "FinalBossCanKill")
        {

            Instantiate(BBligt, player.transform.position + new Vector3(0, 0.7f, 0), Quaternion.identity);
            StartCoroutine(timer());
            yield return null;
        }


    }

    IEnumerator timer()
    {
        if (transform.gameObject.tag == "FinalBossCanKill")
        {
            yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);
            StartCoroutine(BBeatAttak());
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && kingBoss.tag == "FinalBossCanKilled")
        {
            Die();

        }
        if (collision.tag == "Hand")
        {
            Die();
            //GameManager.instance.EnemyScore(king_score);
        }

        else if (collision.tag == "Player" && kingBoss.tag == "FinalBossCanKill")
        {
            Debug.Log("di");
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }


    }
}
