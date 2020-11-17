using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
public class VirtualJoystick : Character, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Transform myTransform;

    [SerializeField] private RectTransform rectBackground;
    [SerializeField] private RectTransform rectJoystick;

    private float radius;

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject PlayerPivot;

    private bool isTouch = false;

    float duration = 0.25f;


    private Vector3 movePosition;
    // Start is called before the first frame update
    void Start()
    {
        radius = rectBackground.rect.width * 0.5f;
        animator = Player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDir();
        CanMove();


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
        StartCoroutine(smoothMove(Player, PlayerPivot.transform.position));


    }



    public IEnumerator smoothMove(GameObject a,Vector3 toPos)
    {

        float startTime = Time.time;
        Vector2 startPos = a.transform.localPosition;



        while (Time.time - startTime <= duration)
        {
            a.transform.localPosition = Vector2.Lerp(startPos, toPos, ((Time.time - startTime) / duration) *2f);
            yield return null;
        }

        a.transform.localPosition = toPos;


    }





    public void CanMove()  // 범위밖으로 playerpivot 못나가게 막음
    {
        if (PlayerPivot.transform.position.x > 5)
        {
            PlayerPivot.transform.localPosition = Vector3.zero;
        }
        if (PlayerPivot.transform.position.x < -4 )
        {
            PlayerPivot.transform.localPosition = Vector3.zero;
        }

        if (PlayerPivot.transform.position.y > 4)
        {
            PlayerPivot.transform.localPosition = Vector3.zero;
        }
        if (PlayerPivot.transform.position.y < -5)
        {
            PlayerPivot.transform.localPosition = Vector3.zero;
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
                    animator.SetFloat("Horizontal", 0);
                    animator.SetFloat("Vertical", 1);
                    animator.SetFloat("Magnitude", 0.001f);


                }
                if (rectJoystick.localPosition.y < 50f && rectJoystick.localPosition.y > 25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(1.1f, 1.1f);
                    animator.SetFloat("Horizontal", 1);
                    animator.SetFloat("Vertical", 1);
                    animator.SetFloat("Magnitude", 0.001f);
                }
                if (rectJoystick.localPosition.y < -25f && rectJoystick.localPosition.y > -50f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(1.1f, -1.1f);
                    animator.SetFloat("Horizontal", -1);
                    animator.SetFloat("Vertical", 1);
                    animator.SetFloat("Magnitude", 0.001f);
                }
            }

            if(rectJoystick.localPosition.x >-25f && rectJoystick.localPosition.x < 25f)
            {
                if (rectJoystick.localPosition.y > 25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(0f, 1.1f);
                    animator.SetFloat("Horizontal", 1);
                    animator.SetFloat("Vertical", 0);
                    animator.SetFloat("Magnitude", 0.001f);

                }
                if (rectJoystick.localPosition.y < -25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(0f, -1.1f);
                    animator.SetFloat("Horizontal", -1);
                    animator.SetFloat("Vertical", 0);
                    animator.SetFloat("Magnitude", 0.001f);
                }
            }

            if (rectJoystick.localPosition.x <= -25f)
            {


                if (rectJoystick.localPosition.y < 25f && rectJoystick.localPosition.y > -25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(-1.1f, 0f);
                    animator.SetFloat("Horizontal", 0);
                    animator.SetFloat("Vertical", -1);
                    animator.SetFloat("Magnitude", 0.001f);
                }
                if (rectJoystick.localPosition.y < 50f && rectJoystick.localPosition.y > 25f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(-1.1f, 1.1f);
                    animator.SetFloat("Horizontal", 1);
                    animator.SetFloat("Vertical", -1);
                    animator.SetFloat("Magnitude", 0.001f);
                }
                if (rectJoystick.localPosition.y < -25f && rectJoystick.localPosition.y > -50f)
                {
                    PlayerPivot.transform.localPosition = new Vector2(-1.1f, -1.1f);
                    animator.SetFloat("Horizontal", -1);
                    animator.SetFloat("Vertical", -1);
                    animator.SetFloat("Magnitude", 0.001f);
                }

            }


        }


        if (!isTouch)
        {
            PlayerPivot.transform.localPosition = Vector3.zero;
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Magnitude", 0.01f);
        }
    }
}
