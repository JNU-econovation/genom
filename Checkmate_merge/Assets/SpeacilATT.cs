using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpeacilATT : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator animator;
    Vector2 devilHandPos = new Vector2(-18.25f, -1.46f);
    public GameObject skillATT;

    Vector2 attPos;

    [SerializeField] private RectTransform clickButton;

    public bool isClick = false;


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isCoolTime == false)
            {
                Instantiate(skillATT, devilHandPos, Quaternion.identity);
                animator.SetFloat("MAG", 1);
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
            Instantiate(skillATT, devilHandPos, Quaternion.identity);
            animator.SetFloat("MAG", 1);
            isCoolTime = true;
            StartCoroutine(coolTime());
        }

    }

    bool isCoolTime = false;

    IEnumerator coolTime()
    {
        yield return new WaitForSeconds(66f);
        animator.SetFloat("MAG", 0);
        isCoolTime = false;
    }
}

