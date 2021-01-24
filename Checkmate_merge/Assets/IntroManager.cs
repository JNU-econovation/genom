using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroManager : MonoBehaviour
{

    public SpriteRenderer firstAni_1;
    public SpriteRenderer firstAni_2;
    public SpriteRenderer firstAni_3;
    public SpriteRenderer firstAni_4;

    public SpriteRenderer SecondAni_1;
    public SpriteRenderer SecondAni_2;
    public SpriteRenderer SecondAni_3;
    public SpriteRenderer SecondAni_31;
    public SpriteRenderer SecondAni_4;
    public SpriteRenderer SecondAni_5;
    public SpriteRenderer SecondAni_6;
    public SpriteRenderer SecondAni_7;
    public SpriteRenderer black;
    public SpriteRenderer white;
    public GameObject SecondAni_4Pos;
    public GameObject SecondAni_5Pos;
    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android) Application.targetFrameRate = 60;
        StartCoroutine(firstAnimation());
    }
    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);
        StartCoroutine((secAnimation()));
    }
    float timer = 0.01f;
    int chekcer = 100;
    IEnumerator firstAnimation()
    {
        for(int i =0;i< chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            firstAni_1.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            firstAni_2.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            firstAni_3.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            firstAni_4.transform.position = firstAni_4.transform.position + new Vector3(0, -0.02f);
            firstAni_4.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            firstAni_4.color -= new Color(1, 1, 1, timer);
            firstAni_3.color -= new Color(1, 1, 1, timer);
            firstAni_2.color -= new Color(1, 1, 1, timer);
            firstAni_1.color -= new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(secAnimation());

    }
    IEnumerator secAnimation()
    {
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            SecondAni_1.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            SecondAni_2.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            SecondAni_3.color += new Color(1, 1, 1, timer);
            SecondAni_31.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            SecondAni_4Pos.transform.position = SecondAni_4Pos.transform.position +new Vector3(0, 0.015f);
            SecondAni_5Pos.transform.position = SecondAni_5Pos.transform.position + new Vector3(0, -0.015f);
            SecondAni_5.color += new Color(1, 1, 1, 0.01f);
            SecondAni_4.color += new Color(1, 1, 1, 0.01f);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            SecondAni_6.color += new Color(1, 1, 1, timer);
            SecondAni_31.color -= new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            black.color += new Color(1, 1, 1, timer);

        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < chekcer; i++)
        {
            yield return new WaitForSeconds(timer);
            SecondAni_7.transform.position = SecondAni_7.transform.position + new Vector3(-0.029f*2f, 0);
            SecondAni_7.color += new Color(1, 1, 1, timer);
        }
        yield return new WaitForSeconds(1.5f);


        for (int i = 0; i < chekcer*2; i++)
        {
            yield return new WaitForSeconds(timer);
            white.color += new Color(1, 1, 1, timer/2);
            SecondAni_7.color -= new Color(1, 1, 1, timer*2);
            SecondAni_6.color -= new Color(1, 1, 1, timer * 2);
        }

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Menu");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
