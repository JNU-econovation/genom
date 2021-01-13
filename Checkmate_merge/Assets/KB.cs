using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KB : MonoBehaviour
{
    Vector2 up = new Vector2(0, 1.1f);
    Vector2 down = new Vector2(0, -1.1f);
    Vector2 left = new Vector2(-1.1f, 0);
    Vector2 right = new Vector2(1.1f, 0);

    Vector2 rightup = new Vector2(1.1f, 1.1f);
    Vector2 leftup = new Vector2(-1.1f, 1.1f);
    Vector2 rightdown = new Vector2(1.1f, -1.1f);
    Vector2 leftdown = new Vector2(-1.1f, -1.1f);








    float duration = 0.23255813953488372093023255813953f * 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(moveCoroutine1(up));
    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator moveCoroutine1(Vector2 endpos)
    {
        float startTime = Time.time;
        Vector2 startPos = transform.localPosition;
        Vector2 endend = new Vector2(startPos.x + endpos.x, startPos.y + endpos.y);
        while (Time.time - startTime <= duration)
        {
            transform.localPosition = Vector2.Lerp(startPos, endend, (Time.time - startTime) / duration);
            yield return null;
        }

        StartCoroutine(moveCoroutine2(rightup));
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


    }

}
