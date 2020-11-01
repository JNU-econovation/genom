using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClockButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private VirtualJoystick virtualJoystick;
    [SerializeField] private RectTransform clickButton;

    public bool isClick = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        isClick = true;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            virtualJoystick.Move();
        }
        
        if (isClick)
        {
            virtualJoystick.Move();
        }
        
    }
}

