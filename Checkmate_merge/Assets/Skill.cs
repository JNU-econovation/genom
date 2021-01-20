using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Skill : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float delayTime = 600;
    public Image image;
    public Animator animator;
    public GameObject playerpos;
    public GameObject skillATT;

    Vector2 attPos;

    [SerializeField] private RectTransform clickButton;

    public bool isClick = false;

    public IEnumerator smoothMove()
    {
        delayTime = 600;
        float startTime = Time.time;
        image.fillAmount = 0;


        while (Time.time - startTime <= 6)
        {
            image.fillAmount += 0.00166666666666666666666666666667f * ((Time.time - startTime));

            yield return null;
        }


    }


    IEnumerator Wait()
    {

        image.fillAmount = 0;
        yield return null;


    }
    // Start is called before the first frame update
    void Start()
    {

    }


    float cooldown = 6f;

    // Update is called once per frame
    void Update()
    {
        if (isCoolTime == true)
        {
            image.fillAmount += 1 / cooldown * Time.deltaTime;
        }

        attPos = playerpos.transform.position;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (isCoolTime == false)
            {
                image.fillAmount = 0;
                Instantiate(skillATT, attPos, Quaternion.identity);
                //StartCoroutine(Wait());

                isCoolTime = true;
                StartCoroutine(coolTime());
            }
        }



    }


    public void OnPointerUp(PointerEventData eventData)
    {

        isClick = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isCoolTime == false)
        {
            image.fillAmount = 0;
            Instantiate(skillATT, attPos, Quaternion.identity);
            //StartCoroutine(Wait());
            isCoolTime = true;
            StartCoroutine(coolTime());
        }

    }

    bool isCoolTime = false;

    IEnumerator coolTime()
    {
        yield return new WaitForSeconds(6);
        animator.SetFloat("MAG", 0);
        isCoolTime = false;
    }
}

