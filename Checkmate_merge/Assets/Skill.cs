using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Skill : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator animator;
    public GameObject playerpos;
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
        attPos = playerpos.transform.position;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (isCoolTime == false)
            {
                Instantiate(skillATT, attPos, Quaternion.identity);
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
            Instantiate(skillATT, attPos, Quaternion.identity);
            animator.SetFloat("MAG", 1);
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

