using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitNode : Node
{
    public float delayTime = 3f;
    private float count;
    private PonTreeAi ai;
    
    // Start is called before the first frame update

    public WaitNode(float delayTime, PonTreeAi ai)
    {
        this.delayTime = delayTime;
        this.ai = ai;
    }



    public override NodeState Evaluate()
    {
        //delayTime = 3f;

        ai.StopEvaluateCoroutine();
        //Debug.Log("Stop Coroutine");
        ai.StartWaitCoroutine(this);

        //Debug.Log("End Wait");
        if (IsWaiting)
        {
            IsWaiting = true;
            //Debug.Log("first 1");          
            return NodeState.SUCCESS;
        }
        else
        {
            IsWaiting = true;
            //Debug.Log("first 2");
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


    