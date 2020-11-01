using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform rectBackground;
    [SerializeField] private RectTransform rectJoystick;


    private float radius;

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject PlayerPivot;


    private bool isTouch = false;
    private bool isMove = false;
    private Vector3 movePosition;
    // Start is called before the first frame update
    void Start()
    {
        radius = rectBackground.rect.width * 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        MoveDir();

    }

    public void OnDrag(PointerEventData eventData)
    {

        //value에 상대위치 저장
        Vector2 value = eventData.position - (Vector2)rectBackground.position;

        //범위 안에 가두기
        value = Vector2.ClampMagnitude(value, radius);
        rectJoystick.localPosition = value;
        value = value.normalized;


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rectJoystick.localPosition = Vector3.zero;
        isTouch = false;
    }

    public void Move()
    {
        Player.transform.position = PlayerPivot.transform.position;
        isMove = true;

    }

    private void PivotReset()
    {
        if (isMove)
        {
            PlayerPivot.transform.position = new Vector3(0, 0, 0);
            isMove = false;
        }
    }

    public void MoveDir()
    {
        if (isTouch)
        {
            if (rectJoystick.localPosition.x >= 25f)
            {
                if (rectJoystick.localPosition.y < 25f && rectJoystick.localPosition.y > -25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(1.1f, 0f);

                }
                if (rectJoystick.localPosition.y < 50f && rectJoystick.localPosition.y > 25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(1.1f, 1.1f);
                }
                if (rectJoystick.localPosition.y < -25f && rectJoystick.localPosition.y > -50f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(1.1f, -1.1f);
                }
            }

            if(rectJoystick.localPosition.x >-25f && rectJoystick.localPosition.x < 25f)
            {
                if (rectJoystick.localPosition.y > 25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(0f, 1.1f);
                }
                if (rectJoystick.localPosition.y < -25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(0f, -1.1f);
                }
            }

            if (rectJoystick.localPosition.x <= -25f)
            {


                if (rectJoystick.localPosition.y < 25f && rectJoystick.localPosition.y > -25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(-1.1f, 0f);
                }
                if (rectJoystick.localPosition.y < 50f && rectJoystick.localPosition.y > 25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(-1.1f, 1.1f);
                }
                if (rectJoystick.localPosition.y < -25f && rectJoystick.localPosition.y > -50f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(-1.1f, -1.1f);
                }

            }


        }


        if (!isTouch)
        {
            PlayerPivot.transform.localPosition = Vector3.zero;
        }
    }
}
