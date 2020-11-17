using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Character : MonoBehaviour
{


    public float moveWaitTime;   // 이동하는데 기다려야 하는 시간
    public float moveSpeed;      // 이동 속도
    public GameObject pivot;

    public bool isMove;          // 이동중인지 확인
    public bool canMove;          // 움직을 수 있는지
    public bool isDead;          // 죽었는지 확인
    public bool cankilled;       // 죽을수 있는 상태인지 확인


    public AudioSource audio;    // 사용할 오디오 소스 
    public Animator animator;    // 사용할 애니메이터
    public Collider2D collider;  // 사용할 콜라이더

    public Vector2 myPosition;
    public Vector2 pivotPosition;
    public Vector2 lookDirection;// 보고 있는 방향


    void Start()
    {
        isMove = false;
        canMove = false;
        isDead = false;
        cankilled = true;

    }



    public void CanMove()             //움직일 수 있는 상황인지 확인.
    {
        float intervalTime = Time.deltaTime;

        if(moveWaitTime < intervalTime)
        {
            canMove = true;
            intervalTime = 0f;
        }
    }


    public void Die()
    {
        if(isDead && cankilled)
        {
            // 적은 죽으면 사라지고, 플레이어가 죽으면  적 스폰 및 이동 모두 중지된다.
        }
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
