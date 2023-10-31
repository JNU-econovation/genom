# genom(게임만드는놈들)
<br/>

![image](https://github.com/JNU-econovation/genom/assets/68218063/18375a81-3a57-4dce-88ff-a91a3eacc7bf)

 
에코노베이션 팀 프로젝트

<br/><br/>
    
[주제]  
체스 규칙을 기반으로하는 2D 액션게임 개발

![image](https://github.com/JNU-econovation/genom/assets/68218063/0fca57d1-30ed-4180-b238-08a4f78092eb)


<br/><br/>
[기술 스택]  

Unity3D / C# / Git


  


<br/><br/>
[개발 기능]  

캐릭터 조작 :

<details>
  
![image](https://github.com/JNU-econovation/genom/assets/68218063/a1d90104-b0e8-49a8-b57d-1f83567dfb26)
![image](https://github.com/JNU-econovation/genom/assets/68218063/ffa7315d-0472-4e42-ace2-e4d4f15ed269)

![image](https://github.com/JNU-econovation/genom/assets/54536107/f41ed53a-c178-405f-ae6c-3c9c2a56b70a)
![image](https://github.com/JNU-econovation/genom/assets/54536107/6c5bde40-e25c-4fb5-8683-fd0d26faa747)

<br/>
(PC에서)

키보드 방향키에 따라 먼저 Pivot이 각각 8방향 이동하고, 스페이스 키를 누르면 해당 위치로 이동하게 됩니다.


Q 키를 누르면 검기가 나와 주변 8칸에 있는 적을 처치합니다.

E 키를 누르면 거대한 손이 나와 체스판 위의 모든 적을 처치합니다.



<br/>
(모바일에서)

왼쪽의 조이스틱을 조작하야 방향을 지정하고 검 모양 버턴을 눌러 해당 방향으로 이동합니다.

검 위의 좌측 버튼을 클릭하면 검기가 나와 주변 8칸에 있는 적을 처치합니다.

검 위의 우측 버튼을 클릭하면 거대한 손이 나와 체스판 위의 모든 적을 처치합니다.

</details>






<br/><br/>
적 인공지능 :

<details>

BT(행동 트리)를 이용하여 적 기물 인공지능 개발을 진행했습니다.

![image](https://github.com/JNU-econovation/genom/assets/68218063/ea73d5ab-17e8-4fb5-bb89-dbdbeb5d0007)

각 기물마다 TreeAI 스크립트를 통해 사전에 생성된 노드를 조작합니다.

또한 각각의 Controller를 통해 보다 상위 기물에 닿으면 자동으로 파괴되도록 지정했습니다.


![image](https://github.com/JNU-econovation/genom/assets/54536107/ec7a2245-cd0b-4fff-9600-465ae18e9fd6)

폰 : 플레이어 위치 확인 -> 이동 -> 대기 를 반복합니다

<br/>

![image](https://github.com/JNU-econovation/genom/assets/54536107/76d1cc01-c7c3-452e-81db-1470e4be24f7)

룩 : 플레이어 위치 확인 -> 직선이동 -> 자동파괴

<br/>

![image](https://github.com/JNU-econovation/genom/assets/54536107/422bd5f4-16d6-4b4f-83a2-ef4b1f49de81)

비숍 : 플레이어 위치 확인 -> 대각선이동 -> 자동파괴

<br/>

![image](https://github.com/JNU-econovation/genom/assets/54536107/cbb9297e-b20c-4229-8e6c-17c90c6503c6)

나이트 : 1차 나이트 이동 위치 확인 -> 2차 나이트 이동 위치 확인 -> 이동 -> 대기 

<br/>

![image](https://github.com/JNU-econovation/genom/assets/54536107/8dc8160b-ef04-4f43-9ec9-b6b3f0d5fd23)

퀸 : 대각위치에 플레이어가 있는지 확인 -> 직선 위치상 가로, 세로 중에서 가까운 위치로 이동  -> 대기 

<br/>

![image](https://github.com/JNU-econovation/genom/assets/54536107/83606d7d-c872-4ec8-84ac-8b4c1478e38c)

킹 : 플레이어 위치 확인 -> 이동 -> 대기 

<br/>

</details>
  


<br/><br/>
구성된 기물 패턴화 작업 :

<details>
스포너를 이용해 각 단계별로 사전에 지정해 둔 패턴중 하나를 랜덤으로 소환합니다.

좌표를 체스판과 같이 A8 ~ H1 까지 지정해두고 해당 위치에 소환하도록 합니다.

![image](https://github.com/JNU-econovation/genom/assets/54536107/6b3e509a-8ec4-418a-942f-b546519c40d3)

![image](https://github.com/JNU-econovation/genom/assets/54536107/ead0147a-7ab7-43f2-bfbe-5cba3107fa04)

</details>



<br/><br/>
인게임 도트 그래픽 및 애니메이션 작업 및 연결 : 
<details>
플레이어가 바라보는 8방향 마다 그래픽을 별도로 제작하여 조작 시 이동 방향을 확인할 수 있도록 합니다.

연결시에는 애니메이션 블랜드 트리를 이용하였습니다.

![image](https://github.com/JNU-econovation/genom/assets/54536107/b236489f-044f-4019-87fb-ad674afadcbe)

![image](https://github.com/JNU-econovation/genom/assets/54536107/36b3ae72-6c36-49e1-a02a-61496db14087)


</details>



  
