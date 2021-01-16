using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KB : MonoBehaviour
{
    public Animator animator;
    GameObject player;
    [SerializeField] GameObject KBv;
    [SerializeField] GameObject KBPivot;
    [SerializeField] GameObject spearAttUP;
    [SerializeField] GameObject spearAttDOWN;
    [SerializeField] GameObject spearAttLEFT;
    [SerializeField] GameObject spearAttRIGHT;
    Vector2 up = new Vector2(0, 1.1f);
    Vector2 down = new Vector2(0, -1.1f);
    Vector2 left = new Vector2(-1.1f, 0);
    Vector2 right = new Vector2(1.1f, 0);

    Vector2 rightup = new Vector2(1.1f, 1.1f);
    Vector2 leftup = new Vector2(-1.1f, 1.1f);
    Vector2 rightdown = new Vector2(1.1f, -1.1f);
    Vector2 leftdown = new Vector2(-1.1f, -1.1f);

    int counter;
    int hold = 0;

    float duration = 0.23255813953488372093023255813953f * 2f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        StartCoroutine(moveCoroutine1(up));
    }

    // Update is called once per frame
    void Update()
    {
        moveDir();
        //player = GameObject.FindWithTag("Player");
        //SetDir();
    }
    IEnumerator moveCoroutine1(Vector2 endpos)
    {
        float startTime = Time.time;

        if (endpos == up)
        {
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", 1);
        }
        if (endpos == down)
        {
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", -1);
        }
        if (endpos == left)
        {
            animator.SetFloat("Hor", -1);
            animator.SetFloat("Ver", 0);
        }
        if (endpos == right)
        {
            animator.SetFloat("Hor", 1);
            animator.SetFloat("Ver", 0);

        }

        Vector2 startPos = transform.localPosition;
        Vector2 endend = new Vector2(startPos.x + endpos.x, startPos.y + endpos.y);
        while (Time.time - startTime <= duration)
        {
            transform.localPosition = Vector2.Lerp(startPos, endend, (Time.time - startTime) / duration);
            yield return null;
        }
        if (endpos == up)
        {
            counter = 1;
            StartCoroutine(moveCoroutine2(rightup));
        }
        if (endpos == down)
        {
            counter = 2;
            StartCoroutine(moveCoroutine2(leftdown));
        }
        if (endpos == left)
        {
            counter = 3;
            StartCoroutine(moveCoroutine2(leftup));
        }
        if (endpos == right)
        {
            counter = 4;
            StartCoroutine(moveCoroutine2(rightdown));
        }

    }

    IEnumerator moveCoroutine2(Vector2 endpos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;
        Vector2 endend = new Vector2(startPos.x + endpos.x, startPos.y + endpos.y);
        while (Time.time - startTime <= duration)
        {
            transform.localPosition = Vector2.Lerp(startPos, endend, (Time.time - startTime) / duration);
            yield return null;
        }
        StartCoroutine(spearAttack());

    }

    IEnumerator spearAttack()
    {
        if(hold != 1)
        {
            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", 1);
            Instantiate(spearAttUP, new Vector2(KBv.transform.position.x, KBv.transform.position.y + 1.1f), Quaternion.identity);

            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            animator.SetFloat("Hor", -1);
            animator.SetFloat("Ver", 0);
            Instantiate(spearAttLEFT, new Vector2(KBv.transform.position.x - 1.1f, KBv.transform.position.y), Quaternion.identity);


            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", -1);
            Instantiate(spearAttDOWN, new Vector2(KBv.transform.position.x, KBv.transform.position.y - 1.1f), Quaternion.identity);
            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            animator.SetFloat("Hor", 1);
            animator.SetFloat("Ver", 0);
            Instantiate(spearAttRIGHT, new Vector2(KBv.transform.position.x + 1.1f, KBv.transform.position.y), Quaternion.identity);
        }
        else if (hold == 1)
        {
            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", 1);
            Instantiate(spearAttUP, new Vector2(KBv.transform.position.x, KBv.transform.position.y + 1.1f), Quaternion.identity);

            yield return new WaitForSeconds(0.93023255813953488372093023255812f);
            animator.SetFloat("Hor", 1);
            animator.SetFloat("Ver", 0);
            Instantiate(spearAttRIGHT, new Vector2(KBv.transform.position.x + 1.1f, KBv.transform.position.y), Quaternion.identity);
        }
        hold = 0;
        StartCoroutine(Timer());
    }



    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 3);
        if (counter == 1)
        {
            hold = 1;
            StartCoroutine(moveCoroutine1(left));
        }
        if (counter == 3)
        {
            StartCoroutine(moveCoroutine1(down));
        }
        if (counter == 2)
        {
            StartCoroutine(moveCoroutine1(right));
        }
        if (counter == 4)

        {
            StartCoroutine(moveCoroutine1(up));
        }
    }




    public void moveDir()
    {
        if (KBPivot.transform.localPosition.x > 0.5f)
        {
            animator.SetFloat("Hor", 1);
            animator.SetFloat("Ver", 0);
        }
        if (KBPivot.transform.localPosition.x < -0.5f)
        {
            animator.SetFloat("Hor", -1);
            animator.SetFloat("Ver", 0); 
        }
        if (KBPivot.transform.localPosition.y > 0.5f)
        {
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", 1);
        }
        if (KBPivot.transform.localPosition.y < -0.5f )
        {
            animator.SetFloat("Hor", 0);
            animator.SetFloat("Ver", -1);
        }
    }
    public void SetDir()
    {
        if (Mathf.Abs(player.transform.position.x - KBv.transform.position.x) > Mathf.Abs(player.transform.position.y - KBv.transform.position.y))
        {
            if ((player.transform.position.x - KBv.transform.position.x) > 0)
            {
                KBPivot.transform.localPosition = new Vector3(1.1f, 0, 0);
            }
            if ((player.transform.position.x - KBv.transform.position.x) <= 0)
            {
                KBPivot.transform.localPosition = new Vector3(-1.1f, 0, 0);
            }
        }
        if (Mathf.Abs(player.transform.position.x - KBv.transform.position.x) <= Mathf.Abs(player.transform.position.y - KBv.transform.position.y))
        {
            if ((player.transform.position.y - KBv.transform.position.y) > 0)
            {
                KBPivot.transform.localPosition = new Vector3(0, 1.1f, 0);
            }
            if ((player.transform.position.y - KBv.transform.position.y) <= 0)
            {
                KBPivot.transform.localPosition = new Vector3(0, -1.1f, 0);
            }
        }


    }
}
