using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody bulletRigidbody;//이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;//탄알 이동 속력

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();//bulletRigidbody는 Rigidbody컴포넌트를 가리킴
        bulletRigidbody.velocity = transform.forward * speed;//리지드바디의 속도= 앞쪽방향(z축)*이동 속력

        Destroy(gameObject, 3f);//3초 뒤에 자신의 게임 오브젝트 파괴
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            if (playerController != null)
            {
                playerController.Die();
            }
        }

        
    }


}
