using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockWaitNode : Node
{
    public float delayTime;
    private float count;
    private RockTreeAi ai;
    
    // Start is called before the first frame update

    public RockWaitNode(float delayTime, RockTreeAi ai)
    {
        this.delayTime = delayTime;
        this.ai = ai;
    }



    public override NodeState Evaluate()
    {
        //delayTime = 3f;
        if (ai.isWait == false)
        {
            ai.StopEvaluateCoroutine();

            ai.StartWaitCoroutine(this);

            if (IsWaiting)
            {
                IsWaiting = true;
                ai.isWait = true;
                return NodeState.SUCCESS;
            }
            else
            {
                IsWaiting = true;

                return NodeState.FAILURE;
            }

        }

        else
            return NodeState.SUCCESS;




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


    