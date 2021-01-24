using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightWaitNode2 : Node
{
    public float delayTime = 3f;
    private float count;
    private KnightTreeAi ai;
    
    // Start is called before the first frame update

    public KnightWaitNode2(float delayTime, KnightTreeAi ai)
    {
        this.delayTime = delayTime;
        this.ai = ai;
    }



    public override NodeState Evaluate()
    {
        //delayTime = 3f;

        ai.StopEvaluateCoroutine();




        if (IsWaiting)
        {
            IsWaiting = true;
        
            return NodeState.SUCCESS;
        }
        else
        {
            IsWaiting = true;

            return NodeState.FAILURE;
        }




        //그나마 작동하는 코드
        /*
        count += Time.deltaTime;

  
        if (count > delayTime)
        {
            Debug.Log("3초 기다림이 완료되었습니다");
            count = 0;
            return NodeState.SUCCESS;
        }
        Debug.Log("3초를 기다리는 중입니다.");

        return NodeState.FAILURE;
        */


    }
}


    