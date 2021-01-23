using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{

    public SpriteRenderer firstAni_1;
    public SpriteRenderer firstAni_2;
    public SpriteRenderer firstAni_3;
    public SpriteRenderer firstAni_4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fisrtTimer());
    }
    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);
        StartCoroutine((firstAnimation()));
    }
    IEnumerator firstAnimation()
    {
        for(int i =0;i<200;i++)
        {
            yield return new WaitForSeconds(0.005f);
            firstAni_1.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            firstAni_2.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            firstAni_3.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            firstAni_4.color += new Color(1, 1, 1, 0.005f);
        }



    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
