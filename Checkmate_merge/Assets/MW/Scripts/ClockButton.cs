using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClockButton : Character, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private VirtualJoystick virtualJoystick;
    [SerializeField] private RectTransform clickButton;

    public bool isClick = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick = true;
        virtualJoystick.Move();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            virtualJoystick.Move();
            StartCoroutine(wait(0.25f));
        }
        


    }
    IEnumerator wait(float delayTime)
    {

        yield return new WaitForSeconds(delayTime);

    }

    public void OnPointerUp(PointerEventData eventData)
    {

        isClick = false;
    }
}

