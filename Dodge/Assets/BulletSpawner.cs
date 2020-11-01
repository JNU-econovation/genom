using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefab;//탄알을 생성하는 데 사용할 탄알의 원본 프리팹/ bulletprefab은 GameObject중 Bullet을 가리킨다
    public float spawnRateMin = 0.5f;//새 탄알을 생성하는 데 걸리는 시간의 최솟값
    public float spawnRateMax = 3f;//새 탄알을 생성하는 데 걸리는 시간의 최댓값

    private Transform target;//조준할 게임 오브젝트(player)의 트랜스폼 컴포넌트를 가리킴
    private float spawnRate;//다음 탄알을 생성할 때까지 대기 시간. spawnRateMin과 spawnRateMax 사이의 랜덤값
    private float timeAfterSpawn;//탄알 생성 후의 시간, 즉 '타이머'



    void Start()
    {
        timeAfterSpawn = 0f;//최근 생성 이후의 누적 시간을 0으로 초기화
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);//탄알 생성 간격을 탄알 생성 시간 최솟값과 최댓값 사이에서 랜덤 지정
        
        target = FindObjectOfType<PlayerController>().transform;//PlayerController컴포넌트를 가진 게임 오브젝트(player)을 찾아 그것의 트랜스폼을 조준 대상으로 설정
    }

    
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;//timeAfterspawm 갱신

        if(timeAfterSpawn>=spawnRate)//마지막 생성 시점부터 누적된 시간이, 생성 주기보다 크거나 같다면
        {
            timeAfterSpawn = 0f;// 타이머는 0으로 초기화

            GameObject bullet = Instantiate(bulletprefab, transform.position, transform.rotation);//bulletprefab의 복제본을 
                                                                                                  //transform.position(위치)와 transform.rotation(회전)으로 생성
            
            bullet.transform.LookAt(target);//생성된 bullet 게임 오브젝트의 정면 방향이 target을 향하도록 회전

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);//다음번 생성 간격을 spawnRateMin,spawnRateMax 사이에서 랜덤 지정
        }
    }
}
// Time.deltaTime: 직전 update()실행과 현재 update()실행 사이 간격. 이것을 계속 누적하면 특정 시점으로부터 얼마나 시간이 흘렀는지 표현할 수 있음
// instantiate(원본,위치,회전): 원본을 복제