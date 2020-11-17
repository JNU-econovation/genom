using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownControl : MonoBehaviour
{
    private int Timer = 0;

    public GameObject Num_A;//1
    public GameObject Num_B;//2
    public GameObject Num_C;//3
    public GameObject Num_Go;//Go

    private void Start()
    {

        Timer = 0;
        Num_A.SetActive(false);
        Num_B.SetActive(false);
        Num_C.SetActive(false);
        Num_Go.SetActive(false);
    }

    private void Update()
    {
        if (Timer == 0)
        {
            Time.timeScale = 0.0f;
        }
        if(Timer<=90)
        {
            Timer++;

            if (Timer < 30)
                Num_C.SetActive(true);
            if(Timer>=30)
            {
                Num_C.SetActive(false);
                Num_B.SetActive(true);
            }
            if(Timer>=60)
            {
                Num_B.SetActive(false);
                Num_A.SetActive(true);
            }
            if(Timer>=90)
            {
                Num_A.SetActive(false);
                Num_Go.SetActive(true);
                StartCoroutine(this.LoadingEnd());
                Time.timeScale = 1.0f;

            }
        }
    }
    IEnumerator LoadingEnd()
    { 
        yield return new WaitForSeconds(1.0f);
        Num_Go.SetActive(false);
    }
}
