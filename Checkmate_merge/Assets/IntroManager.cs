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
        StartCoroutine(firstAnimation());
    }
    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);
        StartCoroutine((secAnimation()));
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
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            firstAni_4.color -= new Color(1, 1, 1, 0.005f);
            firstAni_3.color -= new Color(1, 1, 1, 0.005f);
            firstAni_2.color -= new Color(1, 1, 1, 0.005f);
            firstAni_1.color -= new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(3f);
        StartCoroutine(secAnimation());

    }
    IEnumerator secAnimation()
    {
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            SecondAni_1.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            SecondAni_2.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            SecondAni_3.color += new Color(1, 1, 1, 0.005f);
            SecondAni_31.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 100; i++)
        {
            yield return new WaitForSeconds(0.005f);
            SecondAni_4Pos.transform.position = SecondAni_4Pos.transform.position +new Vector3(0, 0.005f);
            SecondAni_5Pos.transform.position = SecondAni_5Pos.transform.position + new Vector3(0, -0.005f);
            SecondAni_5.color += new Color(1, 1, 1, 0.01f);
            SecondAni_4.color += new Color(1, 1, 1, 0.01f);
        }
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            SecondAni_6.color += new Color(1, 1, 1, 0.005f);
            SecondAni_31.color -= new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);
            black.color += new Color(1, 1, 1, 0.005f);

        }
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(0.005f);

            SecondAni_7.color += new Color(1, 1, 1, 0.005f);
        }
        yield return new WaitForSeconds(3f);


        for (int i = 0; i < 400; i++)
        {
            yield return new WaitForSeconds(0.005f);
            white.color += new Color(1, 1, 1, 0.0025f);
            SecondAni_7.color -= new Color(1, 1, 1, 0.01f);
            SecondAni_6.color -= new Color(1, 1, 1, 0.01f);
        }

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("Menu");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
