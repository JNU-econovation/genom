using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anglerSSun : MonoBehaviour
{
    public Animator animator;
    [SerializeField] GameObject SSun;
    // Start is called before the first frame update
    void Start()
    {
        SSun.gameObject.tag = "BBCanKill";
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(30);
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
        Destroy(SSun);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && SSun.tag == "BBCanKilled")
        {
            Die();

        }


        else if (collision.tag == "Player" && SSun.tag == "BBCanKill")
        {
            Debug.Log("di");
            GameObject.Find("Player").GetComponent<Player>().PlayerKilledByEnemy();
        }


    }
}
