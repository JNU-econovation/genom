using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SpeacilATT : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float delayTime = 6600;
    public Image image;
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
    IEnumerator Wait()
    {

        image.fillAmount = 0;
        while (delayTime > 0)
        {

            image.fillAmount += (0.00015151515151515151515151515151515f);
            delayTime -= 1;
            yield return new WaitForSeconds(0.01f);
        }
        delayTime = 6600;

    }

    float cooldown = 66f;

    // Update is called once per frame
    void Update()
    {
        if (isCoolTime == true)
        {
            image.fillAmount += 1 / cooldown * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isCoolTime == false)
            {
                image.fillAmount = 0;
                Instantiate(skillATT, devilHandPos, Quaternion.identity);
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
            Instantiate(skillATT, devilHandPos, Quaternion.identity);
            //StartCoroutine(Wait());
            isCoolTime = true;
            StartCoroutine(coolTime());
        }

    }

    bool isCoolTime = false;

    IEnumerator coolTime()
    {
        yield return new WaitForSeconds(66f);

        isCoolTime = false;
    }
}

