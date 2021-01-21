using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BossGage : MonoBehaviour
{

    public Image image;
    public Animator animator;
    public GameObject ME;
    float BpssdelayTime = 0.93023255813953488372093023255812f * 60;

    Vector2 attPos;


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(60);
        Destroy(ME);
        yield return null;


    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }


    float cooldown = 60;

    // Update is called once per frame
    void Update()
    {

            image.fillAmount -= 1 / BpssdelayTime * Time.deltaTime;






    }




}

